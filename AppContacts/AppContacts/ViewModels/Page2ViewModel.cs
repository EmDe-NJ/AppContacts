using AppContacts.Models;
using AppContacts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppContacts.ViewModels
{
    public class Page2ViewModel : BaseViewModel
    {
        public List<Contacts> ListContacts
        {
            get;
            set;
        }
        public Page2ViewModel()
        {
            ListContacts = FieldPicker.GetContacts().OrderBy(c => c.Value).ToList();
        }
        private Contacts _selectedContact;
        public Contacts SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                SetProperty(ref _selectedContact, value);
                //put here your code  
                ContactText =  _selectedContact.Value; //"Contacts : " +
            }
        }
        private string _contactText;
        public string ContactText
        {
            get
            {
                return _contactText;
            }
            set
            {
                SetProperty(ref _contactText, value);
            }
        }
    }
}



