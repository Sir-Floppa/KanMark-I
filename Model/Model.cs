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

            Console.WriteLine("AAAAAAAAAAAAAAAA1");
            System.Diagnostics.Debug.Write("AAAAAAAAAAAAAA2");

            foreach (var db in dblist)
            {
                Console.WriteLine(db);
                System.Diagnostics.Debug.WriteLine(db);
                Trace.WriteLine(db);
            }
            // var database = client.GetDatabase("testKanban");
        }
    }
}