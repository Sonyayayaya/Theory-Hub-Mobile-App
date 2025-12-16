namespace TheoryHub
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("MLSection", typeof(Views.ML));
            Routing.RegisterRoute("ClassicMLFolder", typeof(Views.ClassicML));
            Routing.RegisterRoute("ClassicMLTheme1", typeof(Views.ClassicMLTheme1));
        }
    }
}
