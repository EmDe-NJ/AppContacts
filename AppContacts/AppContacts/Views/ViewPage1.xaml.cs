using AppContacts.Models;
using AppContacts.SQLiteDb;
using SQLite;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppContacts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewPage1 : ContentPage, INotifyPropertyChanged
    {
        public ObservableCollection<Contacts> List_items { get; set; }
        private Boolean _selecteda;
        public Boolean Selecteda
        {
            get { return _selecteda; }
            set
            {
                _selecteda = value;
                RaisePropertyChanged("Selecteda");
            }
        }
        private Boolean _selectedm;
        public Boolean Selectedm
        {
            get { return _selectedm; }
            set
            {
                _selectedm = value;
                RaisePropertyChanged("Selectedm");
            }
        }
        public ViewPage1()
        {
            this.BindingContext = this;

            InitializeComponent();

            List_items = new ObservableCollection<Contacts>();

            for (int i = 0; i < 20; i++)
            {
                Contacts contact = new Contacts()
                {
                    Contact_ID = i,
                    Contact_Name = "cherry " + i,
                    Contact_Address = "the street " + i,
                    Contact_eMail = "cherry@outlook.com " + i
                };
                List_items.Add(contact);
            }


        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Choose_SelectedIndexChange(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex == 0)
            {
                Selecteda = true;
                Selectedm = false;
            }
            else
            {
                Selecteda = false;
                Selectedm = true;
            }
        }
    }
}