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
            IsWorldLoaded = false;
        }

        private GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if(mViewModel != value)
                {
                    mViewModel = value;
                    gameViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }
        private GameViewModel mViewModel;

        private bool IsWorldLoaded
        {
            get => IsWorldLoaded;
            set
            {
                mIsWorldLoaded = value;
                MainGroupBox.Enabled = mIsWorldLoaded;
                SaveGame.Enabled = mIsWorldLoaded;
                SaveGameAs.Enabled = mIsWorldLoaded;
            }
        }
        private bool mIsWorldLoaded;

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomListBox.SelectedItem != null;
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
                IsWorldLoaded = true;
            }
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if(addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room();
                    room.Name = addRoomForm.RoomName;
                    ViewModel.Rooms.Add(room);
                    ViewModel.Game.World.Rooms.Add(room);

                    if (ViewModel.Rooms.Count >= 0)
                    {
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
            IsWorldLoaded = true;

            World newWorld = new World();
            newWorld.Rooms = new HashSet<Room>();

            Room defaultRoom = new Room();
            defaultRoom.Name = "Enter Room Name";
            defaultRoom.Description = "Enter Room Description";
            newWorld.Rooms.Add(defaultRoom);

            ViewModel.Game = new Game(newWorld);
            ViewModel.Game.WelcomeMessage = "Welcome to Zork!";
            ViewModel.Game.ExitMessage = "Best of luck, traveler!";
        }

        private void roomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = roomListBox.SelectedIndex;

            if(roomListBox.SelectedIndex >= 0)
            {
                roomListBox.DataSource = null;
                roomListBox.DataSource = roomsBindingSource;
            }
            
        }
    }
}
