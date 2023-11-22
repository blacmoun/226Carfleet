using System.Collections.Generic;

namespace Carfleet
{
    public class Driver:Person
    {
        #region private attributes
        private string _workZone;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string workZone, List<string> languages = null) : base(name, firstname, phonenumber, emailaddress, languages)
        {
            WorkZone = workZone;
        }
        public string WorkZone { get => _workZone; set => _workZone = value; }
        #endregion public methods
    }
}
