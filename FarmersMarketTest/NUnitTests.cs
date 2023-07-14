using NUnit.Framework;
using FarmersMarket.Models;

namespace FarmersMarketTest
{
    public class NUnitTests
    {
        // Arrange: Prepare the necessary data and objects for the 
        // Act: Perform the actual test actions or method calls
        // Assert: Verify the expected results or behavior

        [Test]
        public void AddProduct_ValidProduct_ProductAddedSuccessfully()
        {
            Product product = new Product(1,"Test Product", 10, 9.99);

            DatabaseConnection.AddProduct(product);

            Product addedProduct = DatabaseConnection.GetProduct(product.sku);
            Assert.IsNotNull(addedProduct);
            Assert.AreEqual(product.sku, addedProduct.sku);
            Assert.AreEqual(product.name, addedProduct.name);
            Assert.AreEqual(product.stock, addedProduct.stock);
            Assert.AreEqual(product.price, addedProduct.price);
        }

        [Test]
        public void UpdateProduct_ValidProduct_ProductUpdatedSuccessfully()
        {
            Product product = new Product(1, "Updated Product", 20, 19.99);

            DatabaseConnection.UpdateProduct(product);

            Product updatedProduct = DatabaseConnection.GetProduct(product.sku);
            Assert.IsNotNull(updatedProduct);
            Assert.AreEqual(product.sku, updatedProduct.sku);
            Assert.AreEqual(product.name, updatedProduct.name);
            Assert.AreEqual(product.stock, updatedProduct.stock);
            Assert.AreEqual(product.price, updatedProduct.price);
        }

        [Test]
        public void RemoveProduct_ValidSKU_ProductRemovedSuccessfully()
        {
            int sku = 1;

            DatabaseConnection.RemoveProduct(sku);

            Product removedProduct = DatabaseConnection.GetProduct(sku);
            Assert.IsNull(removedProduct);
        }

        [Test]
        public void GetProduct_ValidSKU_ReturnsProduct()
        {
            int sku = 1;

            Product product = DatabaseConnection.GetProduct(sku);

            Assert.IsNotNull(product);
            Assert.AreEqual(sku, product.sku);
        }

        [Test]
        public void GetProducts_ReturnsListOfProducts()
        {
            var products = DatabaseConnection.GetProducts();

            Assert.IsNotNull(products);
            Assert.IsNotEmpty(products);
        }
    }
}
