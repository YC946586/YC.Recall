using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace YC.Skin
{
    public class LenovoSearch : ComboBox
    {
        public LenovoSearch()
        {

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(LenovoSearch), new FrameworkPropertyMetadata(typeof(LenovoSearch)));
            DependencyPropertyDescriptor textProperty = DependencyPropertyDescriptor.FromProperty(
                ComboBox.TextProperty, typeof(LenovoSearch));
            textProperty.AddValueChanged(this, this.OnTextChanged);
        }

        /// <summary>
        /// 所有的下拉列表合计
        /// </summary>
        public IEnumerable<dynamic> ItemsSourceProperty
        {
            get => (IEnumerable<dynamic>)GetValue(ItemsSourcePropertyProperty);
            set => SetValue(ItemsSourcePropertyProperty, value);
        }

        // Using a DependencyProperty as the backing store for ItemsSourceProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourcePropertyProperty =
            DependencyProperty.Register("ItemsSourceProperty", typeof(IEnumerable<dynamic>), typeof(LenovoSearch), new PropertyMetadata(null));

        /// <summary>
        /// 根据什么字段来赛选 下拉列表
        /// </summary>
        public string LikeNames
        {
            get => (string)GetValue(LikeNamesProperty);
            set => SetValue(LikeNamesProperty, value);
        }

        // Using a DependencyProperty as the backing store for LikeNames.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LikeNamesProperty =
            DependencyProperty.Register("LikeNames", typeof(string), typeof(LenovoSearch), new PropertyMetadata(""));

        #region | Handle selection |

        private int silenceEvents = 0;
        /// <summary>
        /// Gets the text box in charge of the editable portion of the combo box.
        /// </summary>
        protected TextBox EditableTextBox
        {
            get
            {
                TextBox TxtBox = (TextBox)this.Template.FindName("PART_EditableTextBox", this);
                return TxtBox;

            }
        }

        private int start = 0, length = 0;


        #endregion


        private void OnTextChanged(object sender, EventArgs e)
        {

            if (!this.IsTextSearchEnabled && this.silenceEvents == 0 && this.ItemsSourceProperty != null)
            {

                if (string.IsNullOrEmpty(this.Text))
                {
                    this.IsDropDownOpen = false;
                    if (this.ItemsSourceProperty != null)
                    {
                        this.ItemsSource = this.ItemsSourceProperty;
                    }
                    return;
                }
                if (this.Text.Length > 1)
                {
                    bool success = false;
                    List<object> dynamics = new List<object>();

                    foreach (var item in this.ItemsSourceProperty)
                    {
                        //找需要计算总数的行
                        foreach (System.Reflection.PropertyInfo p in item.GetType().GetProperties())
                        {


                            if (p.Name.Equals(this.LikeNames))
                            {
                                string values = p.GetValue(item).ToString();
                                if (values.Equals(this.Text))
                                {
                                    success = true;
                                }

                                if (values.Contains(this.Text) || values.Equals(this.Text))
                                {
                                    if (!dynamics.Contains(item))
                                    {
                                        dynamics.Add(item);
                                    }

                                }
                            }
                        }
                    }

                    if (!success)
                    {
                        this.ItemsSource = dynamics.Distinct();
                        this.IsDropDownOpen = true;
                    }
                    var prefix = Text.Length;
                    EditableTextBox.Select(prefix, prefix - prefix);
                }
            }
        }
    }
}
