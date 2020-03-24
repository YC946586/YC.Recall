using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace YC.Skin.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                BitmapImage defImage = new BitmapImage();
                defImage.BeginInit();
                defImage.UriSource = new Uri(value.ToString(), UriKind.RelativeOrAbsolute);
                defImage.EndInit();
                return defImage;
            }
            catch (Exception)
            {

                throw;
            }
      
        }



        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)

        {

            throw new NotImplementedException();

        }

    }
}
