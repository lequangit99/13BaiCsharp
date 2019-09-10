namespace Bai_9
{
    class Book
    {
        private string name;
        private int price;
        private int soLuong;
        private int sale;

        public Book(string name, int price, int soLuong, int sale)
        {
            this.Name = name;
            this.Price = price;
            this.SoLuong = soLuong;
            this.Sale = sale;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Sale { get => sale; set => sale = value; }
        public override string ToString()
        {
            return Name + ", Số lượng" + SoLuong + ", Giá " + Sum();
        }
        public int Sum()
        {
            return Price * SoLuong - (Price * SoLuong / 100 * Sale);
        }
    }
}
