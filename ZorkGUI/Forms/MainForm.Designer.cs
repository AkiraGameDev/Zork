namespace ZorkGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenGame = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGameAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWorldSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.neighborGroupBox = new System.Windows.Forms.GroupBox();
            this.southNeighborControl = new ZorkGUI.Controls.NeighborControl();
            this.eastNeighborControl = new ZorkGUI.Controls.NeighborControl();
            this.westNeighborControl = new ZorkGUI.Controls.NeighborControl();
            this.northNeighborControl = new ZorkGUI.Controls.NeighborControl();
            this.roomDescriptionBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.neighborGroupBox.SuspendLayout();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1129, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame,
            this.OpenGame,
            this.SaveGame,
            this.SaveGameAs,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // NewGame
            // 
            this.NewGame.Name = "NewGame";
            this.NewGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewGame.Size = new System.Drawing.Size(389, 40);
            this.NewGame.Text = "&New Game";
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // OpenGame
            // 
            this.OpenGame.Name = "OpenGame";
            this.OpenGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenGame.Size = new System.Drawing.Size(389, 40);
            this.OpenGame.Text = "&Open Game";
            this.OpenGame.Click += new System.EventHandler(this.OpenGame_Click);
            // 
            // SaveGame
            // 
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveGame.Size = new System.Drawing.Size(389, 40);
            this.SaveGame.Text = "&Save Game";
            this.SaveGame.Click += new System.EventHandler(this.SaveGame_Click);
            // 
            // SaveGameAs
            // 
            this.SaveGameAs.Name = "SaveGameAs";
            this.SaveGameAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveGameAs.Size = new System.Drawing.Size(389, 40);
            this.SaveGameAs.Text = "Save Game &As";
            this.SaveGameAs.Click += new System.EventHandler(this.SaveGameAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(386, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(389, 40);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeWorldSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(66, 34);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeWorldSettingsToolStripMenuItem
            // 
            this.changeWorldSettingsToolStripMenuItem.Name = "changeWorldSettingsToolStripMenuItem";
            this.changeWorldSettingsToolStripMenuItem.Size = new System.Drawing.Size(343, 40);
            this.changeWorldSettingsToolStripMenuItem.Text = "Change World Settings";
            this.changeWorldSettingsToolStripMenuItem.Click += new System.EventHandler(this.changeWorldSettingsToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(6, 32);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.roomListBox);
            this.splitContainer1.Panel1.Controls.Add(this.deleteRoomButton);
            this.splitContainer1.Panel1.Controls.Add(this.addRoomButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.neighborGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.roomDescriptionBox);
            this.splitContainer1.Panel2.Controls.Add(this.roomNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1117, 849);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 2;
            // 
            // roomListBox
            // 
            this.roomListBox.DataSource = this.roomsBindingSource;
            this.roomListBox.DisplayMember = "Name";
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.ItemHeight = 29;
            this.roomListBox.Location = new System.Drawing.Point(6, 46);
            this.roomListBox.Margin = new System.Windows.Forms.Padding(6);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(360, 729);
            this.roomListBox.TabIndex = 3;
            this.roomListBox.ValueMember = "Description";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(ZorkGUI.ViewModels.GameViewModel);
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(227, 798);
            this.deleteRoomButton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(141, 42);
            this.deleteRoomButton.TabIndex = 2;
            this.deleteRoomButton.Text = "&Delete...";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(6, 798);
            this.addRoomButton.Margin = new System.Windows.Forms.Padding(6);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(141, 42);
            this.addRoomButton.TabIndex = 2;
            this.addRoomButton.Text = "&Add...";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rooms";
            // 
            // neighborGroupBox
            // 
            this.neighborGroupBox.Controls.Add(this.southNeighborControl);
            this.neighborGroupBox.Controls.Add(this.eastNeighborControl);
            this.neighborGroupBox.Controls.Add(this.westNeighborControl);
            this.neighborGroupBox.Controls.Add(this.northNeighborControl);
            this.neighborGroupBox.Location = new System.Drawing.Point(11, 338);
            this.neighborGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.neighborGroupBox.Name = "neighborGroupBox";
            this.neighborGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.neighborGroupBox.Size = new System.Drawing.Size(693, 502);
            this.neighborGroupBox.TabIndex = 4;
            this.neighborGroupBox.TabStop = false;
            this.neighborGroupBox.Text = "Neighbors";
            // 
            // southNeighborControl
            // 
            this.southNeighborControl.Direction = Zork.Directions.South;
            this.southNeighborControl.Location = new System.Drawing.Point(205, 361);
            this.southNeighborControl.Margin = new System.Windows.Forms.Padding(7);
            this.southNeighborControl.Name = "southNeighborControl";
            this.southNeighborControl.Neighbor = null;
            this.southNeighborControl.Room = null;
            this.southNeighborControl.Size = new System.Drawing.Size(323, 97);
            this.southNeighborControl.TabIndex = 3;
            this.southNeighborControl.ViewModel = null;
            // 
            // eastNeighborControl
            // 
            this.eastNeighborControl.Direction = Zork.Directions.East;
            this.eastNeighborControl.Location = new System.Drawing.Point(370, 210);
            this.eastNeighborControl.Margin = new System.Windows.Forms.Padding(7);
            this.eastNeighborControl.Name = "eastNeighborControl";
            this.eastNeighborControl.Neighbor = null;
            this.eastNeighborControl.Room = null;
            this.eastNeighborControl.Size = new System.Drawing.Size(323, 102);
            this.eastNeighborControl.TabIndex = 2;
            this.eastNeighborControl.ViewModel = null;
            // 
            // westNeighborControl
            // 
            this.westNeighborControl.Direction = Zork.Directions.West;
            this.westNeighborControl.Location = new System.Drawing.Point(13, 210);
            this.westNeighborControl.Margin = new System.Windows.Forms.Padding(7);
            this.westNeighborControl.Name = "westNeighborControl";
            this.westNeighborControl.Neighbor = null;
            this.westNeighborControl.Room = null;
            this.westNeighborControl.Size = new System.Drawing.Size(323, 102);
            this.westNeighborControl.TabIndex = 1;
            this.westNeighborControl.ViewModel = null;
            // 
            // northNeighborControl
            // 
            this.northNeighborControl.Direction = Zork.Directions.North;
            this.northNeighborControl.Location = new System.Drawing.Point(192, 39);
            this.northNeighborControl.Margin = new System.Windows.Forms.Padding(7);
            this.northNeighborControl.Name = "northNeighborControl";
            this.northNeighborControl.Neighbor = null;
            this.northNeighborControl.Room = null;
            this.northNeighborControl.Size = new System.Drawing.Size(336, 103);
            this.northNeighborControl.TabIndex = 0;
            this.northNeighborControl.ViewModel = null;
            // 
            // roomDescriptionBox
            // 
            this.roomDescriptionBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomDescriptionBox.Location = new System.Drawing.Point(11, 127);
            this.roomDescriptionBox.Margin = new System.Windows.Forms.Padding(6);
            this.roomDescriptionBox.Multiline = true;
            this.roomDescriptionBox.Name = "roomDescriptionBox";
            this.roomDescriptionBox.Size = new System.Drawing.Size(701, 194);
            this.roomDescriptionBox.TabIndex = 3;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomNameTextBox.Location = new System.Drawing.Point(11, 46);
            this.roomNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(701, 33);
            this.roomNameTextBox.TabIndex = 2;
            this.roomNameTextBox.TextChanged += new System.EventHandler(this.roomNameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Name:";
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.AutoSize = true;
            this.MainGroupBox.Controls.Add(this.label3);
            this.MainGroupBox.Controls.Add(this.splitContainer1);
            this.MainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainGroupBox.Location = new System.Drawing.Point(0, 42);
            this.MainGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.MainGroupBox.Size = new System.Drawing.Size(1129, 887);
            this.MainGroupBox.TabIndex = 5;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "World Editor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "FileName", true));
            this.label3.Location = new System.Drawing.Point(160, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "(No World Currently Loaded)";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World Files (*.json)|.json";
            this.saveFileDialog.Title = "Save World File";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 929);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.neighborGroupBox.ResumeLayout(false);
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenGame;
        private System.Windows.Forms.ToolStripMenuItem SaveGame;
        private System.Windows.Forms.ToolStripMenuItem SaveGameAs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWorldSettingsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.ToolStripMenuItem NewGame;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.TextBox roomDescriptionBox;
        private System.Windows.Forms.GroupBox neighborGroupBox;
        private Controls.NeighborControl southNeighborControl;
        private Controls.NeighborControl eastNeighborControl;
        private Controls.NeighborControl westNeighborControl;
        private Controls.NeighborControl northNeighborControl;
    }
}

