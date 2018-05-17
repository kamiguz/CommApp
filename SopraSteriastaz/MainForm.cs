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
    public partial class MainForm : Form
    {
        private UserController userController;
        private SkillController skillController;
        

        public MainForm()
        {
            InitializeComponent();
            userController = new UserController();
            skillController = new SkillController();

        }

        //users

        public void setLoggedUserName(string text)
        {
            loggedUserTextBox.Text = text;
        }

        private void createUserButton_Click(object sender, EventArgs e) // create account
        {
            UserCreationForm creationForm = new UserCreationForm(userController);

            creationForm.Show();

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            UserLogInForm loginForm = new UserLogInForm(userController, skillController);

            loginForm.Show(this);
            
        }

        private void retrieveUserInfoButton_Click(object sender, EventArgs e)
        {
            DetailsFullDTO dfDTO = userController.getByUserId(userIDchooser.Text);

            if (dfDTO == null)
            {
                MessageBox.Show("Could not retrieve data.");
                return;
            }
            string userDesc = "";

            PropertyInfo[] fields = typeof(DetailsFullDTO).GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                userDesc += field.Name + " : " + field.GetValue(dfDTO) + Environment.NewLine;
            }
            userDescriptionTextBox.Text = userDesc;
        }

        private void getUserDataButton_Click(object sender, EventArgs e)
        {           
          
            UserCreatedDTO ucDTO = userController.retrieveUser(userIDchooser.Text);

            if (ucDTO == null)
            {
                MessageBox.Show("Could not retrieve data.");
                return;
            }
            string userDesc = "";

            PropertyInfo[] fields = typeof(UserCreatedDTO).GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                userDesc += field.Name + " : " + field.GetValue(ucDTO) + Environment.NewLine;
            }
            userDescriptionTextBox.Text = userDesc;

        }

        private void updateUserDetailsButton_Click(object sender, EventArgs e)
        {
            UpdateDetailsForm updateDetailsForm = new UpdateDetailsForm(userController);

            updateDetailsForm.Show();
        }

        private void saveSpecSkillsButton_Click(object sender, EventArgs e)
        {
            SaveSpecifiedSkillsForm saveSpecifiedSkillsForm = new SaveSpecifiedSkillsForm(userController);
            saveSpecifiedSkillsForm.Show();
        }

        private void sendUserDescButton_Click(object sender, EventArgs e)
        {
 
            DetailsDTO dDTO = userController.sendUserDescription(userIDchooser.Text);
            if (dDTO == null)
            {
                MessageBox.Show("Could not retrieve data.");
                return;
            }
            string userDesc = "";

            PropertyInfo[] fields = typeof(DetailsDTO).GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                userDesc += field.Name + " : " + field.GetValue(dDTO) + Environment.NewLine;
            }
            userDescriptionTextBox.Text = userDesc;
            
        }

        //skills

        private void addSkillButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(skillController.addNewSkill(newSkillTextBox.Text));
        }

        private void getAllSkillsButton_Click(object sender, EventArgs e)
        {            
         
            SkillDTO[] sDTO = skillController.getAllSkills();
            if (sDTO == null)
            {
                MessageBox.Show("Could not retrieve data.");
                return;
            }

            string skillDesc = "";
            PropertyInfo[] fields = typeof(SkillDTO).GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach(SkillDTO val in sDTO)
            {
                foreach (var field in fields)
                {
                    skillDesc += field.Name + " : " + field.GetValue(sDTO) + Environment.NewLine;
                }
            }
           
            skillsTextBox.Text = skillDesc;
        }
    }
}
