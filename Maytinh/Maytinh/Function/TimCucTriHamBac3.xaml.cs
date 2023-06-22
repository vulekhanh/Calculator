using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maytinh.Function
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimCucTriHamBac3 : ContentPage
    {
        private XuLyData dataAccess;
        string o = "Cực trị hàm bậc 3";
        public TimCucTriHamBac3()
        {
            InitializeComponent();
            this.dataAccess = new XuLyData();
        }


        private void BtnTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                double d = double.Parse(txtD.Text);
                double delta = Math.Pow(b, 2) - 3 * a * c;
                if (delta <= 0)
                {
                    lbKetQua1.Text = " Không có cực trị";
                }
                else
                {
                    //3ax^2 + bx + c = 0
                    handle(3 * a, 2 * b, c);
                }
            }
            catch
            {
                lbKetQua1.Text = " Lỗi biểu thức";
            }
            string p = lbKetQua1.Text;
            this.dataAccess.AddLS(DateTime.Now.ToString(), o, p);
        }
        public void handle(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            if (x1 < x2)
            {
                lbKetQua1.Text = " Hàm số đạt cực đại tại x = " + x2.ToString();
                lbKetQua2.Text = " Hàm số đạt cực tiểu tại x = " + x1.ToString();
            }
            else
            {
                lbKetQua1.Text = " Hàm số đạt cực đại tại x = " + x1.ToString();
                lbKetQua2.Text = " Hàm số đạt cực tiểu tại x = " + x2.ToString();
            }
        }
        private void BtnLamMoi_Clicked(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            lbKetQua1.Text = "";
            lbKetQua2.Text = "";
        }
        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ChucNang();
        }
    }
}