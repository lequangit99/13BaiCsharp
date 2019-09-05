namespace Bai_1
{
    class KhachHang
    {
        private string maKH;
        private string hoTen;
        private string diaChi;
        private string ngayChotSo;
        private int soThangTruoc;
        private int soThangSau;
        public KhachHang()
        {
        }

        public KhachHang(string maKH, string hoTen, string diaChi, string ngayChotSo, int soThangTruoc, int soThangSau)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.ngayChotSo = ngayChotSo;
            this.soThangTruoc = soThangTruoc;
            this.soThangSau = soThangSau;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NgayChotSo { get => ngayChotSo; set => ngayChotSo = value; }
        public int SoThangTruoc { get => soThangTruoc; set => soThangTruoc = value; }
        public int SoThangSau { get => soThangSau; set => soThangSau = value; }

        public double tienDien()
        {
            int soDien = SoThangSau - SoThangTruoc;
            int tienDien = 0;
            if (soDien > 0 && soDien < 50)
            {
                tienDien = soDien * 100;
            }
            else if (soDien > 50 && soDien < 100)
            {
                tienDien = (50 * 100) + (50 * 200);
            }
            else if (soDien > 100 && soDien < 200)
            {
                tienDien = (50 * 100) + (50 * 200) + (100 * 300);
            }
            else
            {
                tienDien = (50 * 100) + (50 * 200) + (100 * 300) + (soDien - 200) * 400;
            }
            return tienDien + (tienDien * 0.1);
        }
        public override string ToString()
        {
            return MaKH + " | " + HoTen + " | " + DiaChi + " | " + NgayChotSo + " | " + SoThangTruoc + " | "
                + SoThangSau + " | " + tienDien();
        }
    }
}
