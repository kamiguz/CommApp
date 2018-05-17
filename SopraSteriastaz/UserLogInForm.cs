using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SopraSteriastaz
{
    public partial class UserLogInForm : Form
    {
        private UserController userController;
        private SkillController skillController;

        public UserLogInForm(UserController userC, SkillController skillC)
        {
            InitializeComponent();
            userController = userC;
            skillController = skillC;
          
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            userController.username = nameTextBox.Text;
            userController.password = passwordTextBox.Text;
            skillController.username = nameTextBox.Text;
            skillController.password = passwordTextBox.Text;

            MainForm parent = (MainForm)Owner;
            parent.setLoggedUserName(nameTextBox.Text);

            this.Close();

        }
    }
}
