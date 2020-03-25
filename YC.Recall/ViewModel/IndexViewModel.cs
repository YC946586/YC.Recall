using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Recall.ViewModel
{
    public class IndexViewModel
    {
        public ObservableCollection<ModuleInfo> Modules { get; set; }
        public ObservableCollection<UserModel> GridModelList { get; set; }

        public IndexViewModel()
        {
            Init();
        }
        private void Init()
        {
            Modules = new ObservableCollection<ModuleInfo>();
            Modules.Add(new ModuleInfo() { IconFont = "\xe626", Title = "Application" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe77a", Title = "Opinion" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe50a", Title = "Tasks" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe669", Title = "Program" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe502", Title = "Data" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe77a", Title = "Opinion" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe50a", Title = "Tasks" });
            Modules.Add(new ModuleInfo() { IconFont = "\xe669", Title = "Program" });

            GridModelList = new ObservableCollection<UserModel>();
            GridModelList.Add(new UserModel() { Name = "Vaughan", Address = "Delaware", Email = "29579895@qq.com", UserType = "Quality inspector", Status = "S1", BackColor = "#FF7000" });
            GridModelList.Add(new UserModel() { Name = "Abbey", Address = "Florida", Email = "29579895@qq.com", UserType = "Quality inspector", Status = "S2", BackColor = "#FFC100" });
            GridModelList.Add(new UserModel() { Name = "Dahlia", Address = "Illinois", Email = "29579895@qq.com", UserType = "Quality inspector", Status = "S1", BackColor = "#FF7000" });
            GridModelList.Add(new UserModel() { Name = "Fallon", Address = "Tennessee", Email = "29579895@qq.com", UserType = "Quality inspector", Status = "S3", BackColor = "#59E6B5" });
            GridModelList.Add(new UserModel() { Name = "Hannah", Address = "Washington", Email = "29579895@qq.com", UserType = "Quality inspector", Status = "S4", BackColor = "#FFC100" });
            GridModelList.Add(new UserModel() { Name = "Laura", Address = "Mississippi", Email = "29579895@qq.com", UserType = "Quality inspector", Status = "S2", BackColor = "#59E6B5" });
            GridModelList.Add(new UserModel() { Name = "Lauren", Address = "Wyoming", Email = "29579895@qq.com", UserType = "Quality inspector", Status = "S3", BackColor = "#FFC100" });
        }

    }
    public class ModuleInfo
    {
        public string IconFont { get; set; }

        public string Title { get; set; }
    }

    public class UserModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string BackColor { get; set; }

        public string Status { get; set; }

        public string UserType { get; set; }
    }
}
