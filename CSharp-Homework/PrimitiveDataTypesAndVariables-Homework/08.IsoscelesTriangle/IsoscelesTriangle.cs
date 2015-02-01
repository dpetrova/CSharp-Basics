using System;
using System.Text;

    class IsoscelesTriangle
    {
        static void Main()
        {
            char copyrightSymbol = (char)169;
            string line1 = " " + " " + " " + copyrightSymbol;
            string line2 = " " + " " + copyrightSymbol + " " + copyrightSymbol;
            string line3 = " " + copyrightSymbol + " " + " " + " " + copyrightSymbol;
            string line4 = copyrightSymbol + " " + copyrightSymbol + " " + copyrightSymbol + " " + copyrightSymbol;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0} \n{1} \n{2} \n{3}", line1, line2, line3, line4);
        }
    }
