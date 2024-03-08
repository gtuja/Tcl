using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tcl;

namespace ShowCase;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window, Tcl.ITcl
{
  private readonly ProgressBar pbProgress;
  private readonly RichTextBox rtbLog;
  private readonly Label lblStatus;
  private readonly Button btnExecute;

  private readonly Tcl.TaskManager tmManager;
  public MainWindow()
  {
    InitializeComponent();
    this.lblStatus = LabelStatus;
    this.pbProgress = ProgressBarExecute;
    this.rtbLog = RichTextBoxLog;
    this.btnExecute = ButtonExecute;
    this.tmManager = new Tcl.TaskManager();
  }

  public void vidHandleEventTaskEntry(object? snd, TaskEventEntryArgs e)
  {
    this.btnExecute.Content = e.strContent;
  }

  private void vidBtnExecuteClick(
    object objSender,
    RoutedEventArgs reaEvent
  )
  {
    this.tmManager.s32Register(Tcl.TaskType.Template, new TaskRegisterArgs(this.vidHandleEventTaskEntry));
    MessageBox.Show("Button is clicked..");
  }
}
