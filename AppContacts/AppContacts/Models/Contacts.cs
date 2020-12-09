using AppContacts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContacts.Models
{
    public class Contacts : BaseViewModel
    {
        public int Contact_ID { get; set; }
        public string Contact_Name { get; set; }

        // public string Contact_Address { get; set; }
        private string _contact_Address;
        public string Contact_Address
        {
            get
            {
                return _contact_Address;
            }
            set
            {
                SetProperty(ref _contact_Address, value);
            }
        }


        //  public string Contact_eMail { get; set; }
        private string _contact_eMail;
        public string Contact_eMail
        {
            get
            {
                return _contact_eMail;
            }
            set
            {
                SetProperty(ref _contact_eMail, value);
            }
        }


        //public string Contact_Mobile { get; set; }
        private string _contact_Mobile;
        public string Contact_Mobile
        {
            get
            {
                return _contact_Mobile;
            }
            set
            {
                SetProperty(ref _contact_Mobile, value);
            }
        }



        public string Contact_DOB { get; set; }
        public string Contact_Designation { get; set; }
        public string Contact_JoiningDate { get; set; }
        public string Contact_MaritalStatus { get; set; }
        public string Contact_Method { get; set; }
        public string Value { get; set; }
        public int Key { get; set; }
        //  public string ContactText { get; set; }

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
