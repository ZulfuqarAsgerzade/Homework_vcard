using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using VCard.Models;

namespace VCard.Controllers
{
    public class WorkApi
    {
        public static List<User> GetData()
        {
            List<User> users = new List<User>();


            HttpClient client = new HttpClient();

            string json = client.GetStringAsync("https://randomuser.me/api/?results=10").Result;

            var jsonObject = JObject.Parse(json);

            dynamic dynamicData = JsonConvert.DeserializeObject<dynamic>(json);

            foreach (var data in dynamicData.results)
            {
                User user = new User();

                user.FirstName= data.name.first;
                user.LastName = data.name.last;
                user.Email = data.email;
                user.PhoneNumber = data.phone;
                user.Country = data.location.country;

                users.Add(user);
            }

            return users;
        }
         
         

    }
}
