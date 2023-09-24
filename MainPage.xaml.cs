namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public bool imageClicked = false;
        public bool image1Clicked = false;
        public string expect = "EXPECTATION";
        public string reality = "REALITY";
        public MainPage()
        {
            InitializeComponent();
        }

        private void onImageButton1Clicked(object sender, EventArgs e)
        {
            if (imageClicked)
            {
                imagebutton1.Source = "expectation1.jpg";
                label1.Text = expect;
            }
            else
            {
                imagebutton1.Source = "reality1.jpg";
                label1.Text = reality;
            }
            imageClicked = !imageClicked;

        }

        public void onImageButton2Clicked(object sender, EventArgs e)
        {
            if (image1Clicked)
            {
                imagebutton2.Source = "expectation2.jpg";
                label2.Text = expect;
            }
            else
            {  
                imagebutton2.Source = "reality2.jpg";
                label2.Text= reality;
            }
            image1Clicked = !image1Clicked;
        }
    }
}