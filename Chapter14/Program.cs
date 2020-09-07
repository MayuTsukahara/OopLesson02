using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14 {
    class Program {
        static void Main(string[] args) {
            var pets = new List<VirtualPet>();

            pets.Add( new FoodiePet("よしの"));
            pets.Add(new CheerfulPet("ふーちゃん"));
            pets.Add(new SleepyPet("唐揚げ"));


            foreach (var pet in pets) {
                pet.Play();
                pet.Eat();
                pet.Sleep();
                Console.WriteLine($"{pet.Name} 機嫌：{pet.Mood} エネルギー：{pet.Energy}");
            }

        }
    }
}
