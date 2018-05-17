using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SopraSteriastaz
{
    public partial class SaveSpecifiedSkillsForm : Form
    {
        private UserController userController;
        public SaveSpecifiedSkillsForm(UserController skillControl)
        {
            InitializeComponent();
            userController = skillControl;
        }

        private void saveSpecifiedSkillsButton_Click(object sender, EventArgs e)
        {
            string [] sArr = skillsIdTextBox.Text.Split(',');
            int[] skillIds = sArr.Select(int.Parse).ToArray();
            UserFullDTO ufDTO =  userController.saveSkills(skillIds, userIdSelect.Text);

            if(ufDTO == null)
            {
                MessageBox.Show("Could not save specified skills.");
            }
            else
            {
                string userDesc = "";

                //NOTE: Due to instruction server not working properly author is not sure whether returned object is DetailsFullDTO.
                PropertyInfo[] fields = typeof(DetailsFullDTO).GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (var field in fields)
                {
                    userDesc += field.Name + " : " + field.GetValue(ufDTO) + Environment.NewLine;
                }
                MessageBox.Show(userDesc);
            }

            this.Close();
        }
    }
}
