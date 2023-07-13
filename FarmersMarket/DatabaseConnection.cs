using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows;
using FarmersMarket.Functionalities;

namespace FarmersMarket
{
    class DatabaseConnection
    {
        private static readonly string connectionUri = "mongodb+srv://2219359:QAY5VO3Xt5Te6IY2@vc-appdev.iomihxc.mongodb.net/?retryWrites=true&w=majority";

        public static void AddProduct(Product p)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("FarmersMarket").GetCollection<BsonDocument>("products");

            try
            {
                collection.InsertOne(new BsonDocument
                {
                    {"id",  p._id},
                    {"name", p._name},
                    {"stock", p._stock},
                    {"price", p._price}
                });

                MessageBox.Show("Product succesfully added!", "Success");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public static void UpdateProduct(Product p)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("FarmersMarket").GetCollection<BsonDocument>("products");

            var filter = Builders<BsonDocument>.Filter.Eq("id", p._id);
            var update = Builders<BsonDocument>.Update
                .Set("name", p._name)
                .Set("stock", p._stock)
                .Set("price", p._price);

            try
            {
                collection.UpdateOne(filter, update);
                //MessageBox.Show("Product succesfully updated!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public static void RemoveProduct(int id)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("FarmersMarket").GetCollection<BsonDocument>("products");

            var filter = Builders<BsonDocument>.Filter.Eq("id", id);

            try
            {
                collection.DeleteOne(filter);
                MessageBox.Show("Product succesfully deleted!", "Success");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public static Product GetProduct(int id)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("FarmersMarket").GetCollection<BsonDocument>("products");

            var filter = Builders<BsonDocument>.Filter.Eq("id", id);
            var document = collection.Find(filter).FirstOrDefault();

            try
            {
                Product p = new Product(document["id"].AsInt32, document["name"].AsString, document["stock"].AsDouble, document["price"].AsDouble);
                return p;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return null;
            }
        }
        public static List<Product> GetProducts()
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("FarmersMarket").GetCollection<BsonDocument>("products");

            var documents = collection.Find(new BsonDocument()).ToList();

            List<Product> products = new List<Product>();

            foreach (var document in documents)
            {
                Product p = new Product(document["id"].AsInt32, document["name"].AsString, document["stock"].AsDouble, document["price"].AsDouble);
                products.Add(p);
            }

            return products;
        }
    }
}
