using AppContacts.Models;
using AppContacts.SQLiteDb;
using Newtonsoft.Json;
using SQLite;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Essentials;
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
            MyArrayData dataArray = new MyArrayData()
            {
                IntArray = new List<int>() {10, 13, 14, 18 },
                StringArray = new List<string>() {"Barbie Doll", "Mickey Mouse", "Donald Duck"}
            };
            string jsonString = JsonConvert.SerializeObject(dataArray);
            Preferences.Set("list", jsonString);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            string dateJason = Preferences.Get("list", "");
            MyArrayData myArrayData = JsonConvert.DeserializeObject<MyArrayData>(dateJason);
            var intArray = myArrayData.IntArray;
            //var stringArray = myArrayData.StringArray;




            //int[] intArray;
            //intArray = new int[4];
            //intArray[0] = 13;
            //intArray[1] = 14;
            //intArray[2] = 18;
            //intArray[3] = 21;

            var my_list = _connection.Table<Contacts>().ToListAsync().Result;
            var myAL = new ArrayList();
            //foreach (int rowList in intArray)
            //{
            //    var NewItem = list.Where(x => x.Contact_ID.Equals(rowList));
            //    myAL.Add(NewItem.FirstOrDefault());
            //}
            foreach (int rowList in intArray)
            {
                foreach (var newitem in my_list)
                {
                    if (newitem.Contact_ID == rowList)
                    {
                        myAL.Add(newitem);
                    }
                }
            }
            listView.ItemsSource = myAL;
        }
    }

}
