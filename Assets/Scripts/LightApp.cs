using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// It has method 'AddCommand(ICommand newCommand)'.
/// It is at first place calls 'newCommand.Execute()'
/// After that it is adds 'newCommand' into 
/// 'Stack<ICommand> _commandList' list.
/// Method 'UndoCommand()' it is takes last class from the list
/// 'ICommand latestCommand = _commandList.Pop()'
/// then it calls Undo method to it 'latestCommand.Undo()'
/// </summary>
/// /// <param name="LightApp"></param>
class LightApp
{
    //Queie is FIFO - first in first out
    //Stack is LIFO - last in first out
    /*Stack is a special type of collection that stores 
     * elements in LIFO style (Last In First Out). 
     * C# includes the generic Stack<T> and non-generic 
     * Stack collection classes. It is recommended to 
     * use the generic Stack<T> collection.
    Stack is useful to store temporary data in LIFO style, 
    and you might want to delete an element after 
    retrieving its value.*/
    /*Stack<int> myStack = new Stack<int>();
    myStack.Push(1);
    myStack.Push(2);
    myStack.Push(3);
    myStack.Push(4);
    foreach (var item in myStack)
     Console.Write(item + ","); //prints 4,3,2,1, */
    /*Method	Usage
    Push(T)	Inserts an item at the top of the stack.
    Peek()	Returns the top item from the stack.
    Pop()	Removes and returns items from the top of the stack.
    Contains(T)	Checks whether an item exists in the stack or not.
    Clear()	Removes all items from the stack.*/
    Stack<ICommand> _commandList;
    public LightApp()
    {
        _commandList = new Stack<ICommand>();
    }
    public void AddCommand(ICommand newCommand)
    {
        newCommand.Execute();
        _commandList.Push(newCommand);
    }
    public void UndoCommand()
    {
        if (_commandList.Count > 0)
        {
            ICommand latestCommand = _commandList.Pop();
            latestCommand.Undo();
        }
    }
    //I added it to remove all objects
    //inside Stack<ICommand> _commandList;
    // '=>' this is 'expression body method syntax'
    //it is works only if method has one line-row
    //
    //void OnDisable() => _commandList.Clear();
    //it is pretty similar to :
    //void OnDisable()
    //{
    //    _commandList.Clear();
    //}
    void OnDisable() => _commandList.Clear();
}
