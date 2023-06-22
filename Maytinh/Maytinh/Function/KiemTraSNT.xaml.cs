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
    public partial class KiemTraSNT : ContentPage
    {
        public KiemTraSNT()
        {
            InitializeComponent();
        }
        private void BtnLamMoi_Clicked(object sender, EventArgs e)
        {
            txtA.Text = "";
            lbKetQua.Text = "";
        }

        private void BtnTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                //int a = int.Parse(txtA.Text);
                //if (a == 0 || a == 1)
                //{
                //    lbKetQua.Text = " " + a.ToString() + " không phải số nguyên tố";
                //}
                //else
                //{
                //    for (int i = 2; i <= a / 2; i++)
                //    {
                //        if (a % i == 0)
                //        {
                //            lbKetQua.Text = " " + a.ToString() + " không phải số nguyên tố";
                //            return;
                //        }

                //    }
                //    lbKetQua.Text = " " + a.ToString() + " là số nguyên tố";
                //}

                int a = int.Parse(txtA.Text);
                lbKetQua.Text = IsPrime(a) ? " " + a.ToString() + " là số nguyên tố"
                                            : " " + a.ToString() + " không phải số nguyên tố";

            }
            catch
            {
                lbKetQua.Text = " Lỗi biểu thức";
            }
        }
            public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ChucNang();
        }
    }
}