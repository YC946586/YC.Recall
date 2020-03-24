using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace YC.Skin
{
    public class ImgMovButton : Control
    {
        public ImgMovButton()
        {

        }
        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ImgMovButton), new PropertyMetadata(""));
        //定义Imagesource依赖属性

        public static readonly DependencyProperty ImgPathProperty
        = DependencyProperty.Register("ImgPath", typeof(ImageSource), typeof(ImgMovButton), null);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public ImageSource ImgPath
        {
            get { return (ImageSource)GetValue(ImgPathProperty); }
            set { SetValue(ImgPathProperty, value); }
        }

      
    }
}
