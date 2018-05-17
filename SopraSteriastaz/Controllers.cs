using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple.Data;
using RestSharp;
using System.Net;
using RestSharp.Authenticators;
using RestSharp.Deserializers;

namespace SopraSteriastaz
{
 
    public class UserController
    {
        private RestClient client = null;
        private RestRequest request = null;
        private IRestResponse response = null;

        public string username { get;  set; }
        public string password { get;  set; }

        public UserController()
        { 

            client = new RestClient("http://51.144.236.66");
           // ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //is in Program.cs
        }

        public string createUser(string email, string name)
        {
            
            var newUser = new UserNewDTO(email, name);       
           // client.Authenticator = new NtlmAuthenticator(username, password);

            request = new RestRequest("users", Method.POST);
            request.AddParameter("application/json", newUser.ToJson(), ParameterType.RequestBody);
      
            response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return "User was successfully created. \n";
            }
            else
                return "User was not created. Server response: " + response.StatusCode;
        }

        public UserCreatedDTO retrieveUser(string id)
        {
            client.Authenticator = new NtlmAuthenticator(username, password);

            request = new RestRequest("users/{id}", Method.GET);
            request.AddUrlSegment("id", id);
         
            response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                UserCreatedDTO ucDT0 = new JsonDeserializer().Deserialize<UserCreatedDTO>(response);
                return ucDT0;
            }
            else
                return null;
        }

        public DetailsFullDTO getByUserId(string userId) //full data about user
        {
            client.Authenticator = new NtlmAuthenticator(username, password);

            request = new RestRequest("users/alldetails/{userId}", Method.GET);
            request.AddUrlSegment("userId", userId);
           

            response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                DetailsFullDTO dfDTO = new JsonDeserializer().Deserialize<DetailsFullDTO>(response);
                return dfDTO;
            }
            else
                return null;
        }

        public string updateDetails(string foStudy, string fName, string lName, string uni, int yoStudy)
        {
            client.Authenticator = new NtlmAuthenticator(username, password);

            DetailsNewDTO dnDTO = new DetailsNewDTO(foStudy, fName, lName, uni, yoStudy);
            request = new RestRequest("users/details", Method.PUT);
            request.AddParameter("application/json", dnDTO.ToJson(), ParameterType.RequestBody);

            response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return "Details successfully updated.";
            }
            else
                return "Details were not updated. Server response: " + response.StatusCode;
        }

        public DetailsDTO sendUserDescription(string id) //specified details by user
        {
            client.Authenticator = new NtlmAuthenticator(username, password);

            request = new RestRequest("users/details/{id}", Method.GET);
            request.AddUrlSegment("id", id);


            response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                DetailsDTO dDTO = new JsonDeserializer().Deserialize<DetailsDTO>(response);
                return dDTO;
            }
            else
                return null;
        }

        public UserFullDTO saveSkills(int[] skillsIds, string userId)
        {
            client.Authenticator = new NtlmAuthenticator(username, password);

            SaveSkillsRequest ssR = new SaveSkillsRequest(skillsIds, userId);

            request = new RestRequest("users/skills", Method.PUT);
            request.AddParameter("application/json", ssR.ToJson(), ParameterType.RequestBody);

            response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                UserFullDTO ufDTO = new JsonDeserializer().Deserialize<UserFullDTO>(response);
                return ufDTO;
            }
            else
                return null;
        }
    }


    public class SkillController
    {
        private RestClient client = null;
        private RestRequest request = null;
        private IRestResponse response = null;

        public string username { get; set; }
        public string password { get; set; }

        public SkillController()
        {
            client = new RestClient("http://51.144.236.66");
           // ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //is in Program.cs
        }


        public SkillDTO[] getAllSkills()
        {
            client.Authenticator = new NtlmAuthenticator(username, password);

            request = new RestRequest("skills", Method.GET);

            response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                //may not work correctly, could not be tested due to server being not avaiable
                SkillDTO [] sDTO = new JsonDeserializer().Deserialize<SkillDTO[]>(response);
                return sDTO;
            }
            else
                return null;
        }

        public string addNewSkill(string skillName)
        {
            client.Authenticator = new NtlmAuthenticator(username, password);

            SkillNewDTO snDTO = new SkillNewDTO(skillName);

            request = new RestRequest("skills", Method.POST);
            request.AddParameter("application/json", snDTO.ToJson(), ParameterType.RequestBody); // chyba to

            response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return "Skill was added successfully.";
            }
            else
                return "Skill could not be added. Server response: " + response.StatusCode;
        }

    }
}
