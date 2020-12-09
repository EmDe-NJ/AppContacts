using AppContacts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContacts.Services
{
    public class FieldPicker
    {
        public static List<Contacts> GetContacts()
        {
            var contacts = new List<Contacts>()
          {
              new Contacts() {Key = 1, Value = "Contact_Address", Contact_Name="Test_Name1",Contact_Address ="address1",Contact_eMail="testemail1@gmail.com",Contact_Mobile="Phone1:111111",ContactText="test1"},
              new Contacts() {Key = 2, Value = "Contact_eMail", Contact_Name="Test_Name2",Contact_Address ="address2",Contact_eMail="testemail2@gmail.com",Contact_Mobile="Phone1:222222",ContactText="test2"},
              new Contacts() {Key = 3, Value = "Contact_Mobile", Contact_Name="Test_Name3",Contact_Address ="address3",Contact_eMail="testemail3@gmail.com",Contact_Mobile="Phone1:333333",ContactText="test3"},
          };
            return contacts;
        }
    }
}
