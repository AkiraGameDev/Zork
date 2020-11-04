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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWorldSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.RoomDescriptionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.NorthWestDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.NorthRoomDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.NorthEastRoomDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.EastRoomDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.SouthEastRoomDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.SouthRoomDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.SouthWestRoomDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.WestRoomRoomDropdown = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.UpRoomDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.DownRoomDropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame,
            this.OpenGame,
            this.SaveGame,
            this.SaveGameAs});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click_1);
            // 
            // NewGame
            // 
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(148, 22);
            this.NewGame.Text = "New Game";
            this.NewGame.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // OpenGame
            // 
            this.OpenGame.Name = "OpenGame";
            this.OpenGame.Size = new System.Drawing.Size(148, 22);
            this.OpenGame.Text = "Open Game";
            // 
            // SaveGame
            // 
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(148, 22);
            this.SaveGame.Text = "Save Game";
            // 
            // SaveGameAs
            // 
            this.SaveGameAs.Name = "SaveGameAs";
            this.SaveGameAs.Size = new System.Drawing.Size(148, 22);
            this.SaveGameAs.Text = "Save Game As";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeWorldSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeWorldSettingsToolStripMenuItem
            // 
            this.changeWorldSettingsToolStripMenuItem.Name = "changeWorldSettingsToolStripMenuItem";
            this.changeWorldSettingsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.changeWorldSettingsToolStripMenuItem.Text = "Change World Settings";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 403);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "World Editor (Current World Name)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 18);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeleteRoomButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddRoomButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.RoomList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(731, 382);
            this.splitContainer1.SplitterDistance = 141;
            this.splitContainer1.TabIndex = 2;
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Location = new System.Drawing.Point(79, 348);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(60, 23);
            this.DeleteRoomButton.TabIndex = 2;
            this.DeleteRoomButton.Text = "Delete";
            this.DeleteRoomButton.UseVisualStyleBackColor = true;
            this.DeleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(6, 348);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(56, 23);
            this.AddRoomButton.TabIndex = 2;
            this.AddRoomButton.Text = "Add Room";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rooms";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoomList
            // 
            this.RoomList.FormattingEnabled = true;
            this.RoomList.ItemHeight = 16;
            this.RoomList.Location = new System.Drawing.Point(3, 18);
            this.RoomList.Name = "RoomList";
            this.RoomList.Size = new System.Drawing.Size(136, 324);
            this.RoomList.TabIndex = 0;
            this.RoomList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.488064F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.51194F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(574, 377);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel16, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.60938F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.39063F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(568, 339);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.29181F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.70818F));
            this.tableLayoutPanel6.Controls.Add(this.RoomDescriptionBox, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(562, 66);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // RoomDescriptionBox
            // 
            this.RoomDescriptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoomDescriptionBox.Location = new System.Drawing.Point(161, 4);
            this.RoomDescriptionBox.Multiline = true;
            this.RoomDescriptionBox.Name = "RoomDescriptionBox";
            this.RoomDescriptionBox.Size = new System.Drawing.Size(398, 57);
            this.RoomDescriptionBox.TabIndex = 0;
            this.RoomDescriptionBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room Description";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.24409F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.75591F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel10, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel11, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel12, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel13, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel14, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel15, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.79518F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.20482F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(562, 214);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.NorthWestDropdown, 0, 1);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.64516F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.35484F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(172, 62);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "North West";
            // 
            // NorthWestDropdown
            // 
            this.NorthWestDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NorthWestDropdown.DisplayMember = "No Room Selected";
            this.NorthWestDropdown.FormattingEnabled = true;
            this.NorthWestDropdown.Items.AddRange(new object[] {
            "No Room Selected"});
            this.NorthWestDropdown.Location = new System.Drawing.Point(12, 29);
            this.NorthWestDropdown.Name = "NorthWestDropdown";
            this.NorthWestDropdown.Size = new System.Drawing.Size(148, 24);
            this.NorthWestDropdown.TabIndex = 9;
            this.NorthWestDropdown.Text = "No Room Selected";
            this.NorthWestDropdown.ValueMember = "No Room Selected";
            this.NorthWestDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.NorthRoomDropdown, 0, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(181, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.87097F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.12904F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(192, 62);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "North";
            // 
            // NorthRoomDropdown
            // 
            this.NorthRoomDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NorthRoomDropdown.DisplayMember = "No Room Selected";
            this.NorthRoomDropdown.FormattingEnabled = true;
            this.NorthRoomDropdown.Items.AddRange(new object[] {
            "No Room Selected"});
            this.NorthRoomDropdown.Location = new System.Drawing.Point(22, 30);
            this.NorthRoomDropdown.Name = "NorthRoomDropdown";
            this.NorthRoomDropdown.Size = new System.Drawing.Size(148, 24);
            this.NorthRoomDropdown.TabIndex = 9;
            this.NorthRoomDropdown.Text = "No Room Selected";
            this.NorthRoomDropdown.ValueMember = "No Room Selected";
            this.NorthRoomDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.NorthEastRoomDropdown, 0, 1);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(379, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.87097F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.12904F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(176, 62);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "North East";
            // 
            // NorthEastRoomDropdown
            // 
            this.NorthEastRoomDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NorthEastRoomDropdown.DisplayMember = "No Room Selected";
            this.NorthEastRoomDropdown.FormattingEnabled = true;
            this.NorthEastRoomDropdown.Items.AddRange(new object[] {
            "No Room Selected"});
            this.NorthEastRoomDropdown.Location = new System.Drawing.Point(14, 30);
            this.NorthEastRoomDropdown.Name = "NorthEastRoomDropdown";
            this.NorthEastRoomDropdown.Size = new System.Drawing.Size(148, 24);
            this.NorthEastRoomDropdown.TabIndex = 9;
            this.NorthEastRoomDropdown.Text = "No Room Selected";
            this.NorthEastRoomDropdown.ValueMember = "No Room Selected";
            this.NorthEastRoomDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.EastRoomDropdown, 0, 1);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(379, 71);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.78788F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.21212F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(176, 66);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "East";
            // 
            // EastRoomDropdown
            // 
            this.EastRoomDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EastRoomDropdown.DisplayMember = "No Room Selected";
            this.EastRoomDropdown.FormattingEnabled = true;
            this.EastRoomDropdown.Items.AddRange(new object[] {
            "No Room Selected"});
            this.EastRoomDropdown.Location = new System.Drawing.Point(14, 32);
            this.EastRoomDropdown.Name = "EastRoomDropdown";
            this.EastRoomDropdown.Size = new System.Drawing.Size(148, 24);
            this.EastRoomDropdown.TabIndex = 9;
            this.EastRoomDropdown.Text = "No Room Selected";
            this.EastRoomDropdown.ValueMember = "No Room Selected";
            this.EastRoomDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.SouthEastRoomDropdown, 0, 1);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(379, 143);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.47059F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.52941F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(176, 68);
            this.tableLayoutPanel12.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "South East";
            // 
            // SouthEastRoomDropdown
            // 
            this.SouthEastRoomDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SouthEastRoomDropdown.DisplayMember = "No Room Selected";
            this.SouthEastRoomDropdown.FormattingEnabled = true;
            this.SouthEastRoomDropdown.Items.AddRange(new object[] {
            "No Room Selected"});
            this.SouthEastRoomDropdown.Location = new System.Drawing.Point(14, 32);
            this.SouthEastRoomDropdown.Name = "SouthEastRoomDropdown";
            this.SouthEastRoomDropdown.Size = new System.Drawing.Size(148, 24);
            this.SouthEastRoomDropdown.TabIndex = 9;
            this.SouthEastRoomDropdown.Text = "No Room Selected";
            this.SouthEastRoomDropdown.ValueMember = "No Room Selected";
            this.SouthEastRoomDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.SouthRoomDropdown, 0, 1);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(181, 143);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.94118F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.05882F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(192, 68);
            this.tableLayoutPanel13.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "South";
            // 
            // SouthRoomDropdown
            // 
            this.SouthRoomDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SouthRoomDropdown.DisplayMember = "No Room Selected";
            this.SouthRoomDropdown.FormattingEnabled = true;
            this.SouthRoomDropdown.Items.AddRange(new object[] {
            "No Room Selected"});
            this.SouthRoomDropdown.Location = new System.Drawing.Point(22, 33);
            this.SouthRoomDropdown.Name = "SouthRoomDropdown";
            this.SouthRoomDropdown.Size = new System.Drawing.Size(148, 24);
            this.SouthRoomDropdown.TabIndex = 9;
            this.SouthRoomDropdown.Text = "No Room Selected";
            this.SouthRoomDropdown.ValueMember = "No Room Selected";
            this.SouthRoomDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.SouthWestRoomDropdown, 0, 1);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.47059F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.52941F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(172, 68);
            this.tableLayoutPanel14.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "South West";
            // 
            // SouthWestRoomDropdown
            // 
            this.SouthWestRoomDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SouthWestRoomDropdown.DisplayMember = "No Room Selected";
            this.SouthWestRoomDropdown.FormattingEnabled = true;
            this.SouthWestRoomDropdown.Items.AddRange(new object[] {
            "No Room Selected"});
            this.SouthWestRoomDropdown.Location = new System.Drawing.Point(12, 32);
            this.SouthWestRoomDropdown.Name = "SouthWestRoomDropdown";
            this.SouthWestRoomDropdown.Size = new System.Drawing.Size(148, 24);
            this.SouthWestRoomDropdown.TabIndex = 9;
            this.SouthWestRoomDropdown.Text = "No Room Selected";
            this.SouthWestRoomDropdown.ValueMember = "No Room Selected";
            this.SouthWestRoomDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.WestRoomRoomDropdown, 0, 1);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(172, 66);
            this.tableLayoutPanel15.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "West";
            // 
            // WestRoomRoomDropdown
            // 
            this.WestRoomRoomDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WestRoomRoomDropdown.DisplayMember = "No Room Selected";
            this.WestRoomRoomDropdown.FormattingEnabled = true;
            this.WestRoomRoomDropdown.Items.AddRange(new object[] {
            "No Room Selected"});
            this.WestRoomRoomDropdown.Location = new System.Drawing.Point(12, 31);
            this.WestRoomRoomDropdown.Name = "WestRoomRoomDropdown";
            this.WestRoomRoomDropdown.Size = new System.Drawing.Size(148, 24);
            this.WestRoomRoomDropdown.TabIndex = 9;
            this.WestRoomRoomDropdown.Text = "No Room Selected";
            this.WestRoomRoomDropdown.ValueMember = "No Room Selected";
            this.WestRoomRoomDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(210, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add/Remove Items In Room";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel17, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel18, 1, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 296);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.74026F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(562, 40);
            this.tableLayoutPanel16.TabIndex = 2;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel17.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.UpRoomDropdown, 1, 0);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(275, 34);
            this.tableLayoutPanel17.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "Up";
            // 
            // UpRoomDropdown
            // 
            this.UpRoomDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpRoomDropdown.DisplayMember = "No Room Selected";
            this.UpRoomDropdown.FormattingEnabled = true;
            this.UpRoomDropdown.Items.AddRange(new object[] {
            "No Room Selected"});
            this.UpRoomDropdown.Location = new System.Drawing.Point(96, 6);
            this.UpRoomDropdown.Name = "UpRoomDropdown";
            this.UpRoomDropdown.Size = new System.Drawing.Size(148, 24);
            this.UpRoomDropdown.TabIndex = 9;
            this.UpRoomDropdown.Text = "No Room Selected";
            this.UpRoomDropdown.ValueMember = "No Room Selected";
            this.UpRoomDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 2;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.54545F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.45454F));
            this.tableLayoutPanel18.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.DownRoomDropdown, 1, 0);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(284, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(275, 34);
            this.tableLayoutPanel18.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Down";
            // 
            // DownRoomDropdown
            // 
            this.DownRoomDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DownRoomDropdown.DisplayMember = "No Room Selected";
            this.DownRoomDropdown.FormattingEnabled = true;
            this.DownRoomDropdown.Items.AddRange(new object[] {
            "No Room Selected"});
            this.DownRoomDropdown.Location = new System.Drawing.Point(94, 6);
            this.DownRoomDropdown.Name = "DownRoomDropdown";
            this.DownRoomDropdown.Size = new System.Drawing.Size(148, 24);
            this.DownRoomDropdown.TabIndex = 9;
            this.DownRoomDropdown.Text = "No Room Selected";
            this.DownRoomDropdown.ValueMember = "No Room Selected";
            this.DownRoomDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.52113F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.47887F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(568, 26);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGame;
        private System.Windows.Forms.ToolStripMenuItem OpenGame;
        private System.Windows.Forms.ToolStripMenuItem SaveGame;
        private System.Windows.Forms.ToolStripMenuItem SaveGameAs;
        private System.Windows.Forms.ListBox RoomList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteRoomButton;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox RoomDescriptionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox NorthWestDropdown;
        private System.Windows.Forms.ComboBox NorthRoomDropdown;
        private System.Windows.Forms.ComboBox NorthEastRoomDropdown;
        private System.Windows.Forms.ComboBox EastRoomDropdown;
        private System.Windows.Forms.ComboBox SouthRoomDropdown;
        private System.Windows.Forms.ComboBox SouthWestRoomDropdown;
        private System.Windows.Forms.ComboBox WestRoomRoomDropdown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox SouthEastRoomDropdown;
        private System.Windows.Forms.ComboBox DownRoomDropdown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox UpRoomDropdown;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWorldSettingsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

