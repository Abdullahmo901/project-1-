using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyclopdia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Frined myF1 = new Frined("Ahmed","hashem",Frined.Friendship.school);

            myF1.Email = "abdjanjn@.com";
            myF1.Telephone = "01063188954";
            myF1.Adress = "cairo";
            myF1.fromyear = 2010;
            myF1.fullName();
            myF1.Friendfromyear(myF1.fromyear);
            Console.WriteLine(myF1.Persondata());
            Console.ReadLine();

        }
    }
}
