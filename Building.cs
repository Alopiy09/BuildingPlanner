using System;
using System.Collections.Generic;

namespace planner {
    public class Building {
        private string _designer {get; set;}

        private DateTime _dateConstructed {get; set;}

        private string _address {get; set;}

        private string _owner {get; set;}

        public int Stories {get; set;}

        public double Width {get; set;}

        public double Height {get; set;}

        public int Volume {get;}

        public string address(string address) {
          _address = address;
        }
        

        public DateTime construct() {
            _dateConstructed = DateTime.Now;
        }

        public string purchase(string name) {
            _owner = name;
        }

    }
}