using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;

namespace Model
{
    public abstract class Model
    {
        public static string currentCollection = "Default Board";
        private static string mongoClient = "mongodb://localhost:27017";

        public static IMongoCollection<BsonDocument> ConnectToDB()
        {
            var client = new MongoClient(mongoClient);

            var dblist = client.ListDatabases().ToList();

            foreach (var db in dblist)
            {
                System.Diagnostics.Debug.WriteLine(db);
            }

            var database = client.GetDatabase("testKanban");

            var collection = database.GetCollection<BsonDocument>(currentCollection);

            return collection;
        }

        public static List<string> GetCols()
        {
            var client = new MongoClient(mongoClient);

            var dblist = client.ListDatabases().ToList();

            var database = client.GetDatabase("testKanban");

            var collections = database.ListCollectionNames().ToList();

            return collections;
        }

        public static void RemoveCollection(string collection)
        {
            var client = new MongoClient(mongoClient);

            var dblist = client.ListDatabases().ToList();

            var database = client.GetDatabase("testKanban");

            database.DropCollection(collection);
        }

        public static void newTaskDB(Controller.TaskCard newCard)
        {
            var collection = ConnectToDB();

            var newDoc = new BsonDocument
            {

                {"title", newCard.taskName},
                {"description", newCard.taskDescription},
                {"status", newCard.taskStatus},
                {"posX", newCard.posX},
                {"posY", newCard.posY}
            };

            collection.InsertOne(newDoc);

            System.Diagnostics.Debug.WriteLine("Task inserted");
        }

        public static void removeFromDB(string titleFilter, string descFilter)
        {
            var collection = ConnectToDB();
            var filter = Builders<BsonDocument>.Filter.Eq("title", titleFilter) & Builders<BsonDocument>.Filter.Eq("description", descFilter);

            collection.DeleteOne(filter);
        }

        public static void updatePosition(int Position, string titleFilter, string descFilter, string status)
        {
            var collection = ConnectToDB();
            var filter1 = Builders<BsonDocument>.Filter.Eq("title", titleFilter) &
                Builders<BsonDocument>.Filter.Eq("description", descFilter) &
                Builders<BsonDocument>.Filter.Eq("status", status);

            var update = Builders<BsonDocument>.Update.Set("posY", Position);

            collection.UpdateOne(filter1, update);
        }

        public static void updateStatus(string status, string titleFilter, string descFilter, string originStatus)
        {
            var collection = ConnectToDB();
            var filter1 = Builders<BsonDocument>.Filter.Eq("title", titleFilter) &
                Builders<BsonDocument>.Filter.Eq("description", descFilter) &
                Builders<BsonDocument>.Filter.Eq("status", originStatus);

            var update = Builders<BsonDocument>.Update.Set("status", status);

            collection.UpdateOne(filter1, update);
        }
    }
}