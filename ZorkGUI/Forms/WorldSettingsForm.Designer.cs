namespace ZorkGUI.Forms
{
    partial class WorldSettingsForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.exitMessageTextBox = new System.Windows.Forms.TextBox();
            this.exitMessageLabel = new System.Windows.Forms.Label();
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(321, 114);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(77, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(225, 114);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(77, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "&Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "Game.WelcomeMessage", true));
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(12, 30);
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(386, 20);
            this.welcomeMessageTextBox.TabIndex = 5;
            this.welcomeMessageTextBox.TextChanged += new System.EventHandler(this.welcomeMessageTextBox_TextChanged);
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(9, 10);
            this.welcomeMessageLabel.Margin = new System.Windows.Forms.Padding(5);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(101, 13);
            this.welcomeMessageLabel.TabIndex = 4;
            this.welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // exitMessageTextBox
            // 
            this.exitMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "Game.ExitMessage", true));
            this.exitMessageTextBox.Location = new System.Drawing.Point(12, 78);
            this.exitMessageTextBox.Name = "exitMessageTextBox";
            this.exitMessageTextBox.Size = new System.Drawing.Size(386, 20);
            this.exitMessageTextBox.TabIndex = 9;
            this.exitMessageTextBox.TextChanged += new System.EventHandler(this.exitMessageTextBox_TextChanged);
            // 
            // exitMessageLabel
            // 
            this.exitMessageLabel.AutoSize = true;
            this.exitMessageLabel.Location = new System.Drawing.Point(9, 58);
            this.exitMessageLabel.Margin = new System.Windows.Forms.Padding(5);
            this.exitMessageLabel.Name = "exitMessageLabel";
            this.exitMessageLabel.Size = new System.Drawing.Size(73, 13);
            this.exitMessageLabel.TabIndex = 8;
            this.exitMessageLabel.Text = "Exit Message:";
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(ZorkGUI.ViewModels.GameViewModel);
            // 
            // WorldSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 150);
            this.Controls.Add(this.exitMessageTextBox);
            this.Controls.Add(this.exitMessageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.welcomeMessageTextBox);
            this.Controls.Add(this.welcomeMessageLabel);
            this.Name = "WorldSettingsForm";
            this.Text = "WorldSettings";
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.TextBox exitMessageTextBox;
        private System.Windows.Forms.Label exitMessageLabel;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
    }
}