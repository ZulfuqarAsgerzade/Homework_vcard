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
        private static int _ID = 1;
        public int ID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }

        public User()
        {
            this.ID = _ID;
            _ID++;
        }
    }
}
