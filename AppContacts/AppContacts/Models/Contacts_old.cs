using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppContacts.Models
{
    public class Contacts : INotifyPropertyChanged
    {
        [PrimaryKey] [AutoIncrement]
        public int Contact_ID { get; set; }
        public string Contact_Name { get; set; }
        public string Contact_Address { get; set; }
        public string Contact_eMail { get; set; }
        public string Contact_Mobile { get; set; }
        public string Contact_DOB { get; set; }
        public string Contact_Designation { get; set; }
        public string Contact_Method { get; set; }
        public string Value { get; set; }
        public int Key { get; set; }
        public string ContactText { get; set;}

        public event PropertyChangedEventHandler PropertyChanged;

        private bool addressVisible;
        public bool Address_Visible
        {
            set
            {
                if (addressVisible != value)
                {
                    addressVisible = value;
                    OnPropertyChanged("Address_Visible");
                }
            }
            get
            {
                return addressVisible;
            }
        }

        private bool eMailVisible;
        public bool Email_Visible
        {
            set
            {
                if (eMailVisible != value)
                {
                    eMailVisible = value;
                    OnPropertyChanged("Email_Visible");
                }
            }
            get
            {
                return eMailVisible;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

