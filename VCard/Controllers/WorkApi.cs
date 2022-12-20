using Newtonsoft.Json;
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
        User user;

        public static async Task GetData()
        {
            HttpClient client = new HttpClient();

            var responseMessage = client.GetAsync("https://randomuser.me/api/?results=1").Result;


            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {

                string json = responseMessage.Content.ReadAsStringAsync().Result;

                var data = JsonConvert.DeserializeObject<User>(json);

                Console.WriteLine(new String('-', 50));

                Console.WriteLine(data);

                Console.WriteLine(new String('-', 50));

                Console.WriteLine(data.FirstName + " " + data.LastName + " " + data.City);

            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
         
         

    }
}
