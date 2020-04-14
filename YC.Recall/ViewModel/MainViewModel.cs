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
using YC.Recall.Views;
using YC.Recall.Views.Album;
using YC.Recall.Views.Collection;

namespace YC.Recall.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        #region ����(Binding Command)

        private object _CurrentPage;

        /// <summary>
        /// ��ǰѡ��ҳ
        /// </summary>
        public object CurrentPage
        {
            get { return _CurrentPage; }
            set { _CurrentPage = value; RaisePropertyChanged(); }
        }

        private RelayCommand<Element> _ExcuteCommand;
        private RelayCommand<PageInfo> _ExitCommand;

        /// <summary>
        /// ��ҳ
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

        #region ģ��ϵͳ

        private ModuleManager _ModuleManager;


        /// <summary>
        /// ģ�������
        /// </summary>
        public ModuleManager ModuleManager
        {
            get { return _ModuleManager; }
        }

        #endregion

        #region ������

        private NoticeViewModel _NoticeView;

        /// <summary>
        /// ֪ͨģ��
        /// </summary>
        public NoticeViewModel NoticeView
        {
            get { return _NoticeView; }
        }

        #endregion



        public MainViewModel()
        {
            //��ʼ��������
            _NoticeView = new NoticeViewModel();
            //���ش���ģ��
            _ModuleManager = new ModuleManager();
            _ModuleManager.LoadModules();
            //����ϵͳĬ����ҳ

            IndexView about = new IndexView();
            IndexViewModel model = new IndexViewModel();
            about.DataContext = model;
            //OpenPageCollection.Add(new PageInfo() { HeaderName = "ϵͳ��ҳ", Body = about });
            CurrentPage = about;

        }
        /// <summary>
        /// ִ��ģ��
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