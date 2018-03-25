using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builder pattern creates concrete implementation
            //Defines an instance for creating an object but 
            //Allows subclasses to decide which class to 
            //Instanciate 
            //Refers to the newly created oject through a 
            //common interface

            Director newManufacturer = new Director();
            //Get Builder Class Ready:
            IPhoneBuilder phoneBuilder = null;

            //Creating an Android Phone using the builder pattern:
            phoneBuilder = new AndroidPhoneBuilder();
            newManufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new phone has been made: \n\n{0}", phoneBuilder.Phone.ToString());

            //Creating a Windows Phone using the builder pattern:
            phoneBuilder = new WindowsPhoneBuilder();
            newManufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new phone has been created: \n\n{0}", phoneBuilder.Phone.ToString());
            Console.ReadLine();

            //Now if we create more Products only a ConcreteBuilder would be needed and the rest of the 
            //CodeBase will remain the same.
        }
    }
}
