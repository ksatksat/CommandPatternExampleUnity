/// <summary>
/// ICommand interface has two methods to implement
/// 'Execute()' and 'Undo()'
/// </summary>
interface ICommand
{
    void Execute();
    void Undo();
}
