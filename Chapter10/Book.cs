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
        //public int Rating { get; set; }
        int _rating; //フィールドの定義
        public int Rating { //引数チェックするときはこう書く
            get //getアクセサ
            {
                return _rating;
            }
            set //setアクセサ
            {
                if(value <= 1) {        //1以下
                    _rating = 1;
                }else if (value >= 6) { //6以上
                    _rating = 5;
                } else {                //2～5
                    _rating = value;
                }
            }
        } 
        public void Print() {
            Console.WriteLine($"■{this.Title}");
            Console.WriteLine($"{this.Author}　{this.Pages}ページ　評価：{this.Rating}");
        }
    }
}
