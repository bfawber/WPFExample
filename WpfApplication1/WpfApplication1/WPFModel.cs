using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class WPFModel
    {
        private String text = "TEST";
        public String Text
        {
            get
            {
                return text;
            }
        }
        public void doSomeShitToText()
        {
            text += "A";
        }
        public bool isValid()
        {
            return true;
        }
    }
}
