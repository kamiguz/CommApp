namespace SopraSteriastaz
{
    partial class UserCreationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userCreationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(53, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(195, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(53, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(195, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // userCreationButton
            // 
            this.userCreationButton.Location = new System.Drawing.Point(89, 60);
            this.userCreationButton.Name = "userCreationButton";
            this.userCreationButton.Size = new System.Drawing.Size(87, 40);
            this.userCreationButton.TabIndex = 4;
            this.userCreationButton.Text = "Create User";
            this.userCreationButton.UseVisualStyleBackColor = true;
            this.userCreationButton.Click += new System.EventHandler(this.userCreationButton_Click);
            // 
            // UserCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 112);
            this.Controls.Add(this.userCreationButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserCreationForm";
            this.Text = "UserCreationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button userCreationButton;
    }
}