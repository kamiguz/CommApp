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
    public partial class UpdateDetailsForm : Form
    {
        private UserController userController;
        public UpdateDetailsForm(UserController userC)
        {
            InitializeComponent();
            userController = userC;
        }

        private void updateDataButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userController.updateDetails(fieldOfStudyTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text,
                uniTextBox.Text, (int)yoStudyValueBox.Value));

            this.Close();
        }
    }
}
