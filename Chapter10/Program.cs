using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10 {
    class Program {
        static void Main(string[] args) {
            #region 省略可能な引数
            var person = new Person() {
                FirstName = "りんちゃん",
                LastName = "ぱぴよん"
            };
            var name1 = person.GetFullName();
            Console.WriteLine(name1);
            #endregion

            #region オブジェクトを返すサンプル
            //var book1 = MakeBookObject();
            //var book2 = MakeBookObject();
            //book1.Print();
            //book2.Print();
            #endregion

            #region GetArrayの呼び出し
            //var nums = GetArray(5);
            ////合計
            //var total = 0;
            //for (int i = 0; i < nums.Length;i++) {
            //    total += nums[i];
            //}
            //Console.WriteLine($"合計:{total}");
            //total = 0;
            //foreach (var i in nums) {
            //    total += nums[i];
            //}
            //Console.WriteLine($"合計:{total}");
            #endregion



        }

        public static int[] GetArray(int count) {
            var array = new int[count];
            for (int i = 0; i < count; i++) {
                var line = Console.ReadLine();
                array[i] = int.Parse(line);
            }
            return array; //配列を返却
        }

        public static Book MakeBookObject() {
            Console.Write("書籍名　⇒　");
            var title = Console.ReadLine();

            Console.Write("著者　⇒　");
            var author = Console.ReadLine();

            Console.Write("ページ数　⇒　");
            var pages = Console.ReadLine();

            Console.Write("５段階評価　⇒　");
            var rating = Console.ReadLine();

            //オブジェクト初期化子を使ったオブジェクトの初期化
            var book = new Book {
                Title = title,
                Author = author,
                Pages = int.Parse(pages),
                Rating = int.Parse(rating)
            };

            return book;
        }
    }
}
