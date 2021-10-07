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

        private float _temperatureMin;
        private float _socMin;

        private float _temperatureMax;
        private float _socMax;
        private float _chargeRateMax;

        internal float Temperature
        {
            get => _temperature; 
            set => _temperature = value;
        }

        internal float TemperatureMin
        {
            get => _temperatureMin;
            set => _temperatureMin = value;
        }

        internal float TemperatureMax
        {
            get => _temperatureMax;
            set => _temperatureMax = value;
        }
        internal float Soc
        {
            get => _soc;
            set => _soc = value;
        }
        internal float SocMax
        {
            get => _socMax;
            set => _socMax = value;
        }
        internal float SocMin
        {
            get => _socMin;
            set => _socMin = value;
        }
      
        internal float ChargeRate
        {
            get => _chargeRate; 
            set => _chargeRate = value; 
        }
        
        internal float ChargeRateMax
        {
            get => _chargeRateMax;
            set => _chargeRateMax = value;
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
            if (temperature < _temperatureMin || temperature > _temperatureMax)
            {
                return false;
            }
            return true;
        }

        private bool IsSOCIsInRange(float soc)
        {
            if (soc < _socMin || soc > _socMax)
            {
                return false;
            }
            return true;
        }

        private bool IsChargeRateIsInRange(float chargeRate)
        {
            if (chargeRate > _chargeRateMax)
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            return true;
        }
    }
}
