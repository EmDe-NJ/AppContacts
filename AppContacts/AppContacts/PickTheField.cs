using AppContacts.Models;
using System.Collections.Generic;

namespace AppContacts
{
    public class PickTheField
    {
        public static List<FieldItem> GetField()
        {
            var _fieldName = new List<FieldItem>()
            {
                new FieldItem() { Field_ID = 1, Field_Title = "Contact_Address" },
                new FieldItem() { Field_ID = 2, Field_Title = "Contact_eMail" },
            };
            return _fieldName;
        }
    }

}
