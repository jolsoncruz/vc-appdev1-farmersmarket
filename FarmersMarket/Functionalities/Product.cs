namespace FarmersMarket.Functionalities
{
    public class Product
    {
        private int id;
        private string name;
        private double stock;
        private double price;

        public Product(int id, string name, double stock, double price)
        {
            this.id = id;
            this.name = name;
            this.stock = stock;
            this.price = price;
        }

        public int _id { 
            get { return id; } 
            set { this.id = value; }  
        }

        public string _name
        {
            get { return name; }
            set { this.name = value; }
        }

        public double _stock
        {
            get { return stock; }
            set { this.stock = value; }
        }

        public double _price
        {
            get { return price; }
            set { this.price = value; }
        }

    }
}
