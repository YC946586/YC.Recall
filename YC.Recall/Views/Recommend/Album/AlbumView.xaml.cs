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
using YC.Recall.ViewModel.Album;

namespace YC.Recall.Views.Album
{
   
    public partial class AlbumView : UserControl
    {
        public AlbumView()
        {
            InitializeComponent();
        }
    }
    /// <summary>
    /// AlbumView.xaml 的交互逻辑
    /// </summary>
    /// 
    [Module(ModuleType.Recommend, "Album", "YC.Recall.Views.Album.AlbumViewDog", 1)]
    public class AlbumViewDog : BaseView<AlbumView, AlbumViewModel, AlbumModel>, IModel
    {

    }
}
