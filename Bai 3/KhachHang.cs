namespace Bai_3
{
    class KhachHang
    {
        private string name;
        private string thoiGianThue;
        private int priceShip;
        private string loaiDoUong;
        private int soLuong;
        private double priceDrink;

        public string Name { get => name; set => name = value; }
        public string ThoiGianThue { get => thoiGianThue; set => thoiGianThue = value; }
        public int PriceShip { get => priceShip; set => priceShip = value; }
        public string LoaiDoUong { get => loaiDoUong; set => loaiDoUong = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double PriceDrink { get => priceDrink; set => priceDrink = value; }

        public KhachHang()
        {
        }
        /// <summary>
        /// Hàm tạo KH
        /// </summary>
        /// <param name="name">Tên</param>
        /// <param name="thoiGianThue">thời gian thuê</param>
        /// <param name="priceShip">giá thuyền</param>
        /// <param name="loaiDoUong">loại đồ uống</param>
        /// <param name="soLuong">số lượng</param>
        /// <param name="priceDrink">giá đồ uống</param>
        public KhachHang(string name, string thoiGianThue, int priceShip, string loaiDoUong, int soLuong, double priceDrink)
        {
            this.Name = name;
            this.ThoiGianThue = thoiGianThue;
            this.PriceShip = priceShip;
            this.LoaiDoUong = loaiDoUong;
            this.SoLuong = soLuong;
            this.PriceDrink = priceDrink;
        }
        private double TotalPrice()
        {
            return PriceDrink + PriceShip;
        }
        public override string ToString()
        {
            return Name + " | " + ThoiGianThue + " " + PriceShip + " | " + "Đô uống " + PriceDrink +
                " | " + "Tổng " + " | " + TotalPrice();
        }
    }
}
