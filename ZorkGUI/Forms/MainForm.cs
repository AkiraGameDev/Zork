using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork;
using ZorkGUI.Controls;
using ZorkGUI.Forms;
using ZorkGUI.ViewModels;

namespace ZorkGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ViewModel = new GameViewModel();
            _ViewModel.PropertyChanged += _ViewModel_PropertyChanged;
            

            IsGameLoaded = false;

            _NeighborControls.AddRange(new NeighborControl[] { northNeighborControl, southNeighborControl, eastNeighborControl, westNeighborControl });
        }

        private void _ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            ViewModel.IsModified = true;
        }

        public GameViewModel ViewModel
        {
            get => _ViewModel;
            set
            {
                if(_ViewModel != value)
                {
                    _ViewModel = value;
                    gameViewModelBindingSource.DataSource = _ViewModel;
                }
            }
        }

        private void RefreshViewModel() {
            foreach (var neighborControl in _NeighborControls) {
                neighborControl.RefreshNeighbors(_ViewModel.Rooms);
            }
        }

        private bool IsGameLoaded
        {
            get => _IsWorldLoaded;
            set
            {
                _IsWorldLoaded = value;
                MainGroupBox.Enabled = _IsWorldLoaded;
                SaveGame.Enabled = _IsWorldLoaded;
                SaveGameAs.Enabled = _IsWorldLoaded;
                changeWorldSettingsToolStripMenuItem.Enabled = _IsWorldLoaded;
            }
        }


        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomListBox.SelectedItem != null;
            RefreshSelection();           
        }

        private void RefreshSelection() {
            Room selectedRoom = (Room)roomListBox.SelectedItem;
            foreach (var neighborControl in _NeighborControls) {
                neighborControl.Room = selectedRoom;
                neighborControl.RefreshNeighbors(_ViewModel.Rooms);
            }
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Delete this room? This cannot be undone.", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Game.World.Rooms.Remove((Room)roomListBox.SelectedItem);
                ViewModel.Rooms.Remove((Room)roomListBox.SelectedItem);
                
                roomListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
                if (ViewModel.Rooms.Count <= 0)
                {
                    deleteRoomButton.Enabled = false;
                }
            }
        }

        private void OpenGame_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.FileName = openFileDialog.FileName;
                IsGameLoaded = true;
                RefreshViewModel();
                RefreshSelection();
            }
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if(addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    bool sameNameFound = false;
                    if (ViewModel.Rooms.Count >= 0)
                    {
                        foreach(Room i in ViewModel.Rooms) {
                            if (i.Name.Equals(addRoomForm.RoomName, StringComparison.InvariantCultureIgnoreCase)) {
                                sameNameFound = true;
                                break;
                            }
                        }

                        if (sameNameFound == false){
                            Room room = new Room();
                            room.Name = addRoomForm.RoomName;
                            room.Description = "Enter Room Description";
                            ViewModel.Rooms.Add(room);
                            ViewModel.Game.World.Rooms.Add(room);
                        } else {
                            MessageBox.Show($"\"{addRoomForm.RoomName}\" already exists!");
                        }

                        deleteRoomButton.Enabled = true;
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveGame_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ViewModel.FileName))
            {
                SaveGameAs_Click(sender, e);
                return;
            }
            ViewModel.SaveWorld();
        }

        private void SaveGameAs_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.FileName = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void changeWorldSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (WorldSettingsForm worldSettingsForm = new WorldSettingsForm())
            {
                worldSettingsForm.WelcomeMessage = ViewModel.Game.WelcomeMessage;
                worldSettingsForm.ExitMessage = ViewModel.Game.ExitMessage;

                if (worldSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    ViewModel.Game.WelcomeMessage = worldSettingsForm.WelcomeMessage;
                    ViewModel.Game.ExitMessage = worldSettingsForm.ExitMessage;
                }
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            if(!ViewModel.IsModified)
            {
                IsGameLoaded = true;
                InitializeDefaultGame();
                RefreshViewModel();
            }
            else
            {
                if (MessageBox.Show("Create New World? Unsaved progress will be lost.", "New World", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InitializeDefaultGame();
                    ViewModel.FileName = null;
                    RefreshViewModel();

                    roomListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
                    if (ViewModel.Rooms.Count <= 0)
                    {
                        deleteRoomButton.Enabled = false;
                    }
                }
            }
        }

        private void InitializeDefaultGame()
        {
            Room defaultRoom = new Room();
            defaultRoom.Name = "Enter Room Name";
            defaultRoom.Description = "Enter Room Description";


            World newWorld = new World();
            newWorld.Rooms = new HashSet<Room>();
            newWorld.Rooms.Add(defaultRoom);

            ViewModel.Rooms = new BindingList<Room>();
            ViewModel.Rooms.Add(defaultRoom);

            ViewModel.Game = new Game(newWorld);
            ViewModel.Game.WelcomeMessage = "Welcome to Zork!";
            ViewModel.Game.ExitMessage = "Best of luck, traveler!";
            ViewModel.Game.World.StartingLocation = defaultRoom.Name;
        }

        private GameViewModel _ViewModel;
        private bool _IsWorldLoaded;
        private List<NeighborControl> _NeighborControls = new List<NeighborControl>();
    }
}
