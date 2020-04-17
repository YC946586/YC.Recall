﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using YC.Recall.Common.Module;

namespace YC.Recall.Model.Module
{
    /// <summary>
    /// 模块组
    /// </summary>
    public class ModuleGroup : ViewModelBase
    {
        private int groupid;
        private string _groupIcon = "BlockHelper";
        private string groupName;
        private ModuleType _moduleType;
        private ObservableCollection<Element> modules;
        /// <summary>
        /// 模块类型
        /// </summary>
        public ModuleType ModuleType
        {
            get { return _moduleType; }
            set { _moduleType = value; RaisePropertyChanged(); }
        }
        /// <summary>
        /// 模块ICO
        /// </summary>
        public string GroupIcon
        {
            get { return _groupIcon; }
            set { _groupIcon = value; RaisePropertyChanged(); }
        }



        /// <summary>
        /// 父模块ID
        /// </summary>
        public int GroupId
        {
            get { return groupid; }
            set { groupid = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 父模块名称
        /// </summary>
        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 子模块集合
        /// </summary>
        public ObservableCollection<Element> Modules
        {
            get { return modules; }
            set { modules = value; RaisePropertyChanged(); }
        }
    }

    /// <summary>
    /// 模块类
    /// </summary>
    public class Element
    {
        public Element(string Name, string NameSpace, string Icon,bool chcek=false)
        {
            _Name = Name;
            _ModNameSpcae = NameSpace;
            _Icon = Icon;
            _Ischcek = chcek;
        }

        private string _Name;
        private string _IviewModel;
        private int? _Authorities;
        private string _ModNameSpcae;
        private string _Icon;
        private bool _Ischcek;

        /// <summary>
        /// 图标-IconFont
        /// </summary>
        public string ICON
        {
            get { return _Icon; }
        }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string Name
        {
            get { return _Name; }
        }

        /// <summary>
        /// ICON
        /// </summary>
        public string IviewModel
        {
            get { return _IviewModel; }
        }

        /// <summary>
        /// 模块命名空间
        /// </summary>
        public string ModNameSpcae
        {
            get { return _ModNameSpcae; }
        }

        /// <summary>
        /// 权限值
        /// </summary>
        public int? Authorities
        {
            get { return _Authorities; }
        }
        /// <summary>
        /// ICON
        /// </summary>
        public bool IsCheck
        {
            get { return _Ischcek; }
        }
    }
}
