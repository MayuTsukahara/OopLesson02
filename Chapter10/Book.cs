using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10 {
    class Book {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
        public void Print() {
            Console.WriteLine($"■{this.Title}");
            Console.WriteLine($"{this.Author}　{this.Pages}ページ　評価：{this.Rating}");
        }
    }
}
