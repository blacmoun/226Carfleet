using NUnit.Framework;

namespace Carfleet
{
    public class TestTruck
    {
        #region private attributes
        string _registration = "VD 123 567";
        string _brand = "Volvo";
        string _model = "FH16";
        string _chassisNumber = "VOL45-0157966";
        Truck _truck;
        #endregion private attributes


        [SetUp]
        public void Setup()
        {
            _truck = new Truck(_registration, _brand, _model, _chassisNumber);
        }

        [Test]
        public void AllProperties_AfterInstantiation_GetCorrectValues()
        {
            //given

            //when
            
            //then
            Assert.AreEqual(_registration, _truck.Registration);
            Assert.AreEqual(_brand, _truck.Brand);
            Assert.AreEqual(_model, _truck.Model);
            Assert.AreEqual(_chassisNumber, _truck.ChassisNumber);
        }

        [Test]
        public void ToString_AllPropertiesDefaultValue_GetFullString()
        {
            //given
            string expectedString = "VD 123 567 - Volvo - FH16 - VOL45-0157966 - false";

            //when

            //then
            Assert.AreEqual(expectedString, _truck.ToString());
        }

        [Test]
        public void IsCarryingGoods_DefaultValue_GetDefaultValue()
        {
            //given

            //when

            //then
            Assert.IsFalse(_truck.IsCarryingGoods);
        }

        [Test]
        public void IsCarryingGoods_SetToTrue_GetTrue()
        {
            //given

            //when
            _truck.IsCarryingGoods = true;

            //then
            Assert.IsTrue(_truck.IsCarryingGoods);
        }
    }
}