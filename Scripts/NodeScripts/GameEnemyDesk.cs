using Godot;
using System;
using System.Collections.Generic;

public partial class GameEnemyDesk : Control
{
    private PackedScene uiCard;
    private List<int> playerAllies = new List<int> { 1, 2, 3 };
    private Random random = new Random();

    public override void _Ready()
    {
        uiCard = GD.Load<PackedScene>("res://Nodes/ui_card.tscn");

        if (uiCard != null)
        {
            for (int i = 0; i < 3; i++)
            {
                Node uiCardInstance = uiCard.Instantiate();

                AddChild(uiCardInstance);

                var cardState = uiCardInstance.GetNode<Card.CardState>("CardSM");

                cardState.Initialize(random.Next(1, 4));
            }
        }
    }
}