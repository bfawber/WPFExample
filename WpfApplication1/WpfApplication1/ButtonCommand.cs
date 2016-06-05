using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{

    // Needs to implement the ICommand for binding to buttons and such
    class ButtonCommand : ICommand
    {

        // Generic delegates to decouple from ViewModel
        private Action whatToExecute;
        private Func<bool> whenToExecute;

        // Initializes the delegates
        public ButtonCommand(Action what, Func<bool> when)
        {
            this.whatToExecute = what;
            this.whenToExecute = when;
        }

        public event EventHandler CanExecuteChanged;

        // Checks if the command can be run
        public bool CanExecute(object parameter)
        {
            return whenToExecute();
        }

        // what happens when the command is run
        public void Execute(object parameter)
        {
            whatToExecute();
        }
    }
}
