using UnityEngine;
/// <summary>
/// UserInput
/// is class where Update event is checks
/// inputs like 'space', 'c', and 'z' buttons press.
/// If 'space' buuton pressed
/// 'ICommand togglePowerCommand = new TogglePowerCommand(_lightbulb);
/// _lightApp.AddCommand(togglePowerCommand);'
/// If 'c' button pressed
/// 'ICommand changeColorCommand = new ChangeColorCommand(_lightbulb);
/// _lightApp.AddCommand(changeColorCommand);'
/// If 'z' button pressed
/// '_lightApp.UndoCommand();'
/// </summary>
public class UserInput : MonoBehaviour
{
    public Lightbulb _lightbulb;
    /// <summary>
    /// LightApp
    /// It has method 'AddCommand(ICommand newCommand)'.
    /// It is at first place calls 'newCommand.Execute()'
    /// After that it is adds 'newCommand' into 
    /// 'Stack<ICommand> _commandList' list.
    /// Method 'UndoCommand()' it is takes last class from the list
    /// 'ICommand latestCommand = _commandList.Pop()'
    /// then it calls Undo method to it 'latestCommand.Undo()'
    /// </summary>
    LightApp _lightApp;
    private void Start()
    {
        _lightApp = new LightApp();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ICommand togglePowerCommand = 
                new TogglePowerCommand(_lightbulb);
            _lightApp.AddCommand(togglePowerCommand);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            ICommand changeColorCommand = 
                new ChangeColorCommand(_lightbulb);
            _lightApp.AddCommand(changeColorCommand);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            _lightApp.UndoCommand();
        }
    }
}
