// ■リスト14-4：ポリモーフィズムを利用するための基底クラス（VirtualPetクラス）
class VirtualPet
{
    public string Name { get; private set; }
    public int Mood { get; set; }
    public int Energy { get; set; }
    // コンストラクター
    public VirtualPet(string name)
    {
        Name = name;
        Mood = 5;
        Energy = 100;
    }

    public virtual void Eat()  // virtualキーワードを使っている
    {  // 中身が空っぽのメソッドを定義
    }

    public virtual void Play()
    {
    }

    public virtual void Sleep()
    {
    }
}
