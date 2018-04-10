///**************************************************************************************************************************************************
// *  
// *  FileName    : ClsMain.cs
// *  Description : UndoRedo 클래스
// *  Date        : 2018. 04. 04
// *  Author      : UniBiz_ParkJIyun
// *  ---------------------------------------------------------------------------------------------------------------------------------------------------
// *  History
// * 
// *  
// * ***********************************************************************************************************************************************/

//using System.Collections.Generic;
///// <summary>
///// Undo와 Redo 내역을 기록하는 클래스
///// </summary>
///// <typeparam name="T">기록할 타입</typeparam>
//public class ClsUndoRedo<T>
//{

//    private const int DEFAULT_UNDOCOUNT = 10;
//    private LimitedStack<T> undoStack;
//    private LimitedStack<T> redoStack;



//    /// <summary>
//    /// Undo 기능을 사용할 수 있는지 여부를 가져온다.
//    /// </summary>
//    public bool IsCanUndo
//    {
//        get
//        {
//            //맨 초기 상태때문에 1보다 커야한다.
//            return this.undoStack.Count > 1;
//        }
//    }



//    /// <summary>
//    /// Redo 기능을 사용할 수 있는지 여부를 가져온다.
//    /// </summary>
//    public bool IsCanRedo
//    {
//        get { return this.redoStack.Count > 0; }
//    }

//    public ClsUndoRedo() : this(DEFAULT_UNDOCOUNT)
//    {

//    }

//    public ClsUndoRedo(int defaultUndoCount)
//    {
//        undoStack = new LimitedStack<T>(defaultUndoCount);
//        redoStack = new LimitedStack<T>(defaultUndoCount);
//    }

//    /// <summary>
//    /// 이전 상태를 가져온다.
//    /// </summary>
//    /// <returns></returns>
//    public T Undo()
//    {
//        T state = this.undoStack.Pop();
//        this.redoStack.Push(state);
//        return this.undoStack.Peek();
//    }

//    /// <summary>
//    /// 이후 상태를 가져온다.
//    /// </summary>
//    /// <returns></returns>
//    public T Redo()
//    {
//        T state = this.redoStack.Pop();
//        this.undoStack.Push(state);
//        return state;
//    }

//    /// <summary>
//    /// 상태를 추가한다.
//    /// </summary>
//    /// <param name="state"></param>
//    public void AddState(T state)
//    {
//        this.undoStack.Push(state);
//        this.redoStack.Clear();
//    }

//    /// <summary>
//    /// 상태를 모두 제거한다.
//    /// </summary>
//    internal void Clear()
//    {
//        this.undoStack.Clear();
//        this.redoStack.Clear();
//    }

//}

///// <summary>
///// 개수 제한이 있는 스택 클래스
///// </summary>
//internal class LimitedStack<T>
//{
//    List<T> list = new List<T>();
//    readonly int capacity;

//    /// <summary>
//    /// 개수를 가져온다.
//    /// </summary>

//    public int Count
//    {
//        get { return this.list.Count; }
//    }

//    /// <summary>
//    /// 생성자
//    /// </summary>
//    /// <param name="capacity"></param>
//    public LimitedStack(int capacity)
//    {
//        this.capacity = capacity;
//    }

//    /// <summary>
//    /// 맨위의 개체를 반환하고 제거한다.
//    /// </summary>
//    /// <returns></returns>
//    internal T Pop()
//    {
//        T t = this.list[0];
//        this.list.RemoveAt(0);
//        return t;
//    }

//    /// <summary>
//    /// 개체를 맨위에 삽입한다.
//    /// </summary>
//    /// <param name="state"></param>
//    internal void Push(T state)
//    {
//        this.list.Insert(0, state);
//        if (this.list.Count > capacity)
//        {
//            this.list.RemoveAt(this.list.Count - 1);
//        }
//    }

//    /// <summary>
//    /// 맨위의 개체를 제거하지 않고 반환한다.
//    /// </summary>
//    /// <returns></returns>
//    internal T Peek()
//    {
//        return this.list[0];
//    }

//    /// <summary>
//    /// 개체를 모두 제거한다.
//    /// </summary>
//    internal void Clear()
//    {
//        this.list.Clear();
//    }

//}

