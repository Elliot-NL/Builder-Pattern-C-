using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___Builder_Pattern
{
    class Director
    {

        //This is the client code that will be used to specify the 
        //required parts for the concrete implementation.

        public void Construct(IPhoneBuilder phonebuilder)
        {
            phonebuilder.BuildBattery();
            phonebuilder.BuildOS();
            phonebuilder.BuildScreen();
            phonebuilder.BuildStylus();
        }

    }
}
