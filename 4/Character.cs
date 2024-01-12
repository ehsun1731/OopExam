

public class Character
{
    public Character(string name, int power)
    {
        Name = name;
        Power = power;

    }
    public string Name { get; set; }
    public int Power { get; set; }


    public virtual void DisplayInfo()
    {
    }
    
}


public class Hero : Character
{
    public Hero(string name, int power, int speed) : base(name, power)

    {
        Speed = speed;
    }


    public int Speed { get; set; }

   
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Hero:  Name: {Name}, Power: {Power}, Speed: {Speed}");
    }
}


public class Enemy : Character
{
    public string Weapon { get; set; }

    
    public Enemy(string name, int power,string weapon): base(name, power)
    {   
        Weapon = weapon;
    }

   
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Enemy:  Name: {Name}, Power: {Power}, Weapon: {Weapon}");
    }
}


public class NPC : Character
{
    public string Element { get; set; }


    public NPC(string name, int power,string element): base(name, power)
        
    {
        Element = element;
    }

   
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"NPC:  Name: {Name}, Power: {Power}, Element: {Element}");
    }
}