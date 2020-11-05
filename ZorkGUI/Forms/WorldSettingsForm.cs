using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public WorldSettingsForm()
        {
            InitializeComponent();
        }

        private void welcomeMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(WelcomeMessage);
        }

        private void exitMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(ExitMessage);
        }
    }
}
