using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zork;
using ZorkGUI.ViewModels;

namespace ZorkGUI.Forms
{
    public partial class WorldSettingsForm : Form
    {
        public string WelcomeMessage
        {
            get => welcomeMessageTextBox.Text;
            set => welcomeMessageTextBox.Text = value;
        }
        public string ExitMessage
        {
            get => exitMessageTextBox.Text;
            set => exitMessageTextBox.Text = value;
        }

        public string StartingLocation { get; set; }

        public List<Room> Rooms { get; set; }

        public bool isInitialLoad;

        public WorldSettingsForm()
        {
            InitializeComponent();
            isInitialLoad = true;
        }

        public void RefreshStartingRoomList()
        {
            startingRoomComboBox.DataSource = Rooms;

            foreach (Room room in Rooms)
            {
                if (room.Name == StartingLocation)
                {
                    startingRoomComboBox.SelectedItem = room;
                }
            }
        }

        private void welcomeMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(WelcomeMessage);
        }

        private void exitMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(ExitMessage);
        }

        private void startingRoomComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(!isInitialLoad)
            {
                StartingLocation = startingRoomComboBox.Text;
            }
            else
            {
                isInitialLoad = false;
            }   
        }
    }
}
