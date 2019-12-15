﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WeatherIO.Views;

namespace WeatherIO
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CityWeatherView("Lisboa", "Portugal"));
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
