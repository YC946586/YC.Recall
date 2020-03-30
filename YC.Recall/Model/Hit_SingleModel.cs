using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Recall.Model
{
    public class Hit_SingleModel : AlbumModel
    {


        private string _songName = string.Empty;
        /// <summary>
        ///  歌曲名称
        /// </summary>
        public string SongName
        {
            get { return _songName; }
            set { _songName = value; RaisePropertyChanged(); }
        }

        private string _Composer = string.Empty;
        /// <summary>
        ///  歌曲创作人
        /// </summary>
        public string Composer
        {
            get { return _Composer; }
            set { _Composer = value; RaisePropertyChanged(); }
        }


        private string _AlbumName = string.Empty;
        /// <summary>
        ///  专辑名称
        /// </summary>
        public string AlbumName
        {
            get { return _AlbumName; }
            set { _AlbumName = value; RaisePropertyChanged(); }
        }

        private string _Duration = string.Empty;
        /// <summary>
        ///  时长
        /// </summary>
        public string Duration
        {
            get { return _Duration; }
            set { _Duration = value; RaisePropertyChanged(); }
        }
    }
}
