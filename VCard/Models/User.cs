using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCard.Models
{
    public class User
    {
        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string PhoneNumber { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }
}
