using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppContacts.ViewModels
{
    public class PageOneViewModel : INotifyPropertyChanged
    {
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
