using System;
using System.Windows.Input;


namespace Edsofta.Commands
{
    public class ActivationCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action DoWork;
        public ActivationCommand(Action work)
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
