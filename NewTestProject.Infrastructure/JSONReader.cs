using System.Text.Json.Serialization;
using NewTestProject.Core.Entity;
using Newtonsoft.Json;

namespace NewTestProject.Infrastructure;

public class JSONReader
        // this class read and write all the data from the json file on new List
{

    public List<MovieRating> Seed()
    {
        using (StreamReader r = new StreamReader("../../../../MovieTestProject.Infrastructure/ratings.json"))
        {
            string json = r.ReadToEnd();
            List<MovieRating> items = JsonConvert.DeserializeObject<List<MovieRating>>(json);

            return items;
        }
    }
}