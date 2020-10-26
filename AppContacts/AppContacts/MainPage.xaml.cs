using AppContacts.Models;
using AppContacts.SQLiteDb;
using SQLite;
using System.Collections;
using System.Linq;
using Xamarin.Forms;

namespace AppContacts
{
    public partial class MainPage : ContentPage
    {
        readonly SQLiteAsyncConnection _connection 
            = DependencyService.Get<ISQLite>().GetConnection();
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            int[] intArray;
            intArray = new int[4];
            intArray[0] = 13;
            intArray[1] = 14;
            intArray[2] = 18;
            intArray[3] = 21;

            var list = _connection.Table<Contacts>().ToListAsync().Result;
            var myAL = new ArrayList();
            foreach (int rowList in intArray)
            {
                var NewItem = list.Where(x => x.Contact_ID.Equals(rowList));
                myAL.Add(NewItem);
            }
            listView.ItemsSource = myAL;
        }
    }
}
