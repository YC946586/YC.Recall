using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using YC.Recall.Common.CoreLib;
using YC.Recall.Model;

namespace YC.Recall.ViewModel.Album
{
    public class AlbumViewModel : BaseOperation<AlbumModel>
    {
        private ObservableCollection<AlbumModel> dataList;
        public ObservableCollection<AlbumModel> DataList
        {
            get { return dataList; }
            set
            {
                dataList = value;
                RaisePropertyChanged();
            }
        }

        public AlbumViewModel()
        {
            DataList = GetDataList();
        }

        private ObservableCollection<AlbumModel> GetDataList()
        {

            return new ObservableCollection<AlbumModel>
            {
                new AlbumModel {ImgPath = "pack://application:,,,/YC.Skin;component/Images/Album/1.jpg", Name = "Image1"},
                new AlbumModel {ImgPath = "pack://application:,,,/YC.Skin;component/Images/Album/2.jpg", Name = "Image2"},
                new AlbumModel {ImgPath = "pack://application:,,,/YC.Skin;component/Images/Album/3.jpg", Name = "Image3"},
                new AlbumModel {ImgPath = "pack://application:,,,/YC.Skin;component/Images/Album/4.jpg", Name = "Image4"},
                new AlbumModel {ImgPath = "pack://application:,,,/YC.Skin;component/Images/Album/5.jpg", Name = "Image5"},
                new AlbumModel {ImgPath = "pack://application:,,,/YC.Skin;component/Images/Album/6.jpg", Name = "Image6"},
                new AlbumModel {ImgPath = "pack://application:,,,/YC.Skin;component/Images/Album/7.jpg", Name = "Image7"},
                new AlbumModel {ImgPath = "pack://application:,,,/YC.Skin;component/Images/Album/8.jpg", Name = "Image8"},
                new AlbumModel {ImgPath = "pack://application:,,,/YC.Skin;component/Images/Album/9.jpg", Name = "Image9"},
                new AlbumModel {ImgPath = "pack://application:,,,/YC.Skin;component/Images/Album/10.jpg", Name = "Image10"},
            };
        }
    }
}
