using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AppContacts.ViewModels
{
public class LikeCountModel : INotifyPropertyChanged
    {
        private int _likeCount;

        public int LikeCount
        {
            get => _likeCount;
            set => SetField(ref _likeCount, value);
        }

        public LikeCountModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }
}
