public class Stereo
{
    public void TurnOn()
    {
        Console.WriteLine("Стереосистема включена.");
    }

    public void SetCD()
    {
        Console.WriteLine("Установлен режим CD.");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Громкость установлена на {volume}.");
    }
}