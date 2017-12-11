using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH_Update_Vattu.Logic
{
    public class VatTu
    {
        public String DVTT { get; set; }
        public String TenVatTu { get; set; }
        public String MaHoatChat { get; set; }
        public String MaDuongDung { get; set; }
        public String SoDK { get; set; }
        public double DonGia { get; set; }
        //public int IsUpdated { get; set; }
        public String SoQuyetDinh { get; set; }
        public String GoiThau { get; set; }
        public String NhomThau { get; set; }
        public String SoCVBHXH { get; set; }

        public String MaLoaiVatTu { get; set; }
        public String MaNhomVatTu { get; set; }
        public int TamNgung { get; set; }
        public int DaCapNhap { get; set; }
        public String SoQuyetDinh_CapNhap { get; set; }

        public void setEmptyVatTu()
        {
            this.DaCapNhap = -1;
            this.DonGia = -1;
            this.GoiThau = "";
            this.MaDuongDung = "";
            this.MaHoatChat = "";
            this.MaLoaiVatTu = "-1";
            this.MaNhomVatTu = "-1";
            this.NhomThau = "";
            this.SoCVBHXH = "";
            this.SoDK = "";
            this.SoQuyetDinh = "";
            this.SoQuyetDinh_CapNhap = "";
            this.TamNgung = -1;
            this.TenVatTu = "";
           

        }
            
    }
}
