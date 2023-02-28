using System;
using System.Windows.Input;

namespace Edsofta.Commands
{
    public class UserCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action DoWork;
        public UserCommand(Action work)
        {
            DoWork = work;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DoWork();
        }
    }
}
