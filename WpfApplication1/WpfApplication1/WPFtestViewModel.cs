using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
    // INotifyPropertyChanged is needed to update UI
    class WPFtestViewModel : INotifyPropertyChanged
    {
        // Stores the models
        private WPFModel model;

        // Creates commands for actions in the UI
        private ButtonCommand objCommand;
        
        // Initialize the model(s) and commands
        public WPFtestViewModel() {
            model = new WPFModel();

            // Note the generic delegates passed in to decouple view models and commands
            objCommand = new ButtonCommand(doSomeShitToText, model.isValid);
        }

        // For binding with the button
        public ICommand BtnClick
        {
            get
            {
                return objCommand;
            }
        }

        // For binding with the text box
        private string sampleText = "TEST";

        // For binding with the text box
        public string SampleText
        {
            get
            {
                return sampleText;
            }
            set
            {
                sampleText = value;
            }
        }

        // Simple function for when the button is clicked
        public void doSomeShitToText()
        {
            // Note how the model handles the background work
            model.doSomeShitToText();

            //Update for UI
            sampleText = model.Text;

            // Sanity Check
            if(PropertyChanged != null)
            {
                // Notify UI
                PropertyChanged(this, new PropertyChangedEventArgs("SampleText"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
