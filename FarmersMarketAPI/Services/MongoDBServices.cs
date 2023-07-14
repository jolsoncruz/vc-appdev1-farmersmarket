using FarmersMarketAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FarmersMarketAPI.Services
{
    public class MongoDBServices
    {
        private readonly IMongoCollection<Product> _productsCollection;

        public MongoDBServices(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _productsCollection = database.GetCollection<Product>(mongoDBSettings.Value.CollectionName);
        }

        public async Task CreateAsync(Product product)
        {
            await _productsCollection.InsertOneAsync(product);
            return;
        }

        public async Task<List<Product>> GetAsync()
        {
            return await _productsCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task UpdateStockAsync(string id, double stock)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq("Id", id);
            UpdateDefinition<Product> update = Builders<Product>.Update.Set("stock", stock);
            await _productsCollection.UpdateOneAsync(filter, update);
        }

        public async Task DeleteAsync(string id)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq("Id", id);
            await _productsCollection.DeleteOneAsync(filter);
            return;
        }
    }
}
