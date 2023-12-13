﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Carfleet
{
    public class Driver:Person
    {
        #region private attributes
        private string _workZone;
        private Vehicle _vehicle = null;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string workZone, List<string> languages = null) : base(name, firstname, phonenumber, emailaddress, languages)
        {
            WorkZone = workZone;
        }
        public string WorkZone { get => _workZone; set => _workZone = value; }
        public Vehicle Vehicle
        {
            get
            {
                return _vehicle;
            }
        }

        public void TakeAVehicle(Vehicle vehicle)
        {
            if(_vehicle != null)
            {
                throw new VehicleAlreadyAssignedException();
            }
            _vehicle = vehicle;
        }

        public void ReleaseAVehicle()
        {
            if (_vehicle == null)
            {
                throw new NoVehicleAssignedException();
            }
            _vehicle = null;
        }
        #endregion public methods

        #region embedded classes
        public class DriverException : Exception { }
        public class VehicleAlreadyAssignedException : DriverException { }
        public class NoVehicleAssignedException : DriverException { }
        #endregion embedded classes
    }
}
