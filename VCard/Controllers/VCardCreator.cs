using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCard.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VCard.Controllers
{
    public class VCardCreator
    {
        private string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public void createVCardAsync(List<User> userList)
        {
            createFolder();

            string folderPath = this.projectPath + "\\VCards\\";

            foreach (var user in userList)
            {

                File.WriteAllLinesAsync(folderPath + $"data_{user.FirstName}.vcf", new string[]
                {
                    "BEGIN:VCARD \n" +
                    "VERSION:2.1 \n" +
                    "N:" + user.LastName + ";" + user.FirstName + "\n" +
                    "FN:" + user.FirstName + " " + user.LastName + "\n" +
                    "ADR; HOME; PREF:; ; ; ; ; " + user.Country + "\n" +
                    "TEL; WORK; VOICE:" + user.PhoneNumber + "\n" +
                    "EMAIL; PREF; INTERNET:" + user.Email + "\n" +
                    "END:VCARD"


                }, Encoding.UTF8);
            }

            Console.WriteLine("File(s) created!");
        }

        private void createFolder()
        {
            string folderName = Path.Combine(this.projectPath, "VCards");
            Directory.CreateDirectory(folderName);
        }
    }
}
