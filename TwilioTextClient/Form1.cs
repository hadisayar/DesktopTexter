using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwilioTextClient
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            Translation numTranslator = new Translation();
            ENUMAPI selection;
            TexterController controller = new TexterController();
            string fromNumber = fromText.Text;
            fromText.Clear();
            string toNumber = toText.Text;
            toText.Clear();
            fromText.Text = numTranslator.translate_number(fromNumber);
            toText.Text = numTranslator.translate_number(toNumber);
            string api = apiBox.SelectedText;
            switch (api)
            {
                case "Twilio" :
                    selection = ENUMAPI.Twilio;
                    break;
                case "smsglobal":
                    selection = ENUMAPI.smsglobal;
                    break;
                case "Clockwork":
                    selection = ENUMAPI.Clockwork;
                    break;
                default:
                    selection = ENUMAPI.Twilio;
                    break;
            }
            Status.Text = controller.control(selection, toText.Text, fromText.Text, messageBox.Text);
        }

    }
}
