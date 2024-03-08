#pragma warning disable IDE1006 // Naming Styles

namespace Tcl
{
  public enum TaskType
  {
    Template,
  }

  public class TaskEventEntryArgs(String strContent, Int32 s32ProgressMaximum) : System.EventArgs()
  {
    public String strContent {get; set;} = strContent;                /**< A String object holding content, e.g. Button. */
    public Int32 s32ProgressMaximum {get; set;} = s32ProgressMaximum; /**< A String object holding content, e.g. Button. */
  };

  public class TaskEventProgressArgs(Int32 s32Progress, String strStatus) : System.EventArgs()
  {
    public Int32 s32Progress {get; set;} = s32Progress; /**< A String object holding content, e.g. Button. */
    public String strStatus {get; set;} = strStatus; /**< A String object holding content, e.g. Button. */
  };

  public class TaskEventExitArgs(String strContent) : System.EventArgs()
  {
    public String strContent {get; set;} = strContent;                /**< A String object holding content, e.g. Button. */
  };

  public class TaskEventLogArgs(String strLog) : System.EventArgs()
  {
    public String strLog {get; set;} = strLog; /**< A String object holding content, e.g. Button. */
  };

  public class TaskRegisterArgs(
    EventHandler<TaskEventEntryArgs> ehTaskEventEntry,
    EventHandler<TaskEventProgressArgs> ehTaskEventProgress,
    EventHandler<TaskEventExitArgs> ehTaskEventExit,
    EventHandler<TaskEventLogArgs> ehTaskEventLog
    )
  {
    public EventHandler<TaskEventEntryArgs> ehTaskEventEntry = ehTaskEventEntry;
    public EventHandler<TaskEventProgressArgs> ehTaskEventProgress = ehTaskEventProgress;
    public EventHandler<TaskEventExitArgs> ehTaskEventExit = ehTaskEventExit;
    public EventHandler<TaskEventLogArgs> ehTaskEventLog = ehTaskEventLog;
  }

  public interface ITcl
  {
    void vidHandleEventTaskEntry(object snd, TaskEventEntryArgs e);
    void vidHandleEventTaskProgress(object snd, TaskEventProgressArgs e);
    void vidHandleEventTaskExit(object snd, TaskEventExitArgs e);
    void vidHandleEventTaskLog(object snd, TaskEventLogArgs e);
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


  public class Task
  {
    public event EventHandler<TaskEventEntryArgs> ehTaskEntry;

    public Task(EventHandler<TaskEventEntryArgs> eh)
    {
      this.ehTaskEntry += eh;
      this.ehTaskEntry.Invoke(this, new TaskEventEntryArgs("Start..", 100));
    }
  }
};

