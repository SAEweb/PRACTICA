﻿using PRACTICA.view;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRACTICA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new login());
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
