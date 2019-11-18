using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<string> intGenericClass = new MyGenericClass<string>("10");
            string val = intGenericClass.genericMethod("HOLA");
            //Console.WriteLine(val);
        }
    }
    class MyGenericClass<T> {

        public T genericProperty { get; set; }
        private T genericMemberVariable;
        public MyGenericClass(T value) {
            genericMemberVariable = value;    
        }
        public T genericMethod(T genericParameter) {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }
    }
}
