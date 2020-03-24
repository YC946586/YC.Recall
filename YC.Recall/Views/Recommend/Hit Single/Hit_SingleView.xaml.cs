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
using YC.Recall.ViewModel.Recommend.Hit_Single;

namespace YC.Recall.Views.Recommend.Hit_Single
{
    /// <summary>
    /// Hit_SingleView.xaml 的交互逻辑
    /// </summary>
    public partial class Hit_SingleView : UserControl
    {
        public Hit_SingleView()
        {
            InitializeComponent();
            
        }

       
    }
    /// <summary>
    /// AlbumView.xaml 的交互逻辑
    /// </summary>
    /// 
    [Module(ModuleType.Recommend, "Hit Single", "YC.Recall.Views.Recommend.Hit_Single.Hit_SingleViewDog", 0)]
    public class Hit_SingleViewDog : BaseView<Hit_SingleView, Hit_SingleViewModel, Hit_SingleModel>, IModel
    {

    }
}
