using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Recall.Model
{
    public class Hit_SingleModel : ViewModelBase
    {
        string _ImagePath;
        /// <summary>
        /// 显示的图标路径
        /// </summary>
        public string ImagePath
        {
            get { return _ImagePath; }
            set
            {
                _ImagePath = value;
                RaisePropertyChanged();
            }
        }
    }
}
