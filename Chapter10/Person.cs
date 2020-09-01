using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10 {
    class Person {
        public string FirstName { get; set; } = "いけざわ";
        public string LastName { get; set; } = "りん";

        public string FullName {
            get { return LastName + FirstName; }
        }
        public string GetFullName() {
            return LastName + FirstName;
        }
        
        public string AddTitle(string title = "様") {
            return $"{ LastName}{ FirstName}{ title}";
            
        }
    }
}
