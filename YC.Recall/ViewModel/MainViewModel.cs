using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using YC.Recall.Common.Additional;
using YC.Recall.Common.Unity;
using YC.Recall.ILayer.Base;
using YC.Recall.Model.Module;
using YC.Recall.ViewModel.Recommend.Hit_Single;
using YC.Recall.Views;
using YC.Recall.Views.Album;
using YC.Recall.Views.Collection;
using YC.Recall.Views.Recommend.Hit_Single;

namespace YC.Recall.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        #region 命令(Binding Command)

        private object _CurrentPage;

        /// <summary>
        /// 当前选择页
        /// </summary>
        public object CurrentPage
        {
            get { return _CurrentPage; }
            set { _CurrentPage = value; RaisePropertyChanged(); }
        }

        private RelayCommand<Element> _ExcuteCommand;
        private RelayCommand<PageInfo> _ExitCommand;

        /// <summary>
        /// 打开页
        /// </summary>
        public RelayCommand<Element> ExcuteCommand
        {
            get
            {
                if (_ExcuteCommand == null)
                {
                    _ExcuteCommand = new RelayCommand<Element>(t => Excute(t));
                }
                return _ExcuteCommand;
            }
            set { _ExcuteCommand = value; RaisePropertyChanged(); }
        }



      
        #endregion

        #region 模块系统

        private ModuleManager _ModuleManager;


        /// <summary>
        /// 模块管理器
        /// </summary>
        public ModuleManager ModuleManager
        {
            get { return _ModuleManager; }
        }

        #endregion

        #region 工具栏

        private NoticeViewModel _NoticeView;

        /// <summary>
        /// 通知模块
        /// </summary>
        public NoticeViewModel NoticeView
        {
            get { return _NoticeView; }
        }

        #endregion



        public MainViewModel()
        {
            //初始化工具栏
            _NoticeView = new NoticeViewModel();
            //加载窗体模块
            _ModuleManager = new ModuleManager();
            _ModuleManager.LoadModules();
            //设置系统默认首页

            Hit_SingleView about = new Hit_SingleView();
            Hit_SingleViewModel model = new Hit_SingleViewModel();
            model.InitViewModel();
            about.DataContext = model;
            //OpenPageCollection.Add(new PageInfo() { HeaderName = "系统首页", Body = about });
            CurrentPage = about;

        }
        /// <summary>
        /// 执行模块
        /// </summary>
        /// <param name="module"></param>
        private async void Excute(Element module)
        {
            try
            {
                await Task.Run(() =>
                {
                    App.Current.Dispatcher.Invoke(() =>
                    {
                        var ass = System.Reflection.Assembly.GetExecutingAssembly();
                        var DD = ass.CreateInstance(module.ModNameSpcae);
                        if (ass.CreateInstance(module.ModNameSpcae) is IModel dialog)
                        {
                            dialog.BindDefaultModel(module.Authorities);
                            CurrentPage = dialog.GetView();
                        }

                        //var view = Assembly.GetExecutingAssembly().CreateInstance(module.ModNameSpcae);
                        //var viewModel= Assembly.GetExecutingAssembly().CreateInstance(module.IviewModel);
                        //(view as UserControl).DataContext = viewModel;
                        //CurrentPage = view;
                    });
                });
            }
            catch (Exception ex)
            {
                //Msg.Error(ex.Message, false);
            }
            finally
            {
                Messenger.Default.Send(false, "PackUp");
                GC.Collect();
            }
        }
     

    }
}