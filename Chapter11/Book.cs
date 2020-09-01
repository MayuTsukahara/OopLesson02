// ■リスト7-1：クラスの定義
using System;

namespace Chapter11
{
    

    class Book  // Bookクラスの定義
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        private static Book GetBook() {
            var line = Console.ReadLine();
            var items = line.Split(',');  // Splitメソッドについてはp.254参照
            if (items.Length != 2) {
                return null;  // 入力したデータが正しくない場合はnullを返す
            }
            var book = new Book {
                Title = items[0],
                Author = items[1],
            };
            return book;
        }
    }
}
