using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HomeBaze
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var button = new Button()
            {
                Text = "Click me."
            };
            button.Clicked += OnClick;
            void OnClick(object sender, EventArgs e) { Console.WriteLine("lol button has been pressed"); };

            InitializeComponent();
        }
    }
}
