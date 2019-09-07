namespace Bai_4
{
    class SinhVien
    {
        private string tenMonHoc;
        private int soTinChi;
        private double diem;

        public SinhVien(string tenMonHoc, int soTinChi, double diem)
        {
            this.TenMonHoc = tenMonHoc;
            this.SoTinChi = soTinChi;
            this.Diem = diem;
        }

        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public double Diem { get => diem; set => diem = value; }

        public override string ToString()
        {
            return TenMonHoc + " | " + SoTinChi + " | " + Diem;
        }
    }
}
