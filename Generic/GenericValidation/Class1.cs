using System;
using System.Collections.Generic;
using System.Text;

namespace GenericValidation
{
    public class GenericValidation<T>
    {
        private T genericMemberVariable;

        public T Validation(T value)
        {
            var o = value.GetType();
            switch (o.Name)
            {
                case "DateTime":
                    Console.WriteLine(o.Name);
                    break;
                case "Int32":
                    Console.WriteLine(o.Name);
                    break;
                default:
                    Console.WriteLine(o.Name);
                    break;
            }
            //genericMemberVariable = value;
            return genericMemberVariable;
        }
    }
}
