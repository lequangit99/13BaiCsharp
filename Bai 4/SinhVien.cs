using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class SinhVien
    {
        private string name;
        private string tenMonHoc;
        private int soTinChi;
        private int diem;

        public SinhVien(string name, string tenMonHoc, int soTinChi, int diem)
        {
            this.Name = name;
            this.TenMonHoc = tenMonHoc;
            this.SoTinChi = soTinChi;
            this.Diem = diem;
        }

        public string Name { get => name; set => name = value; }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public int Diem { get => diem; set => diem = value; }
    }
}
