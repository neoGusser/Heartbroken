using Godot;
using System;
using System.Threading.Tasks;

public class ButtonHandler
{
    private readonly AudioStreamPlayer soundPlayer;
    private readonly string scenePath;
    private readonly Action onButtonPressed;

    public ButtonHandler(AudioStreamPlayer soundPlayer, string scenePath, Action onButtonPressed)
    {
        this.soundPlayer = soundPlayer;
        this.scenePath = scenePath;
        this.onButtonPressed = onButtonPressed;
    }

    public async void HandleButtonPress()
    {
        soundPlayer.Play();
        await WaitForSoundToFinish();
        onButtonPressed();
    }

    private async Task WaitForSoundToFinish()
    {
        while (soundPlayer.Playing)
        {
            await Task.Delay(200); 
        }
    }
}
