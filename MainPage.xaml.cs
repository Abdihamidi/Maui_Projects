namespace Coffee_Demo_App
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        private void myButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Home());
        }

    }

}
