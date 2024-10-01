using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyclopdia
{
    class Frined : Person
    {
        public enum Friendship
        {
            brothers,
            listner,
            fun,
            school,
            favorites
        }
        public int fromyear { get; set; }
        public Friendship friendship { get; set; }
        

        public Frined (string fname,string lastname,Friendship friendship)
        {
            this.FName= fname;
            this.LName= lastname;
            this.friendship = friendship;
        }

        public override string Persondata()
        {
            string persondata = @""" infoabstractclassinfo
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
            return persondata;
        }

        public void Friendfromyear(int Fromyear)
        {
            int friendfromyear=DateTime.Now.Year - Fromyear;
            Console.WriteLine($"we are friends {friendfromyear}  friends.Yahlaaa ");
        }
        public void infoclassfriend()
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
