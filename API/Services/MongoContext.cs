using System;
using MongoDB.Bson;
namespace api.Services
{
    public class MongoContext
    {
        private IMongoClient client { get; set; }
        public IMongoDatabase db { get; set; }
        public MongoContext(string dbname)
        {
            client = new MongoClient("mongodb+srv://ssumti:Nun0izdab3zT@cluster0.mdsaz.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            db = client.GetDatabase(dbname);
        }
    }
}