using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {
            
                
            
            //height = double.Parse(Console.ReadLine());
            double height, weight;
            string line;
            
            //変換したlineをheightという器に入れる
            while (true) {
                Console.Write("身長(cm):");
                line = Console.ReadLine();
                if (double.TryParse(line, out height)) break;  
                
                Console.WriteLine("正しい値を入力してください");
            }
            if (!double.TryParse(line, out height)) {
                Console.WriteLine("正しい値を入力してください");
            }

            Console.Write("体重(kg):");
            //weight = double.Parse(Console.ReadLine());
            if (!double.TryParse(line, out weight)) {
                Console.WriteLine("変換エラー(身長を170cmにします)");
                weight = 170;
            }


            var bmi = new BmiCalculator();
                
            //:F1で小数点第一位まで出力される
            Console.WriteLine($"BMIは{bmi.GetBmi(height,weight):F1}です");
  
        }
    }
}
