using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___Builder_Pattern
{
    
    interface IPhoneBuilder
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOS();
        void BuildStylus();
        MobilePhone Phone { get; }
    }
    
    class Builder
    {
        //The builder class specifies an abstract interface
        //for creating parts of a product / service object
        //This is the interface for the actual objects
        //Should provide functions for creating each part
        //Of the product

    }
}
