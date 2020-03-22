using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using YC.Recall.ILayer.Base;
using YC.Recall.ViewDialog.Base;

namespace YC.Recall
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Messenger.Default.Register<string>(this, MainClose);

        }

        /// <summary>   
        /// 关闭Host朦层窗口
        /// </summary>
        /// <param name="obj"></param>
        private void MainClose(string obj)
        {
            //DialogHost.IsOpen = false;
        }

     
 
    }

    /// <summary>
    /// 首页
    /// </summary>
    public class MainViewDlg : BaseViewDialog<MainWindow>, IModelDialog
    {
        public override void BindViewModel<TViewModel>(TViewModel viewModel)
        {
            GetDialogWindow().DataContext = viewModel;
        }

        public override void Close()
        {
            GetDialogWindow().Close();
        }

        public override Task<bool> ShowDialog(DialogOpenedEventHandler openedEventHandler = null, DialogClosingEventHandler closingEventHandler = null)
        {
            GetDialogWindow().ShowDialog();
            return Task.FromResult(true);
        }

        public override void RegisterDefaultEvent()
        {
            GetDialogWindow().MouseDown += (sender, e) => { if (e.LeftButton == MouseButtonState.Pressed) { GetDialogWindow().DragMove(); } };
            Messenger.Default.Register<string>(GetDialogWindow(), "MainExit", new Action<string>(async (msg) =>
            {
               this.Close();
            }));
            Messenger.Default.Register<string>(GetDialogWindow(), "MinWindow", new Action<string>((msg) => { GetDialogWindow().WindowState = WindowState.Minimized; }));
            Messenger.Default.Register<bool>(GetDialogWindow(), "MaxWindow", new Action<bool>((arg) =>
            {
                var win = GetDialogWindow();
                if (win.WindowState == WindowState.Maximized)
                    win.WindowState = WindowState.Normal;
                else
                    win.WindowState = WindowState.Maximized;
            }));
        }

        private Window GetDialogWindow()
        {
            return GetDialog() as Window;
        }
    }
}
