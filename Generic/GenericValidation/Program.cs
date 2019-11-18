using System;

namespace GenericValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericValidation<DateTime> genericValidation = new GenericValidation<DateTime>();
            genericValidation.Validation(DateTime.Now.Date);

            GenericValidation<int> genericValidationint = new GenericValidation<int>();
            genericValidationint.Validation(100);
            //Console.WriteLine("Hello World!");
        }
    }
}
