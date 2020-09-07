// ■リスト14-5：ポリモーフィズムを利用するための派生クラス（FoodiePetクラス）
using System;

class FoodiePet : VirtualPet  // VirtualPetクラスを継承
{
    //コンストラクタ（親クラスのコンストラクタに名前を渡す）
    public FoodiePet(string name):base (name){

    }
    public override void Eat()  // overrideを使って上書き定義
    {
        Mood += 3;
        Energy += 5;
        Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
    }

    public override void Play()  // overrideを使って上書き定義
    {
        Mood -= 1;
        Energy -= 10;
        Console.WriteLine("FoodiePet.Playメソッドが実行されました");
    }

    public override void Sleep()  // overrideを使って上書き定義
    {
        Mood -= 1;
        Energy += 2;
        Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
    }
}
