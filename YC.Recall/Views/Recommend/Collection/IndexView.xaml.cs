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
using YC.Recall.ViewModel;

namespace YC.Recall.Views.Collection
{
    /// <summary>
    /// IndexView.xaml 的交互逻辑
    /// </summary>ContentStyle
    public partial class IndexView : UserControl
    {
        public IndexView()
        {
            InitializeComponent();
        }
    }
    /// <summary>
    /// IndexViewDog
    /// </summary>
    /// 
    [Module(ModuleType.Recommend, "Collection", "YC.Recall.Views.Collection.IndexViewDog", "\ue72d", 1)]
    public class IndexViewDog : BaseView<IndexView, IndexViewModel, IndexModel>, IModel
    {

    }
}
