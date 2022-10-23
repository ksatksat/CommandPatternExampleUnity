/// <summary>
/// this class is inherited from ICommand
/// it implements two methods called 'Execute'
/// and 'Undo' both of them calls '_lightbulb.TogglePower();'
/// </summary>
public class TogglePowerCommand : ICommand
{
    Lightbulb _lightbulb;
    public TogglePowerCommand(Lightbulb lightbulb)
    {
        _lightbulb = lightbulb;
    }
    public void Execute()
    {
        _lightbulb.TogglePower();
    }
    public void Undo()
    {
        _lightbulb.TogglePower();
    }
}
