namespace SopraSteriastaz
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
            this.createUserButton = new System.Windows.Forms.Button();
            this.newSkillTextBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.addSkillButton = new System.Windows.Forms.Button();
            this.retrieveUserInfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loggedUserTextBox = new System.Windows.Forms.TextBox();
            this.getUserDataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateUserDetailsButton = new System.Windows.Forms.Button();
            this.saveSpecSkillsButton = new System.Windows.Forms.Button();
            this.sendUserDescButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.getAllSkillsButton = new System.Windows.Forms.Button();
            this.skillsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userIDchooser = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userIDchooser)).BeginInit();
            this.SuspendLayout();
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(12, 12);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(94, 24);
            this.createUserButton.TabIndex = 0;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // newSkillTextBox
            // 
            this.newSkillTextBox.Location = new System.Drawing.Point(87, 69);
            this.newSkillTextBox.Name = "newSkillTextBox";
            this.newSkillTextBox.Size = new System.Drawing.Size(100, 20);
            this.newSkillTextBox.TabIndex = 1;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(112, 11);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(84, 24);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // addSkillButton
            // 
            this.addSkillButton.Location = new System.Drawing.Point(193, 67);
            this.addSkillButton.Name = "addSkillButton";
            this.addSkillButton.Size = new System.Drawing.Size(56, 22);
            this.addSkillButton.TabIndex = 5;
            this.addSkillButton.Text = "Add skill";
            this.addSkillButton.UseVisualStyleBackColor = true;
            this.addSkillButton.Click += new System.EventHandler(this.addSkillButton_Click);
            // 
            // retrieveUserInfoButton
            // 
            this.retrieveUserInfoButton.Location = new System.Drawing.Point(330, 31);
            this.retrieveUserInfoButton.Name = "retrieveUserInfoButton";
            this.retrieveUserInfoButton.Size = new System.Drawing.Size(71, 38);
            this.retrieveUserInfoButton.TabIndex = 6;
            this.retrieveUserInfoButton.Text = "Retrieve User Profile Information";
            this.retrieveUserInfoButton.UseVisualStyleBackColor = true;
            this.retrieveUserInfoButton.Click += new System.EventHandler(this.retrieveUserInfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Logged user:";
            // 
            // loggedUserTextBox
            // 
            this.loggedUserTextBox.Location = new System.Drawing.Point(87, 41);
            this.loggedUserTextBox.Name = "loggedUserTextBox";
            this.loggedUserTextBox.ReadOnly = true;
            this.loggedUserTextBox.Size = new System.Drawing.Size(100, 20);
            this.loggedUserTextBox.TabIndex = 8;
            // 
            // getUserDataButton
            // 
            this.getUserDataButton.Location = new System.Drawing.Point(407, 30);
            this.getUserDataButton.Name = "getUserDataButton";
            this.getUserDataButton.Size = new System.Drawing.Size(65, 38);
            this.getUserDataButton.TabIndex = 9;
            this.getUserDataButton.Text = "Get User Data";
            this.getUserDataButton.UseVisualStyleBackColor = true;
            this.getUserDataButton.Click += new System.EventHandler(this.getUserDataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "New skill:";
            // 
            // updateUserDetailsButton
            // 
            this.updateUserDetailsButton.Location = new System.Drawing.Point(12, 114);
            this.updateUserDetailsButton.Name = "updateUserDetailsButton";
            this.updateUserDetailsButton.Size = new System.Drawing.Size(86, 43);
            this.updateUserDetailsButton.TabIndex = 11;
            this.updateUserDetailsButton.Text = "Update User Details";
            this.updateUserDetailsButton.UseVisualStyleBackColor = true;
            this.updateUserDetailsButton.Click += new System.EventHandler(this.updateUserDetailsButton_Click);
            // 
            // saveSpecSkillsButton
            // 
            this.saveSpecSkillsButton.Location = new System.Drawing.Point(107, 114);
            this.saveSpecSkillsButton.Name = "saveSpecSkillsButton";
            this.saveSpecSkillsButton.Size = new System.Drawing.Size(89, 42);
            this.saveSpecSkillsButton.TabIndex = 12;
            this.saveSpecSkillsButton.Text = "Save Specified Skills";
            this.saveSpecSkillsButton.UseVisualStyleBackColor = true;
            this.saveSpecSkillsButton.Click += new System.EventHandler(this.saveSpecSkillsButton_Click);
            // 
            // sendUserDescButton
            // 
            this.sendUserDescButton.Location = new System.Drawing.Point(255, 30);
            this.sendUserDescButton.Name = "sendUserDescButton";
            this.sendUserDescButton.Size = new System.Drawing.Size(69, 40);
            this.sendUserDescButton.TabIndex = 13;
            this.sendUserDescButton.Text = "Get User Description";
            this.sendUserDescButton.UseVisualStyleBackColor = true;
            this.sendUserDescButton.Click += new System.EventHandler(this.sendUserDescButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "User Description:";
            // 
            // userDescriptionTextBox
            // 
            this.userDescriptionTextBox.Location = new System.Drawing.Point(283, 100);
            this.userDescriptionTextBox.Multiline = true;
            this.userDescriptionTextBox.Name = "userDescriptionTextBox";
            this.userDescriptionTextBox.ReadOnly = true;
            this.userDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.userDescriptionTextBox.Size = new System.Drawing.Size(181, 139);
            this.userDescriptionTextBox.TabIndex = 15;
            // 
            // getAllSkillsButton
            // 
            this.getAllSkillsButton.Location = new System.Drawing.Point(12, 190);
            this.getAllSkillsButton.Name = "getAllSkillsButton";
            this.getAllSkillsButton.Size = new System.Drawing.Size(75, 49);
            this.getAllSkillsButton.TabIndex = 16;
            this.getAllSkillsButton.Text = "Get All Skills";
            this.getAllSkillsButton.UseVisualStyleBackColor = true;
            this.getAllSkillsButton.Click += new System.EventHandler(this.getAllSkillsButton_Click);
            // 
            // skillsTextBox
            // 
            this.skillsTextBox.Location = new System.Drawing.Point(93, 163);
            this.skillsTextBox.Multiline = true;
            this.skillsTextBox.Name = "skillsTextBox";
            this.skillsTextBox.ReadOnly = true;
            this.skillsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.skillsTextBox.Size = new System.Drawing.Size(181, 76);
            this.skillsTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Skills:";
            // 
            // userIDchooser
            // 
            this.userIDchooser.Location = new System.Drawing.Point(382, 5);
            this.userIDchooser.Name = "userIDchooser";
            this.userIDchooser.Size = new System.Drawing.Size(42, 20);
            this.userIDchooser.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID of wanted user:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 245);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userIDchooser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.skillsTextBox);
            this.Controls.Add(this.getAllSkillsButton);
            this.Controls.Add(this.userDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sendUserDescButton);
            this.Controls.Add(this.saveSpecSkillsButton);
            this.Controls.Add(this.updateUserDetailsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getUserDataButton);
            this.Controls.Add(this.loggedUserTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retrieveUserInfoButton);
            this.Controls.Add(this.addSkillButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.newSkillTextBox);
            this.Controls.Add(this.createUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SopraSteria Internship App";
            ((System.ComponentModel.ISupportInitialize)(this.userIDchooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.TextBox newSkillTextBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button addSkillButton;
        private System.Windows.Forms.Button retrieveUserInfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loggedUserTextBox;
        private System.Windows.Forms.Button getUserDataButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateUserDetailsButton;
        private System.Windows.Forms.Button saveSpecSkillsButton;
        private System.Windows.Forms.Button sendUserDescButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userDescriptionTextBox;
        private System.Windows.Forms.Button getAllSkillsButton;
        private System.Windows.Forms.TextBox skillsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown userIDchooser;
        private System.Windows.Forms.Label label5;
    }
}

