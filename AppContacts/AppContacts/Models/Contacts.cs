using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContacts.Models
{
    public class Contacts
    {
        [PrimaryKey][AutoIncrement]
        public int Contact_ID { get; set; }
        public string Contact_Name { get; set; }
        public string Contact_Address { get; set; }
        public string Contact_eMail { get; set; }
    }
}
