using System;

namespace Carfleet{
    public class Vehicle
    {
        #region private attributes
        private string _registration;
        private string _brand;
        private string _model;
        private string _chassisNumber;
        #endregion private attributes

        #region public methods
        public Vehicle(string registration, string brand, string model, string chassisNumber)
        {
            _registration = registration;
            _brand = brand;
            _model = model;
            _chassisNumber = chassisNumber;
        }

        public string Registration
        {
            get
            {
                return _registration;
            }
            set
            {
                _registration = value;
            }
        }

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public string ChassisNumber
        {
            get
            {
                return _chassisNumber;
            }
            set
            {
                _chassisNumber = value;
            }
        }

        public override string ToString()
        {
            return this.Registration + " - " + this.Brand + " - " + this.Model + " - " + this.ChassisNumber;
        }
        #endregion public methods
    }
}
