using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FarmersMarket.Models;

namespace FarmersMarket
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public List<Product> products { get; set; }

        public Admin()
        {
            InitializeComponent();
            products = DatabaseConnection.GetProducts();
            grid_Products.ItemsSource = products;
            DataContext = this;
        }

        private void refreshProducts()
        {
            grid_Products.UnselectAll();

            input_SKU.Text = "";
            input_Name.Text = "";
            input_Amount.Text = "";
            input_Price.Text = "";

            products = DatabaseConnection.GetProducts();
            grid_Products.ItemsSource = products;
            DataContext = this;
        }

        private void grid_Products_Selection(object sender, SelectionChangedEventArgs e)
        {
            Product p = (Product)grid_Products.SelectedItem;

            if (p != null)
            {
                input_SKU.Text = p.sku.ToString();
                input_Name.Text = p.name;
                input_Amount.Text = p.stock.ToString();
                input_Price.Text = p.price.ToString();
            }
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            String sku = input_SKU.Text;
            String name = input_Name.Text;
            String stock = input_Amount.Text;
            String price = input_Price.Text;

            if (sku == "" || name == "" || stock == "" || price == "") MessageBox.Show("All fields required!");
            else
            {
                Product p = new Product(Int32.Parse(sku), name, Double.Parse(stock), Double.Parse(price));
                DatabaseConnection.AddProduct(p);
                refreshProducts();
            }
        }

        private void btn_Update_Click(object sender, RoutedEventArgs e)
        {
            Product p = (Product)grid_Products.SelectedItem;
            Product updatedP = new Product(p.sku, input_Name.Text, Double.Parse(input_Amount.Text), Double.Parse(input_Price.Text));
            DatabaseConnection.UpdateProduct(updatedP);
            refreshProducts();
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            Product p = (Product)grid_Products.SelectedItem;

            if (p != null) { DatabaseConnection.RemoveProduct(p.sku); }
            else { MessageBox.Show("No product selected!", "Error"); }

            refreshProducts();
        }
    }
}
