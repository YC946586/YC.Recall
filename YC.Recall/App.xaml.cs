using Lierda.WPFHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using YC.Recall.Common.Unity;
using YC.Recall.ILayer.Base;
using YC.Recall.ViewModel;

namespace YC.Recall
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        LierdaCracker cracker = new LierdaCracker();

        protected override void OnStartup(StartupEventArgs e)
        {
            cracker.Cracker();
            base.OnStartup(e);
            //IOC接口注册
            BootStrapper.Initialize();
            //var Dialog = ServiceProvider.Instance.Get<MainWindow>();
            //var main = ServiceProvider.Instance.Get<MainViewModel>();
            //Dialog.DataContext = main;
            //Dialog?.ShowDialog();
            MainViewModel view = new MainViewModel();
            var Dialog = ServiceProvider.Instance.Get<IModelDialog>("MainViewDlg");
            Dialog.BindViewModel(view);
            Dialog.ShowDialog();

            
        }
    }
}
