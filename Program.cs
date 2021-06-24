using System;

namespace Slotkin_ConstructorChainingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student molly = new Student("Molly Cat", 1234);

            Console.WriteLine("molly's Id Number: {0}", molly.GetIdNumber());
            Console.WriteLine("molly's Name: {0}", molly.GetName());

            Student bella = new Student("Bella");

            Console.WriteLine("bella’s Id Number: {0}", bella.GetIdNumber());
            Console.WriteLine("bella’s Name: {0}", bella.GetName());

            Student kitKat = new Student("KitKat");

            Console.WriteLine("kitKat’s Id Number: {0}", kitKat.GetIdNumber());
            Console.WriteLine("kitKat’s Name: {0}", kitKat.GetName());
        }
    }
}
