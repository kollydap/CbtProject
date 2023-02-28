using System;
using System.Windows.Input;

namespace Edsofta.Commands
{
    public class NavigateQuestionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action DoWork;
        public NavigateQuestionCommand(Action work)
        {
            DoWork = work;
        }
        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
            // check if the questions are finished then disable the button to return false
        }

        public void Execute(object parameter)
        {
            //Do Work is A delegate that is called when the button is Clicked
            DoWork();
        }
    }
}
