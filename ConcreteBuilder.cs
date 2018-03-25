using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___Builder_Pattern
{

    //Concrete classes that will create the complex product
    //This will keep track of what product it has created 

    class AndroidPhoneBuilder : IPhoneBuilder
    {
        MobilePhone phone;

        public AndroidPhoneBuilder()
        {
            phone = new MobilePhone("Android Phone");
        }

        public void BuildScreen()
        {
            phone.PhoneScreen = ScreenType.ScreenType_Touch_Resistive;
        }

        public void BuildBattery()
        {
            phone.PhoneBattery = Battery.MAH_1500;
        }

        public void BuildOS()
        {
            phone.PhoneOS = OperatingSystem.Android;
        }

        public void BuildStylus()
        {
            phone.PhoneStylus = Stylus.No;
        }

        public MobilePhone Phone
        {
            get { return phone; }
        }
    }

    class WindowsPhoneBuilder : IPhoneBuilder
    {
        MobilePhone phone;

        public WindowsPhoneBuilder()
        {
            phone = new MobilePhone("Windows Phone");
        }

        public void BuildScreen()
        {
            phone.PhoneScreen = ScreenType.ScreenType_TouchScreenCapacitive;
        }

        public void BuildBattery()
        {
            phone.PhoneBattery = Battery.MAH_2000;
        }

        public void BuildOS()
        {
            phone.PhoneOS = OperatingSystem.Windows;
        }

        public void BuildStylus()
        {
            phone.PhoneStylus = Stylus.Yes;
        }

        public MobilePhone Phone
        {
            get { return phone; }
        }
    }
}
