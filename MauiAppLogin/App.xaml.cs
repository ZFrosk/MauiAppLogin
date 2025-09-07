namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState ActivationState)
        {
            var window = base.CreateWindow(ActivationState);

            // Formatar a largura e a altura da janela do projeto.
            window.Width = 400;
            window.Height = 600;

            return window;
        }

    } // Fecha classe


}// Fecha namespace

