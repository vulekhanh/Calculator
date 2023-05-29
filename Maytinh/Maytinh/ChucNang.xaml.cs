﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Maytinh.Function;

namespace Maytinh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChucNang : ContentPage
    {
        public ChucNang()
        {
            InitializeComponent();
        }
        private void BtnHome_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
        private void BtnGiaiPTBacNhat_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new GiaiPTBacNhat();
        }
        private void BtnGiaiPTBac2_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new GiaiPTBac2();
        }
        private void BtnGiaiPTBac3_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new GiaiPTBac3();
        }
        private void BtnGiaiHPT2An_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new GiaiHPT2An();
        }
        private void BtnGiaiHPT3An_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new GiaiHPT3An();
        }
        private void BtnTimUCLNBCNN_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new TimUCLNBCNN();
        }
        private void BtnKiemTraSNT_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new KiemTraSNT();
        }
        private void BtnTimCucTriHamBac2_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new TimCucTriHamBac2();
        }
        private void BtnTimCucTriHamBac3_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new TimCucTriHamBac3();
        }
        private void BtnDoiDonVi_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new DoiDonVi();
        }

        private void btnDoiTrongLuong_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new DoiTrongLuong();
        }  
        private void btnDoiNhietDo_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new DoiNhietDo();
        }    
        private void btnDoiVanToc_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new DoiVanToc();
        }     

    }
}