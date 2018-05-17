﻿namespace SopraSteriastaz
{
    partial class SaveSpecifiedSkillsForm
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
            this.skillsIdTextBox = new System.Windows.Forms.TextBox();
            this.saveSpecifiedSkillsButton = new System.Windows.Forms.Button();
            this.userIdSelect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userIdSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDs of skills to save (seperate by comma and space):";
            // 
            // skillsIdTextBox
            // 
            this.skillsIdTextBox.Location = new System.Drawing.Point(12, 25);
            this.skillsIdTextBox.Name = "skillsIdTextBox";
            this.skillsIdTextBox.Size = new System.Drawing.Size(260, 20);
            this.skillsIdTextBox.TabIndex = 1;
            // 
            // saveSpecifiedSkillsButton
            // 
            this.saveSpecifiedSkillsButton.Location = new System.Drawing.Point(150, 53);
            this.saveSpecifiedSkillsButton.Name = "saveSpecifiedSkillsButton";
            this.saveSpecifiedSkillsButton.Size = new System.Drawing.Size(122, 33);
            this.saveSpecifiedSkillsButton.TabIndex = 2;
            this.saveSpecifiedSkillsButton.Text = "Save specified skills";
            this.saveSpecifiedSkillsButton.UseVisualStyleBackColor = true;
            this.saveSpecifiedSkillsButton.Click += new System.EventHandler(this.saveSpecifiedSkillsButton_Click);
            // 
            // userIdSelect
            // 
            this.userIdSelect.Location = new System.Drawing.Point(87, 55);
            this.userIdSelect.Name = "userIdSelect";
            this.userIdSelect.Size = new System.Drawing.Size(42, 20);
            this.userIdSelect.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User ID";
            // 
            // SaveSpecifiedSkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 87);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userIdSelect);
            this.Controls.Add(this.saveSpecifiedSkillsButton);
            this.Controls.Add(this.skillsIdTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SaveSpecifiedSkillsForm";
            this.Text = "SaveSpecifiedSkillsForm";
            ((System.ComponentModel.ISupportInitialize)(this.userIdSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox skillsIdTextBox;
        private System.Windows.Forms.Button saveSpecifiedSkillsButton;
        private System.Windows.Forms.NumericUpDown userIdSelect;
        private System.Windows.Forms.Label label2;
    }
}