using System.Collections.Generic;
using System.IO.Pipes;
using System.Threading;

namespace Carfleet
{
    public class Person
    {
        #region private attributes
        private string _name;
        private string _firstname;
        private string _phonenumber;
        private string _emailaddress;
        private List<string> _languages;
        #endregion private attributes

        #region public methods
        public Person(string name, string firstname, string phonenumber, string emailaddress, List<string> languages = null)
        {
            Name = name;
            Firstname = firstname;
            Phonenumber = phonenumber;
            Emailaddress = emailaddress;
            Languages = languages;
        }

        public string Name { get => _name; set => _name = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Phonenumber { get => _phonenumber; set => _phonenumber = value; }
        public string Emailaddress { get => _emailaddress; set => _emailaddress = value; }
        public List<string> Languages
        {
            get
            {
                return _languages;
            }
            set
            {
                _languages = value;
            }
        }
        #endregion public methods
    }
}
