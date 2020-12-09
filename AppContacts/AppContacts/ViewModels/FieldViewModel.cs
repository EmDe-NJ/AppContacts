using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppContacts.ViewModels
{
    public class FieldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        String _displayField;

        public string DisplayField
        {
            set
            {
                if (!value.Equals(_displayField, StringComparison.Ordinal))
                {
                    _displayField = value;
                    OnPropertyChanged("DisplayField");
                }
            }
            get
            {
                return _displayField;
            }
        }

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

