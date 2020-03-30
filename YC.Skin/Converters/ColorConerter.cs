using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace YC.Skin.Converters
{
    public class ColorConerter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                SolidColorBrush colorBrush = null;
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    colorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#"+ value));
                }
                else
                {
                    var  whiteBrush = (SolidColorBrush)Application.Current.Resources["YcSkinColor"];
                    colorBrush = whiteBrush;
                }
               
                return colorBrush;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
