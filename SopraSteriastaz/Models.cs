using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SopraSteriastaz
{
    public class UserNewDTO
    {
        public string email { get; set; }
        public string name { get; set; }

        public UserNewDTO(string Email, string Name)
        {
            email = Email;
            name = Name;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class UserFullDTO
    {
        private string email { get; set; }
        private string id { get; set; }
        private string name { get; set; }
        private string password { get; set; }
        private SkillDTO skills { get; set; }

        public UserFullDTO(string Email, string Id, string Name, string Password, SkillDTO Skills)
        {
            email = Email;
            id = Id;
            name = Name;
            password = Password;
            skills = Skills;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class UserCreatedDTO
    {
        private string email { get; set; }
        private string id { get; set; }
        private string name { get; set; }
        private string password { get; set; }

        public UserCreatedDTO(string Email, string ID, string Name, string Password)
        {
            email = Email;
            id = ID;
            name = Name;
            password = Password;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class SkillNewDTO
    {
        private string skillName { get; set; }

        public SkillNewDTO(string Name)
        {
            skillName = Name;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
    public class SkillDTO
    {
        private int id { get; set; }
        private string skillName { get; set; }

        public SkillDTO(int ID, string Name)
        {
            id = ID;
            skillName = Name;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class SaveSkillsRequest
    {
       private int [] skillsIds { get; set; }
       private string userId { get; set; }

    public SaveSkillsRequest(int [] IDs, string uID)
        {
            skillsIds = IDs;
            userId = uID;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class DetailsNewDTO
    {
        private string fieldOfStudy { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string university { get; set; }
        private int yearOfStudy { get; set; }

        public DetailsNewDTO(string foStudy, string fName, string lName, string uni, int yoStudy)
        {
            fieldOfStudy = foStudy;
            firstName = fName;
            lastName = lName;
            university = uni;
            yearOfStudy = yoStudy;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class DetailsFullDTO
    {
        private string fieldOfStudy { get; set; }
        private string firstName { get; set; }
        private string id { get; set; }
        private string lastName { get; set; }
        private string university { get; set; }
        private UserFullDTO user { get; set; }
        private int yearOfStudy { get; set; }

        public DetailsFullDTO(string foStudy, string fName, string ID, string lName, string uni, UserFullDTO User, int yoStudy)
        {
            fieldOfStudy = foStudy;
            firstName = fName;
            id = ID;
            lastName = lName;
            university = uni;
            user = User;
            yearOfStudy = yoStudy;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class DetailsDTO
    {
        private string fieldOfStudy { get; set; }
        private string firstName { get; set; }
        private string id { get; set; }
        private string lastName { get; set; }
        private string university { get; set; }
        private int yearOfStudy { get; set; }

        public DetailsDTO(string foStudy, string fName, string Id, string lName, string uni, int yoStudy)
        {
            fieldOfStudy = foStudy;
            firstName = fName;
            id = Id;
            lastName = lName;
            university = uni;
            yearOfStudy = yoStudy;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
