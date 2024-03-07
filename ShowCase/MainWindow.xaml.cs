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

namespace ShowCase;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
  private readonly ProgressBar pbProgress;
  private readonly RichTextBox rtbLog;
  private readonly Label lblStatus;
  private readonly Button btnExecute;

  // private readonly Task.Manager tmManager;
  public MainWindow()
  {
    InitializeComponent();
    this.lblStatus = LabelStatus;
    this.pbProgress = ProgressBarExecute;
    this.rtbLog = RichTextBoxLog;
    this.btnExecute = ButtonExecute;
    // this.tmManager = new Task.Manager(this.btnExecute, this.pbProgress, this.rtbLog, this.lblStatus);
    // this.tmManager.enuRegister(new Task.TemplateBackground(this.strTaskId));
  }

  private void vidBtnExecuteClick(
    object objSender,
    RoutedEventArgs reaEvent
  )
  {
    MessageBox.Show("Button is clicked..");
  }
}
