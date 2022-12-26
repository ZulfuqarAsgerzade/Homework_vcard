using System.Security.Cryptography.X509Certificates;
using VCard.Controllers;
using VCard.Models;

public class Program
{
    public static void Main()
    {
        List<User> users = WorkApi.GetData();

        VCardCreator vCardCreator = new VCardCreator();
        vCardCreator.createVCardAsync(users);

    }
}