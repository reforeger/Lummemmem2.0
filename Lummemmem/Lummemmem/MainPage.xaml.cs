using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lummemmem
{
    public partial class MainPage : ContentPage
    {
        Random rnd = new Random();
        public MainPage()
        {
            InitializeComponent();
        }
        private void btn1_Clicked(object sender, EventArgs e)
        {
            stext.Text = "Standart colors";
            small.BackgroundColor = Color.White;
            big.BackgroundColor = Color.White;
            under.BackgroundColor = Color.Gray;
        }
        private void btn_Clicked(object sender, EventArgs e)
        {
            stext.Text = "The stand is randomly painted";
            Color randomColor1 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            under.BackgroundColor = randomColor1;
        }

        private void inv_Clicked(object sender, EventArgs e)
        {
            stext.Text = "Snowman is invisble";
            small.Opacity = 0;
            small.BorderColor = Color.White;
            big.Opacity = 0;
            big.BorderColor = Color.White;
        }

        private void vis_Clicked(object sender, EventArgs e)
        {
            stext.Text = "Snowman is visible";
            small.Opacity = 1;
            small.BorderColor = Color.Gray;
            big.Opacity = 1;
            big.BorderColor = Color.Gray;
        }

        private void ran_Clicked(object sender, EventArgs e)
        {
            stext.Text = "The snowman is randomly painted";
            Color randomColor2 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Color randomColor3 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            small.BackgroundColor = randomColor2;
            big.BackgroundColor = randomColor3;
        }
    }
}