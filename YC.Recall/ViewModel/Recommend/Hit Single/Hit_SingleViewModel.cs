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
       
        public override void InitViewModel()
        {
            base.InitViewModel();
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues.Add("精选 | 好听到单曲循环的热歌 故事未完待续", "15120.2万");
            keyValues.Add("宅家枯燥？静享民谣式情调","47.1万  ");
            keyValues.Add("电子派对：自由释放荷尔蒙 小众又怎样 ", "36.4万");
            keyValues.Add("冷门亦惊艳｜聆听女声与电音的心动交汇", "18541.2万 ");
            keyValues.Add("(欧美)节奏无关悲喜，只需闭眼尽情舞动吧", "1317293万 ");

            int page = 1;
            foreach (var item in keyValues)
            {
                Hit_SingleModel model = new Hit_SingleModel()
                {
                    Name = item.Key,
                    Remark=item.Value,
                    ImgPath = "pack://application:,,,/Recall music;component/Images/Recommend/"+ page + ".jpg"
                };
                GridModelList.Add(model);
                page++;
            }
           
          
         
        }
    }
}
