using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Recall.Model
{
    public class AlbumModel: ViewModelBase
    {
        private string _imgPath = string.Empty;
        /// <summary>
        /// 模块ICO
        /// </summary>
        public string ImgPath
        {
            get { return _imgPath; }
            set { _imgPath = value; RaisePropertyChanged(); }
        }

       

        public string Remark { get; set; }

        public string Name { get; set; }
    }
}
