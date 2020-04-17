using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YC.Recall.Common.Module;
using YC.Recall.ILayer.Base;
using YC.Recall.Model;
using YC.Recall.ViewDialog.Base;
using YC.Recall.ViewModel.Recommend.Songs;

namespace YC.Recall.Views.Recommend.Songs
{
    /// <summary>
    /// SongsView.xaml 的交互逻辑
    /// </summary>
    public partial class SongsView : UserControl
    {
        public SongsView()
        {
            InitializeComponent();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// 
    [Module(ModuleType.Recommend, "Songs", "YC.Recall.Views.Recommend.Songs.SongsViewDog", "\ue751", 0)]
    public class SongsViewDog : BaseView<SongsView, SongsViewModell, SongsModell>, IModel
    {

    }
}
