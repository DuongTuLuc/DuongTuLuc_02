using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongTuLuc_02
{
    class NhanVienBC:NhanVien
    {
        private  string mucxeploai;

        public NhanVienBC():base()
        { }

        public NhanVienBC(string maso, string hoten, int luongcung) : base(maso,hoten,luongcung)
        {
            this.mucxeploai = mucxeploai;
        }

        public string MucXeploai
        {
            set { this.mucxeploai = value; }
            get { return mucxeploai; }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap xep loai:");
            this.mucxeploai = Console.ReadLine();
        }

        public override double TinhLuong()
        {
            double luong;
            if (this.mucxeploai == "a")
            {
                 luong = 1.5 * Luongcung;
            }
            else if (this.mucxeploai == "b")
            {
                 luong = 1.0 * Luongcung;
            }
            else
            {
                 luong = 0.5 * Luongcung;
            }
            return luong;
        }
    }
}
