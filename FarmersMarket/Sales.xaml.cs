using FarmersMarket.Functionalities;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace FarmersMarket
{
    /// <summary>
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : Window
    {
        public List<Product> products { get; set; }
        public List<Product> basket { get; set; }
        private Product selected;
        private double sum;
        public Sales()
        {
            InitializeComponent();
            products = DatabaseConnection.GetProducts();
            basket = new List<Product>();
            DataContext = this;
        }

        private void refreshProducts()
        {
            grid_Products.UnselectAll();

            products = DatabaseConnection.GetProducts();
            grid_Products.ItemsSource = products;
            DataContext = this;
        }

        private void refreshBasket()
        {
            grid_Basket.UnselectAll();
            grid_Basket.ItemsSource = null;
            grid_Basket.ItemsSource = basket;
            DataContext = this;
        }

        private void grid_Products_Selection(object sender, SelectionChangedEventArgs e)
        {
            selected = (Product)grid_Products.SelectedItem;
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Product p = new(selected._id, selected._name, selected._stock, selected._price);
            double limit = selected._stock;

            if (selected != null)
            {
                if(!(basket.Exists(x => x._id.Equals(p._id))))
                {
                    p._stock = 1;
                    basket.Add(p);
                    sum = Math.Truncate((sum + p._price) * 100) / 100;
                    lbl_GrandTotalValue.Content = sum.ToString();
                }
                else
                {
                    var element = basket.Find(x => x._id.Equals(p._id));
                    if (element._stock < selected._stock)
                    {
                        element._stock++;
                        sum = Math.Truncate((sum + p._price) * 100) / 100;
                        lbl_GrandTotalValue.Content = sum.ToString();
                    }
                    else MessageBox.Show("Max limit reached!", "Error");
                }
                refreshBasket();
            }
            else { MessageBox.Show("Select a product from inventory before adding to cart!", "Error"); }
        }

        private void btn_Min_Click(object sender, RoutedEventArgs e)
        {
            Product p = (Product)grid_Basket.SelectedItem;

            if (p != null)
            {
                if(p._stock > 1) p._stock--;
                else basket.Remove(p);
                sum = Math.Truncate((sum - p._price) * 100) / 100;
                lbl_GrandTotalValue.Content = sum.ToString();
                refreshBasket();
            }
            else { MessageBox.Show("Select a product from basket before removing to cart!", "Error"); }
        }

        private void btn_Buy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach(Product p in basket)
                {
                    Product x = DatabaseConnection.GetProduct(p._id);
                    x._stock = x._stock - p._stock;
                    DatabaseConnection.UpdateProduct(x);
                }
                MessageBox.Show("Thank you for shopping!", "Success!");
                sum = 0;
                lbl_GrandTotalValue.Content = sum;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            basket.Clear();
            refreshProducts();
            refreshBasket();
        }
    }
}
