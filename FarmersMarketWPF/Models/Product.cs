using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FarmersMarket.Models
{
    [BsonIgnoreExtraElements]
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        public int sku { get; set; }
        public string name { get; set; }
        public double stock { get; set; }
        public double price { get; set; }

        public Product(int sku, string name, double stock, double price)
        {
            this.sku = sku;
            this.name = name;
            this.stock = stock;
            this.price = price;
        }
    }
}
