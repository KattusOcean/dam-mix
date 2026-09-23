namespace EjemploStackLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void bOrientacionClick(object sender, EventArgs e)
        {
            if (slContenido.Orientation == StackOrientation.Horizontal) {
                slContenido.Orientation = StackOrientation.Vertical;
            }
            else {
                slContenido.Orientation = StackOrientation.Horizontal;
            }
        }

        private void bVisibilidadClick(object sender, EventArgs e)
        {
            if ()
        }
    }
}
