using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace YC.Skin
{
    /// <summary>
    /// 扩展输入框：可设置水印,可设置必填,可设置正则表达式验证
    /// </summary>
    public class SearchText : TextBox
    {
        #region 依赖属性
        public static readonly DependencyProperty XWmkTextProperty;//水印文字
        public static readonly DependencyProperty XWmkForegroundProperty;//水印着色
        public static readonly DependencyProperty XIsErrorProperty;//是否字段有误
        public static readonly DependencyProperty XAllowNullProperty;//是否允许为空
        public static readonly DependencyProperty XRegExpProperty;//正则表达式
        public static readonly DependencyProperty ProupIsOpen;//显示pop
        
        #endregion

        #region 内部方法
        /// <summary>
        /// 注册事件
        /// </summary>
        public SearchText()
        {
            //失去焦点时检查输入
            this.LostFocus += (sender, args) =>
            {
                IsPopupOpen = false;
                this.XIsError = false;
                //if (XAllowNull == false && this.Text.Trim() == "")
                //{
                //    this.XIsError = true;
                //}
                if (Regex.IsMatch(this.Text.Trim(), XRegExp) == false)
                {
                    this.XIsError = true;
                }
            };
            this.GotFocus += new RoutedEventHandler(XTextBox_GotFocus);
            this.PreviewMouseDown += new MouseButtonEventHandler(XTextBox_PreviewMouseDown);
          
             
            //this.PreviewMouseMove += (sender, args) =>
            //{
            //    IsOpen = false;
            //};
        }

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static SearchText()
        {
            //注册依赖属性
            SearchText.XWmkTextProperty = DependencyProperty.Register("XWmkText", typeof(String), typeof(SearchText), new PropertyMetadata(null));
            SearchText.XAllowNullProperty = DependencyProperty.Register("XAllowNull", typeof(bool), typeof(SearchText), new PropertyMetadata(false));

            SearchText.XIsErrorProperty = DependencyProperty.Register("XIsError", typeof(bool), typeof(SearchText), new PropertyMetadata(false));
            SearchText.XRegExpProperty = DependencyProperty.Register("XRegExp", typeof(string), typeof(SearchText), new PropertyMetadata(""));
            SearchText.XWmkForegroundProperty = DependencyProperty.Register("XWmkForeground", typeof(Brush),
                typeof(SearchText), new PropertyMetadata(Brushes.Gray));
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(SearchText), new FrameworkPropertyMetadata(typeof(SearchText)));
            SearchText.ProupIsOpen = DependencyProperty.Register("IsPopupOpen", typeof(bool), typeof(SearchText), new PropertyMetadata(false));
        }

    

        /// <summary>
        /// 获得焦点时选中文字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void XTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
         
            this.SelectAll();
        }

        /// <summary>
        /// 鼠标点击时选中文字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void XTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.IsFocused == false)
            {
                IsPopupOpen = true;
                TextBox textBox = e.Source as TextBox;
                textBox.Focus();
                e.Handled = true;
            }
        }
        #endregion

        #region 公布属性
        /// <summary>
        /// 公布属性XWmkText（水印文字）
        /// </summary>
        public String XWmkText
        {
            get
            {
                return base.GetValue(XWmkTextProperty) as String;
            }
            set
            {
                base.SetValue(SearchText.XWmkTextProperty, value);
            }
        }

        /// <summary>
        /// 公布属性XWmkForeground（水印着色）
        /// </summary>
        public Brush XWmkForeground
        {
            get
            {
                return base.GetValue(SearchText.XWmkForegroundProperty) as Brush;
            }
            set
            {
                base.SetValue(SearchText.XWmkForegroundProperty, value);
            }
        }

        /// <summary>
        /// 公布属性XIsError（是否字段有误）
        /// </summary>
        public bool XIsError
        {
            get
            {
                return (bool)base.GetValue(SearchText.XIsErrorProperty);
            }
            set
            {
                base.SetValue(SearchText.XIsErrorProperty, value);
            }
        }

        /// <summary>
        /// 是否能显示
        /// </summary>
        public bool IsPopupOpen
        {
            get
            {
                return (bool)base.GetValue(SearchText.ProupIsOpen);
            }
            set
            {
                base.SetValue(SearchText.ProupIsOpen, value);
            }
        }

        /// <summary>
        /// 公布属性XAllowNull（是否允许为空）
        /// </summary>
        public bool XAllowNull
        {
            get
            {
                return (bool)base.GetValue(SearchText.XAllowNullProperty);
            }
            set
            {
                base.SetValue(SearchText.XAllowNullProperty, value);
            }
        }

        /// <summary>
        /// 公布属性XRegExp（正则表达式）
        /// </summary>
        public string XRegExp
        {
            get
            {
                return base.GetValue(SearchText.XRegExpProperty) as string;
            }
            set
            {
                base.SetValue(SearchText.XRegExpProperty, value);
            }
        }
        #endregion
    }
}

