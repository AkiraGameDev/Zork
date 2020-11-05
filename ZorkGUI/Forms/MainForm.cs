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
            }
        }
        private bool mIsWorldLoaded;

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomListBox.SelectedItem != null;
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Delete this player?", "assembly title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Game.World.Rooms.Remove((Room)roomListBox.SelectedItem);
                ViewModel.Rooms.Remove((Room)roomListBox.SelectedItem);
                
                roomListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
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
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveGame_Click(object sender, EventArgs e)
        {
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
    }
}
