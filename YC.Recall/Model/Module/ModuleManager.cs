using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using YC.Recall.Common;
using YC.Recall.Common.Module;

namespace YC.Recall.Model.Module
{
    /// <summary>
    /// 模块组
    /// </summary>
    public class ModuleManager : ViewModelBase
    {
        public ModuleManager()
        {
            IntiModuleGroups();
        }

        private ObservableCollection<Element> _Modules = new ObservableCollection<Element>();
        private ObservableCollection<ModuleGroup> _ModuleGroups = new ObservableCollection<ModuleGroup>();

        /// <summary>
        /// 已加载模块
        /// </summary>
        public ObservableCollection<Element> Modules
        {
            get { return _Modules; }
        }
        private IList<ModuleAttribute> _IModule = null;
        /// <summary>
        /// 已加载模块<含分组>
        /// </summary>
        public ObservableCollection<ModuleGroup> ModuleGroups
        {
            get { return _ModuleGroups; }
        }
        /// <summary>
        /// 初始化模块组
        /// </summary>
        private void IntiModuleGroups()
        {
            Array array = System.Enum.GetValues(typeof(ModuleType));

            foreach (var m in array)
            {
                ModuleType t = (ModuleType)m;
                if (t != ModuleType.None)
                {
                    var attr = GetEnumAttrbute.GetDescription(t);
                    if (attr != null)
                        _ModuleGroups.Add(new ModuleGroup() { ModuleType = t, GroupName = attr.ModuleName, GroupIcon = attr.ModuleIcon });
                }

            }
        }

        /// <summary>
        /// 初始化模块组
        /// </summary>
        private void IntiModuleGroupsee()
        {
            try
            {
                //"Ranking List",   "Radio",
                List<string> recommendList = new List<string>
                {
                    "Hit Single",
                    "Album",
                    "Selected Set",
                };

                List<string> musicList = new List<string>
                {
                    "Collection",
                    "History",
                    "Collect",
                    "Download",
                };

                List<string> moreList = new List<string>
                {
                    "My FM",
                    "Live",
                    "Video"
                };
                Dictionary<string, List<string>> dicGroups = new Dictionary<string, List<string>>();
                dicGroups.Add("Recommend", recommendList);
                dicGroups.Add("My Music", musicList);
                dicGroups.Add("More", moreList);

                foreach (var head in dicGroups)
                {
                    ModuleGroup groups = new ModuleGroup()
                    {
                        GroupName = head.Key,
                        GroupIcon = head.Key,
                        Modules = new ObservableCollection<Element>()
                    };

                    foreach (var prat in head.Value)
                    {
                        Element md = new Element(prat, prat, prat);
                        groups.Modules.Add(md);
                        Modules.Add(md);
                    }
                    _ModuleGroups.Add(groups);
                }



            }
            catch (Exception ex)
            {
                throw;
            }
            //Array array = System.Enum.GetValues(typeof(ModuleType));

            //foreach (var m in array)
            //{
            //    ModuleType t = (ModuleType)m;
            //    if (t != ModuleType.None)
            //    {
            //        var attr = GetEnumAttrbute.GetDescription(t);
            //        if (attr != null)
            //            _ModuleGroups.Add(new ModuleGroup() { ModuleType = t, GroupName = attr.ModuleName, GroupIcon = attr.ModuleIcon });
            //    }

            //}
        }
        /// <summary>
        /// 加载模块-根据权限
        /// </summary>
        public async void LoadModules()
        {
            try
            {
                ModuleComponent loader = new ModuleComponent();
                _IModule = await Task.Run(() => loader.GetModules());
                if (_IModule == null) return;
                foreach (var m in _IModule.OrderBy(s=>s.Sort))
                {
                    if (!loader.ModuleVerify(m)) continue;

                    var mg = ModuleGroups.FirstOrDefault(t => t.ModuleType.Equals(m.ModuleType)); //寻找模块对应的组
                    if (mg != null)
                    {
                        if (mg.Modules == null) mg.Modules = new ObservableCollection<Element>();
                       
                        Element md = new Element(m.Name, m.ModuleNameSpace,  m.ICON);
                        mg.Modules.Add(md);
                        Modules.Add(md);
                    }
                }
                GC.Collect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
