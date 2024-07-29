using Godot;
using System;

public partial class Settings : Node
{
	private AudioStreamPlayer soundPlayer;
    private Button backButton;

    private Button locButton;

    public override void _Ready()
    {
        soundPlayer = GetNode<AudioStreamPlayer>("buttonPressed");
        backButton = GetNode<Button>("Back");
        locButton = GetNode<Button>("Loc");

        var backButtonHandler = new ButtonHandler(soundPlayer, () => GetTree().ChangeSceneToFile("res://Scenes/menu.tscn"));
        backButton.Pressed += backButtonHandler.HandleButtonPress;

        var locButtonHandler = new ButtonHandler(soundPlayer, () => LocalLanguage());
        locButton.Pressed += locButtonHandler.HandleButtonPress;
    }

    private void LocalLanguage(){
        string locale = TranslationServer.GetLocale() == "en" ? "ua" : "en";
        TranslationServer.SetLocale(locale);
    }
}
