using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13 {
    class Employee :Person {
        //従業員番号
        public int Number { get; set; }
        //入社生年月日
        public DateTime HireDate { get; set; }
        public DateTime BirthDay { get; set; }

        public override void Print() {
            Console.WriteLine($"{Number}:{FullName}({Email}){HireDate.Year}年入社");
        }

        public override string ToString() {
            return $"{Number}:{FullName}({Email}){HireDate.Year}年入社,{BirthDay}生まれ";
        }
    }
}
