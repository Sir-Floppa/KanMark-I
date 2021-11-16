using MongoDB.Bson;
using MongoDB.Driver;

namespace Model
{
    public abstract class Model
    {
        public static void newTaskDB(string title, string desc)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("testKanban");

            database.Aggregate()
        }
    }
}