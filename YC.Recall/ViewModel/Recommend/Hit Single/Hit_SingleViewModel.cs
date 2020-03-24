using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Recall.Common.CoreLib;
using YC.Recall.Model;

namespace YC.Recall.ViewModel.Recommend.Hit_Single
{
    public class Hit_SingleViewModel: BaseOperation<Hit_SingleModel>
    {
        string _ImagePath;
        /// <summary>
        /// 显示的图标路径
        /// </summary>
        public string ImageSourcPath
        {
            get { return _ImagePath; }
            set
            {
                _ImagePath = value;
                RaisePropertyChanged();
            }
        }
        string _Name;
        /// <summary>
        /// 显示的图标路径
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                RaisePropertyChanged();
            }
        }
        public Hit_SingleViewModel()
        {
            Name = "PiuPiu";
            ImageSourcPath =@"pack://application:,,,/YC.Skin;component/Images/Album/1.jpg";
        }
    }
}
