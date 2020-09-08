// ■リスト14-4：ポリモーフィズムを利用するための基底クラス（VirtualPetクラス）
interface IVirtualPet
{
    //インターフェイスの定義
    string Name { get;  }
    int Mood { get;}
    int Energy { get; }

    void Eat();

    void Play();

    void Sleep();
    void Rest();
 
}
