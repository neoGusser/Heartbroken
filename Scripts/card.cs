using Godot;
using System;

namespace Card;
public class Card
{
    private int Id;
    private string Name;
    private int Hp;
    private Array SkillSet;
    private Sprite2D Sprite { get; }
    private bool CardIsBroken;

    public Card(int id, Array skillSet, Vector2 pos = new Vector2())
    {
        Id = id;

        var characteristics = new CharacteristicsData();
        Name = characteristics.GetInfo(id);
        Hp = 100;
        SkillSet = skillSet;

        Sprite = new Sprite2D();
        Sprite.Texture = (Texture2D)GD.Load("res://Sprites/card.png");
        Sprite.Position = pos;
    }

    public void Attack(int damage, Card card)
    {
        card.Hp -= damage;
    }

    public void CheckIfCardIsBroken()
    {
        CardIsBroken = Hp <= 0;
    }

}
