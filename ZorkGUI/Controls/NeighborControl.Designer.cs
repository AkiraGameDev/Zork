namespace ZorkGUI.Controls
{
    partial class NeighborControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.neighborComboBox = new System.Windows.Forms.ComboBox();
            this.neighborTextBox = new System.Windows.Forms.TextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // neighborComboBox
            // 
            this.neighborComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neighborComboBox.DataSource = this.roomsBindingSource;
            this.neighborComboBox.DisplayMember = "Name";
            this.neighborComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.neighborComboBox.FormattingEnabled = true;
            this.neighborComboBox.Location = new System.Drawing.Point(10, 39);
            this.neighborComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.neighborComboBox.MaxDropDownItems = 9;
            this.neighborComboBox.Name = "neighborComboBox";
            this.neighborComboBox.Size = new System.Drawing.Size(96, 21);
            this.neighborComboBox.TabIndex = 1;
            this.neighborComboBox.ValueMember = "Description";
            // 
            // neighborTextBox
            // 
            this.neighborTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neighborTextBox.Location = new System.Drawing.Point(10, 11);
            this.neighborTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.neighborTextBox.Name = "neighborTextBox";
            this.neighborTextBox.ReadOnly = true;
            this.neighborTextBox.Size = new System.Drawing.Size(96, 20);
            this.neighborTextBox.TabIndex = 0;
            this.neighborTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataSource = typeof(Zork.Room);
            // 
            // NeighborControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighborComboBox);
            this.Controls.Add(this.neighborTextBox);
            this.Name = "NeighborControl";
            this.Size = new System.Drawing.Size(171, 75);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox neighborComboBox;
        private System.Windows.Forms.TextBox neighborTextBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
    }
}
