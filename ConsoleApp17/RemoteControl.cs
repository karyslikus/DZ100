public class RemoteControl
{
    private ICommand _buttonCommand;

    public void SetCommand(ICommand command)
    {
        _buttonCommand = command;
    }

    public void PressButton()
    {
        Console.WriteLine("Нажимаем кнопку...");
        _buttonCommand.Execute();
    }
}