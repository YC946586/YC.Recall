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


    public class RadioButtonIcon : RadioButton
    {

        public Geometry SelectIcon
        {
            get { return (Geometry)GetValue(SelectIconProperty); }
            set { SetValue(SelectIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectIconProperty =
            DependencyProperty.Register("SelectIcon", typeof(Geometry), typeof(RadioButtonIcon), new PropertyMetadata(default(Geometry)));




        public Brush IconColor
        {
            get { return (Brush)GetValue(IconColorProperty); }
            set { SetValue(IconColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconColorProperty =
            DependencyProperty.Register("IconColor", typeof(Brush), typeof(RadioButtonIcon), new PropertyMetadata(Brushes.Red));



        /// <summary>
        /// 圆角
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(RadioButtonIcon), new PropertyMetadata(new CornerRadius(2)));



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(RadioButtonIcon), new PropertyMetadata(""));


        public static readonly DependencyProperty TextIconProperty =
       DependencyProperty.Register("TextIcon", typeof(string), typeof(RadioButtonIcon), new PropertyMetadata(""));
        public string TextIcon
        {
            get { return (string)GetValue(TextIconProperty); }
            set { SetValue(TextIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
   


    }


}
