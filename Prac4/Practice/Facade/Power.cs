using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Power
    {
        public event EventHandler powerevent;
        private int _power;
        public int MicrowavePower
        {
            get { return _power; }
            set
            {
                _power = value;
                if (powerevent != null) powerevent(this, new EventArgs());
            }
        }
        public override string ToString() 
        { 
            string s = String.Format("Задана мощность {0}w ", MicrowavePower); 
            return s;
        }
    }
}
