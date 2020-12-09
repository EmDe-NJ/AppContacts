using System.ComponentModel;

namespace AppContacts.ViewModels
{
    class frmFoo : INotifyPropertyChanged    //class frmFoo : Form, INotifyPropertyChanged
    {
        private string _foo;

        public string Foo
        {
            get { return _foo; }
            set
            {
                _foo = value;
                OnPropertyChanged("Foo");
            }
        }

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
