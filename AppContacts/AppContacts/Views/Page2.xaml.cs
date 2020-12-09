using AppContacts.Models;
using AppContacts.SQLiteDb;
using AppContacts.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppContacts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        readonly SQLiteAsyncConnection _connection
    = DependencyService.Get<ISQLite>().GetConnection();
        public ObservableCollection<Contacts> CList { get; set; }

        public Page2()
        {
            BindingContext = new Page3ViewModel();

            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _connection.CreateTableAsync<Contacts>();
            var list = _connection.Table<Contacts>().ToListAsync().Result;
            CList = new ObservableCollection<Contacts>(list);
            ContactList.ItemsSource = CList;
        }
    }
}