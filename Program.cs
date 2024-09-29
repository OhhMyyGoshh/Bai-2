using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Bai 1



            //Console.Write("Nhap a : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap b : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Tong : " + (a + b));
            //Console.WriteLine("Hieu : " + (a - b));
            //Console.WriteLine("Tich : " + (a * b));
            //Console.WriteLine("Thuong : " + (a / b));




            // Bai 2
            //Console.Write("Nhap chieu dai hinh chu nhat : ");
            //int dai = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap chieu rong hinh chu nhat : ");
            //int rong = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Chu vi hinh chu nhat : " + (dai + rong) * 2);
            //Console.WriteLine("Dien tich hinh chu nhat : " + dai * rong);

            // Bai 3
            //Console.Write("Nhap duong kinh hinh tron : ");
            //double duongKinh = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Chu vi hinh tron : " + duongKinh * Math.PI);
            //Console.WriteLine("Dien tich hinh tron : " + Math.Pow(duongKinh, 2) * Math.PI);
            //Console.WriteLine("Ban kinh hinh tron : " + duongKinh / 2);

            // Bai 4
            //Console.Write("Nhap ho ten : ");
            //string hoTen = Console.ReadLine();
            //Console.Write("Nhap lop : ");
            //string lop = Console.ReadLine();
            //Console.Write("Nhap diem HK1 : ");
            //double diemHK1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Nhap diem HK2 : ");
            //double diemHK2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Diem trung binh ca nam : " + (diemHK1 + diemHK2*2) / 3);

            // Bai 5
            //Console.Write("Nhập họ tên nhân viên: ");
            //string hoten_nv = Console.ReadLine();
            //Console.Write("Nhập giới tính:");
            //string gioitinh = Console.ReadLine();
            //Console.Write("Nhập ngày sinh:");
            //string ngaysinh = Console.ReadLine();
            //Console.Write("Nhập hệ số lương:");
            //double heso_luong = double.Parse(Console.ReadLine());
            //Console.Write("Lương cơ bản:");
            //int luong_cb = int.Parse(Console.ReadLine());
            //Console.Write("Số năm làm việc:");
            //int so_nam_lam = int.Parse(Console.ReadLine());
            //double phucap = 0;
            //if (so_nam_lam > 5)
            //{
            //    phucap = luong_cb / 2;
            //}
            //else
            //{
            //     Console.WriteLine("Không được hưởng phụ cấp");
            //}
            //Console.WriteLine("Thông tin nhân viên : ");
            //Console.WriteLine("Họ tên nhân viên: " + hoten_nv);
            //Console.WriteLine("Giới tính: " + gioitinh);
            //Console.WriteLine("Ngày sinh: " + ngaysinh);
            //Console.WriteLine("Hệ số lương: " + heso_luong);
            //Console.WriteLine("Lương cơ bản: " + luong_cb);
            //Console.WriteLine("Số năm làm việc: " + so_nam_lam);
            //Console.WriteLine("Phụ cấp: " + phucap);

            // Bai 6
            Console.Write("Nhập ngày: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());

            DateTime inputDate = new DateTime(year, month, day);

            DateTime yesterday = inputDate.AddDays(-1);
            DateTime tomorrow = inputDate.AddDays(1);

            Console.WriteLine("Ngày hôm qua: " + yesterday.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngày mai: " + tomorrow.ToString("dd/MM/yyyy"));
        }
    }
}
