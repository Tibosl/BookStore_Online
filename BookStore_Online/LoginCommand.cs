using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookStore_Online
{
    public class LoginCommand : ICommand
    {
        readonly Action execute;
        readonly Func<bool> _canExecute;
        public LoginCommand(Action action, Func<bool> func)
        {
            execute = action;
            _canExecute = func;
        }
        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
                return true;
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            execute();
        }
    }
}
