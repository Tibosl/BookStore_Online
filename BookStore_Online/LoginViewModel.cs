using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace BookStore_Online
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private LogingModel _loginMD = new LogingModel();

        public LoginCommand _loginCommand { get; set; }
        public MainWindow _mainWin { get; set; }
        bool canExecute() 
        {
            return true;
        }
        public LoginViewModel(MainWindow main) 
        {
            _mainWin = main;
            _loginCommand = new LoginCommand(LoginMainCheck, canExecute);
        }
        public string UserName
        {
            get
            {
                return _loginMD.UserName;
            }
            set
            {
                _loginMD.UserName = value;
                SetPropertyString("UserName");
            }
        }
        public string UserPassWD
        {
            get
            {
                return _loginMD.UserPassWD;
            }
            set
            {
                _loginMD.UserPassWD = value;
                SetPropertyString("UserPassWD");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void SetPropertyString(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public void LoginMainCheck()
        {
            if (UserName == "liyu" && UserPassWD == "123")
            {
                IndexMain indexMain = new IndexMain();
                indexMain.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                indexMain.Show();
                _mainWin.Hide();
            }
            else
            {
                MessageBox.Show("用户名和密码不正确！");
                UserPassWD = string.Empty;
                UserName = string.Empty;
                return;
            }
        }
    }
}
