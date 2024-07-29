using Godot;
using System;
using System.Threading.Tasks;

public class ButtonHandler
{
    private readonly AudioStreamPlayer soundPlayer;
    private readonly Action onButtonPressed;

    public ButtonHandler(AudioStreamPlayer soundPlayer, Action onButtonPressed)
    {
        this.soundPlayer = soundPlayer;
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
            await Task.Delay(100); 
        }
    }
}
