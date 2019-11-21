using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace VideoPlayerDemos
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent(); 
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlayWebVideoPage());
        }
        private async void Button2_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entryyy());
        }
        private async void Button3_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Editorrr());
        }

       
    }
}