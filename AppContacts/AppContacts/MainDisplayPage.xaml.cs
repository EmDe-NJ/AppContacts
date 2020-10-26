using AppContacts.Models;
using AppContacts.SQLiteDb;
using SQLite;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppContacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainDisplayPage : ContentPage
    {
        readonly SQLiteAsyncConnection _connection = DependencyService.Get<ISQLite>().GetConnection();
        public MainDisplayPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _connection.CreateTableAsync<Contacts>();
            ReadData();
        }
        public ObservableCollection<Contacts> CList { get; set; }
        private void Save(object sender, EventArgs e)
        {
            _connection.InsertAsync(new Contacts() { Contact_Name = C_Name.Text,
                Contact_Address = C_Address.Text, Contact_eMail = C_eMail.Text });
            ReadData();
        }
        public void ReadData()
        {
            var list = _connection.Table<Contacts>().ToListAsync().Result;
            CList = new ObservableCollection<Contacts>(list);
            ContactList.ItemsSource = CList;
        }
    }
}