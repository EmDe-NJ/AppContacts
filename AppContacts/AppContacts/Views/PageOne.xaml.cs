using AppContacts.Models;
using AppContacts.SQLiteDb;
using SQLite;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppContacts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageOne : ContentPage, INotifyPropertyChanged
    {
        readonly SQLiteAsyncConnection _connection = DependencyService.Get<ISQLite>().GetConnection();
        public ObservableCollection<Contacts> CList { get; set; }

        public PageOne()
        {
            this.BindingContext = this;
            InitializeComponent();
            Contact_Address_eMail.SelectedIndexChanged += (sender, args) => {
                if (Contact_Address_eMail.SelectedIndex == -1)
                {
                    lbldisp.Text = "Nil Value";
                }
                else
                {
                    lbldisp.Text = Contact_Address_eMail.Items[Contact_Address_eMail.SelectedIndex];
                    if (lbldisp.Text == "Contact_Address")
                    {
                        foreach (var item in CList)
                        {
                            item.Address_Visible = true;
                            item.Email_Visible = false;
                        }
                        
                    }

                    if (lbldisp.Text == "Contact_eMail")
                    {
                        foreach (var item in CList)
                        {
                            item.Address_Visible = false;
                            item.Email_Visible = true;
                        }
                    }
                }
            };

            ReadData();
        }

        public void ReadData()
        {
            var list = _connection.Table<Contacts>().ToListAsync().Result;
            CList = new ObservableCollection<Contacts>(list);
            listView.ItemsSource = CList;
        }

    }
}   