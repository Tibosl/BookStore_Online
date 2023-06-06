using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BookStore_Online
{
    public class CustomButton : Button
    {
        /// <summary>
        /// 依赖属性
        /// </summary>
        public CornerRadius ButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(ButtonCornerRadiusProperty); }
            set { SetValue(ButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonCornerRadiusProperty =
            DependencyProperty.Register("ButtonCornerRadius", typeof(CornerRadius), typeof(CustomButton));



        public Brush ButtonClickBrush
        {
            get { return (Brush)GetValue(ButtonClickBrushProperty); }
            set { SetValue(ButtonClickBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonClickBrushProperty =
            DependencyProperty.Register("ButtonClickBrush", typeof(Brush), typeof(CustomButton)); 
    }
}
