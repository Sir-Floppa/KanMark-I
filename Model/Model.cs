using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;

namespace Model
{
    public abstract class Model
    {
        public static void newTaskDB(Controller.TaskCard newCard)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var dblist = client.ListDatabases().ToList();

            foreach (var db in dblist)
            {
                System.Diagnostics.Debug.WriteLine(db);
            }
            // var database = client.GetDatabase("testKanban");
        }
    }
}