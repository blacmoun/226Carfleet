using NUnit.Framework;
using System.Collections.Generic;

namespace Carfleet
{
    public class TestPerson
    {
        #region private attributes
        private string _name = "Einstein";
        private string _firstname = "Albert";
        private string _phonenumber = "+41793456789";
        private string _emailaddress = "ae@relativity.org";
        private List<string> _languages = new List<string>();
        private Person _person;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _person = new Person(_name, _firstname, _phonenumber, _emailaddress, _languages);
        }

        [Test]
        public void AllProperties_AfterInstantiation_GetCorrectValues()
        {
            //given

            //when

            //then
            Assert.AreEqual(_name, _person.Name);
            Assert.AreEqual(_firstname, _person.Firstname);
            Assert.AreEqual(_phonenumber, _person.Phonenumber);
            Assert.AreEqual(_emailaddress, _person.Emailaddress);
            Assert.AreEqual(_languages, _person.Languages);
        }
    }
}