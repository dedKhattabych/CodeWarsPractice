using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Katas_two
{
    public class Person
    {

        private string name;

        public int Age;
        public string GetName()
        {

            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public void SetAge(int value)
        {
            Age = value;
        }
        public Person()
        {
            name = "Jonh";
            Age = 18;
        }
        public Person(string name)
        {
            this.name = name;

        }
        public virtual void Hello()
        {
            Console.WriteLine("Hello");
        }
        

    }
    public class Orc : Person
    {
       public override void Hello() 
       {
            base.Hello();
            Console.WriteLine("LOG'TAR OGAR!");
            
       }

        public void Sum(int number)
        {
            Console.WriteLine($"YA POSCHITAL ETO {number}");
        }
        public void Sum(int number1, int number2)
        {
            Console.WriteLine($"YA POSCHITAL ETO {number1+number2}");
        }
        public void Sum(string number1, string number2)
        {
            int count1 = Int32.Parse(number1);
            
            int count2 = Int32.Parse(number2);

            Console.WriteLine($"YA POSCHITAL ETO {number1 + number2}");
        }
    }
}
