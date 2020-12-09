using AppContacts.Models;
using AppContacts.SQLiteDb;
using AppContacts.ViewModels;
using SQLite;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppContacts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FieldSwap : ContentPage
    {
        readonly SQLiteAsyncConnection _connection = DependencyService.Get<ISQLite>().GetConnection();
        public ObservableCollection<Contacts> CList { get; set; }

        public FieldSwap()
        {
            this.BindingContext = this;

            InitializeComponent();
            ReadData();
        }

        private void Display_Address(object sender, EventArgs e)
        {
            foreach (var item in CList)
            {
                item.Address_Visible = true;
                item.Email_Visible = false;
            }
        }

        private void Display_eMail(object sender, EventArgs e)
        {
            foreach (var item in CList)
            {
                item.Address_Visible = false;
                item.Email_Visible = true;
            }
        }
        public  void ReadData()
        {
            var list = _connection.Table<Contacts>().ToListAsync().Result;
            CList = new ObservableCollection<Contacts>(list);
            listView.ItemsSource = CList;
        }

    }
}