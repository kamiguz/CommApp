namespace SopraSteriastaz
{
    partial class UpdateDetailsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldOfStudyTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.uniTextBox = new System.Windows.Forms.TextBox();
            this.updateDataButton = new System.Windows.Forms.Button();
            this.yoStudyValueBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.yoStudyValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Field of Study";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "University:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year of Study:";
            // 
            // fieldOfStudyTextBox
            // 
            this.fieldOfStudyTextBox.Location = new System.Drawing.Point(89, 6);
            this.fieldOfStudyTextBox.Name = "fieldOfStudyTextBox";
            this.fieldOfStudyTextBox.Size = new System.Drawing.Size(183, 20);
            this.fieldOfStudyTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(89, 30);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(89, 54);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // uniTextBox
            // 
            this.uniTextBox.Location = new System.Drawing.Point(89, 80);
            this.uniTextBox.Name = "uniTextBox";
            this.uniTextBox.Size = new System.Drawing.Size(183, 20);
            this.uniTextBox.TabIndex = 8;
            // 
            // updateDataButton
            // 
            this.updateDataButton.Location = new System.Drawing.Point(89, 132);
            this.updateDataButton.Name = "updateDataButton";
            this.updateDataButton.Size = new System.Drawing.Size(106, 35);
            this.updateDataButton.TabIndex = 10;
            this.updateDataButton.Text = "Update Data";
            this.updateDataButton.UseVisualStyleBackColor = true;
            this.updateDataButton.Click += new System.EventHandler(this.updateDataButton_Click);
            // 
            // yoStudyValueBox
            // 
            this.yoStudyValueBox.Location = new System.Drawing.Point(89, 106);
            this.yoStudyValueBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.yoStudyValueBox.Name = "yoStudyValueBox";
            this.yoStudyValueBox.Size = new System.Drawing.Size(47, 20);
            this.yoStudyValueBox.TabIndex = 11;
            // 
            // UpdateDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 170);
            this.Controls.Add(this.yoStudyValueBox);
            this.Controls.Add(this.updateDataButton);
            this.Controls.Add(this.uniTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.fieldOfStudyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateDetailsForm";
            this.Text = "UpdateDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.yoStudyValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fieldOfStudyTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox uniTextBox;
        private System.Windows.Forms.Button updateDataButton;
        private System.Windows.Forms.NumericUpDown yoStudyValueBox;
    }
}