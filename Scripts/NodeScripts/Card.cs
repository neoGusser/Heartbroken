using Godot;
using System;

namespace Card;
public class Card
{
    public int Id;
    public string Name{get;}
    public int Hp;
    public Array SkillSet;

    public Card(int id)
    {
        var characteristics = new CharacteristicsData();
        Name = characteristics.GetInfo(id);
        Hp = 100;
    }

    public void Attack(int damage, Card card)
    {
        card.Hp -= damage;
    }

}
