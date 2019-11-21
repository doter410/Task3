using Xamarin.Forms;

namespace VideoPlayerDemos
{

    public partial class Editorrr : ContentPage
    {
        public Editorrr()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            Editor1.FontSize = Slider1.Value;
        }

        private void SliderValue(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                Editor1.FontSize = e.NewValue;

            }
        }
    }
}