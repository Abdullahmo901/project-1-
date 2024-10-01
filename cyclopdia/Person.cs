using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyclopdia
{
    abstract class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Adress { get; set; }


        public void fullName()
        {
            Console.WriteLine($"the full name is {FName} {LName} ");
        }
        public abstract string Persondata();
        public static void InfoAbstractClassMethode()
        {
            string infoclassperson = @""" infoabstractclassinfo
                                 field 
                                firstname
                                   lastname
                                     E-mail
                                      Telephone
                                      Address
                                      Methode
                            fullname - print full name (firstname + lastname)
                                 persondata: abstract methode
                     infoAbstractClassPerson   : static methode print info person 
                          ************************************""";
            Console.WriteLine(infoclassperson);
        }
        
    }

}
