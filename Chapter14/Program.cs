using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14 {
    class Program {
        static void Main(string[] args) {
            var pets = new List<Object>();

            pets.Add( new FoodiePet("よしの"));
            pets.Add(new CheerfulPet("ふーちゃん"));
            pets.Add(new SleepyPet("りん"));

            //ここのvarをIVirtualPetにする
            foreach (var pet in pets) {

                ((IVirtualPet)pet).Play();
                ((IVirtualPet)pet).Eat();
                ((IVirtualPet)pet).Sleep();
                ((IVirtualPet)pet).Rest();
                Console.WriteLine($"{((IVirtualPet)pet).Name} 機嫌：{((IVirtualPet)pet).Mood} エネルギー：{((IVirtualPet)pet).Energy}");
            }

        }
    }
}
