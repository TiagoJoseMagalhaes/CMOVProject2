﻿using WeatherIO.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherIO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CityWeatherView : ContentPage
    {
        private readonly CityWeatherViewModel _vm;
        public CityWeatherView(string city, string country)
        {
            InitializeComponent();
            _vm = new CityWeatherViewModel(city, country);
            BindingContext = _vm;
            _vm.UpdateWeather();
        }

        private void ToggleFavorite(object sender, System.EventArgs e)
        {
            _vm.ToggleFavorite(sender, e);
        }

        async void GoToGraph(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ForecastInfoView(_vm.City,_vm.Country));
        }
    }
}