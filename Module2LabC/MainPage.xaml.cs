using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module2LabC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string code = "";
        string message = "";

        void DotClicked(object sender, EventArgs e)
        {
            code += ".";
            output_code.Text = code;
        }

        void DashClicked(object sender, EventArgs e)
        {
            code += "-";
            output_code.Text = code;
        }

        void SpaceClicked(object sender, EventArgs e)
        {
            message += Morse.MorseCoder(code);
            output.Text = message;
            code = "";
            output_code.Text = code;
        }
    }
}
