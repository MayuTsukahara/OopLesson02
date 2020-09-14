using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12 {
    class Program {

        static void Main(string[] args) {
            #region List
            //var lines = new List<string> { 
            //    "おはにゃん","こんばんわん","にゃーはお"
            //};
            ////追加
            //lines.Add("おやすみんみんぜみ");
            //lines.Add("さよおならっぶー");
            ////削除
            //lines.RemoveAt(3);

            //foreach (var line in lines) {
            //    Console.WriteLine(line);

            //}
            ////全要素削除
            //lines.Clear();
            //Console.WriteLine($"リストの要素数は{lines.Count}です。");
            #endregion

            #region book
            //var books = new List<Book>();


            //books.Add(new Book("人間失格", "太宰治", 212, 5));
            //books.Add(new Book("女生徒", "太宰治", 279, 4));
            //books.Add(new Book("吾輩は猫である", "夏目漱石", 610, 4));
            //books.Add(new Book("こゝろ", "夏目漱石", 378, 5));
            //books.Add(new Book("銀河鉄道の夜", "宮沢賢治", 357, 3));
            //books.Add(new Book("伊豆の踊子", "川端康成", 201, 3));

            ////var query = books.Where(x => x.Rating >= 4);
            ////var query = books.Select(x=> x.Title);
            ////var query = books.Select(x => x.Title.Length);
            //var query = books.OrderBy(x => x.Title);

            ////foreach (var book in query) {
            ////    Console.WriteLine($"{book.Title}  {book.Author}  {book.Rating}");

            ////}
            //foreach (var book in query) {
            //    Console.WriteLine($"{book.Title}  {book.Author}  {book.Rating}");

            //}
            ////var words = new List<string> { 
            ////    "effect","access","condition","sign","profit","line","result"
            ////};

            ////var query = words.Where(x=> x.Length == 6);

            ////foreach (var word in query) {
            ////    Console.WriteLine(word);
            //}

            //var nums = new List<int> { 12,56,75,8,12,95,32,85,24,49};
            //var query = nums.Where(x => x%2 == 0);
            //foreach (var n in query) {
            //    Console.WriteLine(n);
            //}
            #endregion

            var nums = new List<int> { 2,5,1,3,6,4,7,9,8};
            //var query = nums.OrderBy(x=>x);
            var query = nums.Select(x => x*3).Where(x=>x>=20).Sum();
            Console.WriteLine(query);
            //foreach (var num in query) {
            //    Console.WriteLine(num);
            //}
        }
    }
}
