using Godot;

public partial class GamePlayerDesk : Control
{
    private PackedScene uiCard;

    public override void _Ready()
    {
        uiCard = GD.Load<PackedScene>("res://Nodes/ui_card.tscn");

        if (uiCard != null)
        {
            for (int i = 0; i < 3; i++)
            {
                Node uiCardInstance = uiCard.Instantiate();

                AddChild(uiCardInstance);
            }
        }
        else
        {
            GD.PrintErr("Failed to load ui_card scene.");
        }
    }
}
