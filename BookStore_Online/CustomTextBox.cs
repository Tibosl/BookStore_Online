using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BookStore_Online
{
    public class CustomTextBox : TextBox
    {
        public CornerRadius CustomTextRaius
        {
            get { return (CornerRadius)GetValue(CustomTextRaiusProperty); }
            set { SetValue(CustomTextRaiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomTextRaiusProperty =
            DependencyProperty.Register("CustomTextRaius", typeof(CornerRadius), typeof(CustomTextBox));


    }
}
