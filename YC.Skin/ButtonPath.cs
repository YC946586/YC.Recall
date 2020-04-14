using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace YC.Skin
{
    public class ButtonPath : Button
    {
     
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ButtonPath), new PropertyMetadata(""));
        //定义Imagesource依赖属性


        public static readonly DependencyProperty RemarkProperty =
    DependencyProperty.Register("Remark", typeof(string), typeof(ButtonPath), new PropertyMetadata(""));
        public static readonly DependencyProperty ImgPathProperty
        = DependencyProperty.Register("ImgPath", typeof(ImageSource), typeof(ButtonPath), null);

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

        public string Remark
        {
            get { return (string)GetValue(RemarkProperty); }
            set { SetValue(RemarkProperty, value); }
        }

        /// <summary>
        /// 弹簧式放大
        /// </summary>
        /// <param name="element"></param>
        public static void ScaleEasingInAnimation(FrameworkElement element)
        {
            ScaleTransform scale = new ScaleTransform();
            element.RenderTransform = scale;
            element.RenderTransformOrigin = new Point(0.7, 0.7);//定义圆心位置
            EasingFunctionBase easing = new ElasticEase()
            {
                EasingMode = EasingMode.EaseOut,            //公式
                Oscillations = 3,                           //抖动次数
                Springiness = 20                            //弹簧刚度
            };
            DoubleAnimation scaleAnimation = new DoubleAnimation()
            {
                From = 1,                                 //起始值
                To = 1.2,                                     //结束值
                EasingFunction = easing,                    //缓动函数
                Duration = new TimeSpan(0, 0, 0, 1, 100),    //动画播放时间
                FillBehavior = FillBehavior.HoldEnd          //动画完成时保持为终值
            };
            AnimationClock clock = scaleAnimation.CreateClock();
            scale.ApplyAnimationClock(ScaleTransform.ScaleXProperty, clock, HandoffBehavior.Compose);
            scale.ApplyAnimationClock(ScaleTransform.ScaleYProperty, clock, HandoffBehavior.Compose);
        }
        /// <summary>
        /// 弹簧式缩小
        /// </summary>
        /// <param name="element"></param>
        public static void ScaleEasingOutAnimation(FrameworkElement element)
        {

            //ScaleTransform scale = new ScaleTransform();  //旋转
            //element.RenderTransform = scale;
            ////定义圆心位置
            //element.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);
            ////定义过渡动画,power为过度的强度
            //EasingFunctionBase easeFunction = new PowerEase()
            //{
            //    EasingMode = EasingMode.EaseInOut,
            //    Power=2,
            //};

            //DoubleAnimation scaleAnimation = new DoubleAnimation()
            //{
            //    From = 1.2,                                   //起始值
            //    To = 1,                                     //结束值
            //    FillBehavior = FillBehavior.HoldEnd,
            //    Duration = new TimeSpan(0, 0, 0, 1, 0),    //动画播放时间
            //};
            //scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
            //scale.BeginAnimation(ScaleTransform.ScaleYProperty, scaleAnimation);


            ScaleTransform scale = new ScaleTransform();
            element.RenderTransform = scale;
            element.RenderTransformOrigin = new Point(0.7, 0.7);//定义圆心位置
            EasingFunctionBase easing = new ElasticEase()
            {
                EasingMode = EasingMode.EaseOut,            //公式
                Oscillations = 3,                           //抖动次数
                Springiness = 20                            //弹簧刚度
            };
            DoubleAnimation scaleAnimation = new DoubleAnimation()
            {
                From = 1.2,                                 //起始值
                To = 1,                                     //结束值
                EasingFunction = easing,                    //缓动函数
                Duration = new TimeSpan(0, 0, 0, 1, 100),    //动画播放时间
                FillBehavior = FillBehavior.HoldEnd          //动画完成时保持为终值
            };
            AnimationClock clock = scaleAnimation.CreateClock();
            scale.ApplyAnimationClock(ScaleTransform.ScaleXProperty, clock, HandoffBehavior.Compose);
            scale.ApplyAnimationClock(ScaleTransform.ScaleYProperty, clock, HandoffBehavior.Compose);
        }

    }
}
