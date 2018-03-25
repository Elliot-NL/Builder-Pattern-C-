using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___Builder_Pattern
{
    //The product is the base object:

    class MobilePhone
    {
        string phoneName;
        ScreenType phoneScreen;
        Battery phoneBattery;
        OperatingSystem phoneOS;
        Stylus phoneStylus;

        public MobilePhone(string name)
        {
            phoneName = name;
        }

        public string PhoneName
        {
            get { return phoneName; }
        }

        public ScreenType PhoneScreen
        {
            get { return phoneScreen; }
            set { phoneScreen = value; }
        }

        public Battery PhoneBattery
        {
            get { return phoneBattery; }
            set { phoneBattery = value; }
        }

        public OperatingSystem PhoneOS
        {
            get { return phoneOS; }
            set { phoneOS = value; }
        }

        public Stylus PhoneStylus
        {
            get { return phoneStylus; }
            set { phoneStylus = value; }
        }

        public override string ToString()
        {
            return string.Format($"Name: {PhoneName}\nScreen: {PhoneScreen}\nBattery: {PhoneBattery}\nOS: {PhoneOS}\nStylus: {PhoneStylus}");
        }
    }
}
