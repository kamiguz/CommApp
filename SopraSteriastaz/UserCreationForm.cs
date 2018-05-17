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
    public partial class UserCreationForm : Form
    {
        private UserController userController;
        public UserCreationForm(UserController userC)
        {
            InitializeComponent();
            userController = userC;
        }

        private void userCreationButton_Click(object sender, EventArgs e)
        {
           MessageBox.Show(userController.createUser(emailTextBox.Text, nameTextBox.Text));
           this.Close(); 
        }
    }
}
