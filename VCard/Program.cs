using VCard.Controllers;
using VCard.Models;

public class Program
{
    public static async Task Main()
    {
        WorkApi.GetData();

        /*    var url = "https://randomuser.me/api/?results=1";

            using (var httpClient = new HttpClient())
            {
                var responce = await httpClient.GetAsync(url);

                var responceString = await responce.Content.ReadAsStringAsync();

                var users = System.Text.Json.JsonSerializer.Deserialize<List<User>>(responceString);
             }*/
    }
}