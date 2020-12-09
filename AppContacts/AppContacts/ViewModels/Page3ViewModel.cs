using AppContacts.Models;
using AppContacts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppContacts.ViewModels
{
    public class Page3ViewModel : BaseViewModel
    {
        public List<Contacts> ListContacts
        {
            get;
            set;
        }
        public Page3ViewModel()
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

                // ContactText = _selectedContact.Value; //"Contacts : " +

                RefreshSelectedField(SelectedContact.Value);
            }
        }

        private void RefreshSelectedField(string str)
        {
            foreach (Contacts model in ListContacts)
            {
                model.ContactText = str;
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
