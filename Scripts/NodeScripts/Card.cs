using Godot;
using System;

namespace Card;
public class Card
{
    public int Id;
    public string Name{get;}
    public int Hp;
    public int Atk;
    public Array SkillSet;

    public Card(int id)
    {
        var characteristics = new CharacteristicsData();
        Name = characteristics.GetInfo(id);
        Hp = 100;
        Atk = 19;
    }

    public void Attack(Card card)
    {
        card.Hp -= Atk;
    }

}
