using Godot;

public partial class Game : Control
{

    private AudioStreamPlayer soundPlayer;
    private Button backButton;

    public override void _Ready()
    {
        soundPlayer = GetNode<AudioStreamPlayer>("buttonPressed");
        backButton = GetNode<Button>("Back");

        var backButtonHandler = new ButtonHandler(soundPlayer, () => GetTree().ChangeSceneToFile("res://Scenes/menu.tscn"));
        backButton.Pressed += backButtonHandler.HandleButtonPress;
    }
}
