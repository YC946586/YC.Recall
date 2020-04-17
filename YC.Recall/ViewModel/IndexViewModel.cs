using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Recall.Common.CoreLib;
using YC.Recall.Model;

namespace YC.Recall.ViewModel
{
    public class IndexViewModel : BaseOperation<IndexModel>
    {
        public ObservableCollection<ModuleInfo> Modules { get; set; }
  

        
        public override void InitViewModel()
        {
            base.InitViewModel();
            Modules = new ObservableCollection<ModuleInfo>();
            Modules.Add(new ModuleInfo() { IconFont = "\xe626", Title = "Application" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe77a", Title = "Opinion" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe50a", Title = "Tasks" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe669", Title = "Program" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe502", Title = "Data" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe77a", Title = "Opinion" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe50a", Title = "Tasks" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe669", Title = "Program" });

          
            GridModelList.Add(new IndexModel() { Name = "盗墓笔记·十年人间", Composer = "李常超（Lao乾妈）", AlbumName = "盗墓笔记·十年人间", Duration = "99999"});
            GridModelList.Add(new IndexModel() { Name = "盗墓笔记·十年人间", Composer = "李常超（Lao乾妈）", AlbumName = "盗墓笔记·十年人间", Duration = "99999" });
            GridModelList.Add(new IndexModel() { Name = "盗墓笔记·十年人间", Composer = "李常超（Lao乾妈）", AlbumName = "盗墓笔记·十年人间", Duration = "99999" });
            GridModelList.Add(new IndexModel() { Name = "盗墓笔记·十年人间", Composer = "李常超（Lao乾妈）", AlbumName = "盗墓笔记·十年人间", Duration = "99999" }); 
            GridModelList.Add(new IndexModel() { Name = "盗墓笔记·十年人间", Composer = "李常超（Lao乾妈）", AlbumName = "盗墓笔记·十年人间", Duration = "99999" }); 
            GridModelList.Add(new IndexModel() { Name = "盗墓笔记·十年人间", Composer = "李常超（Lao乾妈）", AlbumName = "盗墓笔记·十年人间", Duration = "99999" }); 
            GridModelList.Add(new IndexModel() { Name = "盗墓笔记·十年人间", Composer = "李常超（Lao乾妈）", AlbumName = "盗墓笔记·十年人间", Duration = "99999" });

        }

    }
    public class ModuleInfo
    {
        public string IconFont { get; set; }

        public string Title { get; set; }
    }


}
