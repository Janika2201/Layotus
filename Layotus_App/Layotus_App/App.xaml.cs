﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layotus_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Rgbmodel();//стартовая и единственная страница
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
