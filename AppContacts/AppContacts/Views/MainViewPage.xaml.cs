using AppContacts.Models;
using AppContacts.SQLiteDb;
using AppContacts.ViewModels;
using SQLite;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppContacts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainViewPage : ContentPage
    {
        readonly SQLiteAsyncConnection _connection = DependencyService.Get<ISQLite>().GetConnection();
        private string myStringProperty;
        private readonly BaseViewModel _baseViewModel;

        public string MyStringProperty
        {
            get { return myStringProperty; }
            set
            {
                myStringProperty = value;
                OnPropertyChanged(nameof(MyStringProperty)); // Notify that there was a change on this property
            }
        }
        public MainViewPage()
        {
            InitializeComponent();
            //BindingContext = this;
            BindingContext = new BaseViewModel();
             _baseViewModel = new BaseViewModel();
            var _selectedItem = _baseViewModel;
            MyStringProperty = "New label text"; // It will be shown at your label
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _connection.CreateTableAsync<Contacts>();

            var list = _connection.Table<Contacts>().ToListAsync().Result;
            CList = new ObservableCollection<Contacts>(list);
            listView.ItemsSource = CList;
        }
        public ObservableCollection<Contacts> CList { get; set; }

    }
}