using AppContacts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContacts.Services
{
    public class PickerService
    {
        public static List<City> GetCities()
        {
            var cities = new List<City>()
            {
                new City() {Key = 1, Value = "Karachi"},
                new City() {Key = 2, Value = "New York"},
                new City() {Key = 3, Value = "London"},
                new City() {Key = 4, Value = "New Delhi"},
                new City() {Key = 5, Value = "Lahore"},
                new City() {Key = 6, Value = "Dubai"},
                new City() {Key = 7, Value = "Dhaka"},
            };
            return cities;
        }
    }
}
