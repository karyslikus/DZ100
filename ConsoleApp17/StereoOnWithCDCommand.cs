public class StereoOnWithCDCommand : ICommand
{
    private Stereo _stereo;
    private int _volume;

    public StereoOnWithCDCommand(Stereo stereo, int volume = 10)
    {
        _stereo = stereo;
        _volume = volume;
    }

    public void Execute()
    {
        _stereo.TurnOn();
        _stereo.SetCD();
        _stereo.SetVolume(_volume);
    }
}