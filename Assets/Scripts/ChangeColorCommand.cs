using UnityEngine;
/// <summary>
/// ChangeColorCommand
/// has Execute and Undo methods,
/// they are contract from ICommand interface.
/// 'Execute()' has inside 
/// '_lightbulb.SetRandomColor();'.
/// 'Undo()' has inside
/// '_lightbulb.SetLightColor(_previousColor);'.
/// </summary>
class ChangeColorCommand : ICommand
{
    Lightbulb _lightbulb;
    Color _previousColor;
    public ChangeColorCommand(Lightbulb lightbulb)
    {
        _lightbulb = lightbulb;
        _previousColor = _lightbulb.bulbLight.color;
    }
    public void Execute()
    {
        _lightbulb.SetRandomColor();
    }
    public void Undo()
    {
        _lightbulb.SetLightColor(_previousColor);
    }
}
