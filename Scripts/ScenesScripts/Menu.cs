using Godot;

public partial class Menu : Control
{
    private AudioStreamPlayer soundPlayer;
    private Button playButton;
    private Button settingsButton;
    private Button exitButton;

    public override void _Ready()
    {
        soundPlayer = GetNode<AudioStreamPlayer>("buttonPressed");
        playButton = GetNode<Button>("MarginContainer/VBoxContainer/Play");
        settingsButton = GetNode<Button>("MarginContainer/VBoxContainer/Settings");
        exitButton = GetNode<Button>("MarginContainer/VBoxContainer/Exit");

        var playButtonHandler = new ButtonHandler(soundPlayer, () => GetTree().ChangeSceneToFile("res://Scenes/game.tscn"));
        var settingsButtonHandler = new ButtonHandler(soundPlayer, () => GetTree().ChangeSceneToFile("res://Scenes/settings.tscn"));
        var exitButtonHandler = new ButtonHandler(soundPlayer, () => GetTree().Quit());

        playButton.Pressed += playButtonHandler.HandleButtonPress;
        settingsButton.Pressed += settingsButtonHandler.HandleButtonPress;
        exitButton.Pressed += exitButtonHandler.HandleButtonPress;
    }
}
