using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13 {
    class Program {
        static void Main(string[] args) {
            //Person[] persons = new Person[3];
            var persons = new List<Person>();
            persons.Add( new Employee {
                Number = 440,                       //従業員クラス(子クラス)のメンバ
                FirstName = "りん",                 //Personクラス(親クラス)のメンバ
                LastName = "おくざわわ",            //Personクラス(親クラス)のメンバ
                Email = "440RinChanKawaii@papipapipapiyon.co.jp",
                HireDate = new DateTime(2001,1,14),  //従業員クラス(子クラス)のメンバ
                BirthDay = new DateTime(2001,1,14)
            });
            //persons[0].Print();   //親クラスにあるメソッド

            persons.Add(new Customer { 
                Id = "4440",
                FirstName = "よちの",
                LastName = "つかはら",
                CreditCardNumber = "440-440-44444444440",
                Rank = 1
            });
            //persons[1].Print();

            persons.Add(new Customer {
                Id = "4540",
                FirstName = "まゆ",
                LastName = "つかはら",
                CreditCardNumber = "55555555555555555555555",
                Rank = 1
            });
            //persons[2].Print();

            foreach (var person in persons) {
                Console.WriteLine( person.ToString());
            }

        }
    }
}
