using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BMS
{
    internal class Battery
    {
        private float _temperature;
        private float _soc;
        private float _chargeRate;

        internal float Temperature
        {
            get => _temperature; 
            set => _temperature = value;
        }
        internal float Soc
        {
            get => _soc;
            set => _soc = value;
        }

        internal float ChargeRate
        {
            get => _chargeRate; 
            set => _chargeRate = value; 
        }

        public Battery(float temp, float soc, float chargeRate)
        {
            _temperature =temp;
            _soc = soc;
            _chargeRate = chargeRate;
        }

        internal bool BatteryIsOk()
        {
            if (!IsTempInRange(_temperature))
            {
                Console.WriteLine("Temperature is out of range!");
                return false;
            }
            else if (!IsSOCIsInRange(_soc))
            {
                Console.WriteLine("State of Charge is out of range!");
                return false;
            }
            else if (!IsChargeRateIsInRange(_chargeRate))
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            return true;
        }

        private bool IsTempInRange(float temperature)
        {
            if (temperature < 0 || temperature > 45)
            {
                return false;
            }
            return true;
        }

        private bool IsSOCIsInRange(float soc)
        {
            if (soc < 20 || soc > 80)
            {
                return false;
            }
            return true;
        }

        private bool IsChargeRateIsInRange(float chargeRate)
        {
            if (chargeRate > 0.8)
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            return true;
        }
    }
}
