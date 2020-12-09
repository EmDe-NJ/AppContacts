using AppContacts.Models;
using AppContacts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppContacts.ViewModels
{
    public class MainPage2ViewModel : BaseViewModel
    {
        public List<City> ListCities
        {
            get;
            set;
        }
        public MainPage2ViewModel()
        {
            ListCities = PickerService.GetCities().OrderBy(c => c.Value).ToList();
        }
        private City _selectedCity;
        public City SelectedCity
        {
            get
            {
                return _selectedCity;
            }
            set
            {
                SetProperty(ref _selectedCity, value);
                //put here your code  
                CityText = "City : " + _selectedCity.Value;
            }
        }
        private string _cityText;
        public string CityText
        {
            get
            {
                return _cityText;
            }
            set
            {
                SetProperty(ref _cityText, value);
            }
        }
    }
}
