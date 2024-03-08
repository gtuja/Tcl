#pragma warning disable IDE1006 // Naming Styles

namespace Tcl
{
  public enum TaskType
  {
    Template,
  }

  public class TaskRegisterArgs(EventHandler<TaskEventEntryArgs> eh)
  {
    public EventHandler<TaskEventEntryArgs> ehTaskEventEntry = eh;
  }

  public interface ITcl
  {
    void vidHandleEventTaskEntry(object snd, TaskEventEntryArgs e);
  }
  public interface ITaskManager
  {
    Int32 s32Register(TaskType enuTaskType, TaskRegisterArgs traArgs);
  }

  public class TaskManager : ITaskManager
  {
    public TaskManager()
    {
    }

    public Int32 s32Register(TaskType enuTaskType, TaskRegisterArgs traArgs)
    {
      Tcl.Task tsk = new(traArgs.ehTaskEventEntry);
      return 0;
    }
  }

  public class TaskEventEntryArgs(String strContent) : System.EventArgs()
  {
    public String strContent {get; set;} = strContent;        /**< A String object holding content, e.g. Button. */
  };

  public class Task
  {
    public event EventHandler<TaskEventEntryArgs> ehTaskEntry;

    public Task(EventHandler<TaskEventEntryArgs> eh)
    {
      this.ehTaskEntry += eh;
      this.ehTaskEntry.Invoke(this, new TaskEventEntryArgs("Start.."));
    }
  }
};

