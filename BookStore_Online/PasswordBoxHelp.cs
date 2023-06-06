using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BookStore_Online
{
    public class PasswordBoxHelp
    {


        public static string  GetMyPassword(DependencyObject obj)
        {
            return (string )obj.GetValue(MyPasswordProperty);
        }

        public static void SetMyPassword(DependencyObject obj, string  value)
        {
            obj.SetValue(MyPasswordProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyPassword.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPasswordProperty =
            DependencyProperty.RegisterAttached("MyPassword", typeof(string ), typeof(PasswordBoxHelp));




        public static bool GetIsEnableBing(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsEnableBingProperty);
        }

        public static void SetIsEnableBing(DependencyObject obj, bool value)
        {
            obj.SetValue(IsEnableBingProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsEnableBing.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsEnableBingProperty =
            DependencyProperty.RegisterAttached("IsEnableBing", typeof(bool), typeof(PasswordBoxHelp), new PropertyMetadata(false,OnpasswordChanged));

        private static void OnpasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox pwd = d as PasswordBox;
            if (pwd == null) return;
            if ((bool)e.OldValue) 
            {
                pwd.PasswordChanged -= Pwd_PasswordChanged;
            }
            if ((bool)e.NewValue) 
            {
                pwd.PasswordChanged += Pwd_PasswordChanged;
            }
        }

        private static void Pwd_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox pwd = sender as PasswordBox;
            if (pwd == null) return;
            SetMyPassword(pwd,pwd.Password);
        }
    }
}
