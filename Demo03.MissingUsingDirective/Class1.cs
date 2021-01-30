using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Demo03.MissingUsingDirective
{
    public class Class1
    {
        public void Mehtod1()
        {
            Regex ex = new Regex("");
            var s = new StringBuilder();
        }

        public void Hello()
        {
            Console.WriteLine("Hello BuriKaigi 2021");
        }
    }
}
