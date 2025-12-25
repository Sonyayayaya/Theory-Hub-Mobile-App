namespace TheoryHub
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("MLSection", typeof(Views.ML));
            Routing.RegisterRoute("ClassicMLFolder", typeof(Views.ClassicML));
            Routing.RegisterRoute("ClassicMLTopic1", typeof(Views.ClassicMLTopic1));
            Routing.RegisterRoute("ClassicMLTopic2", typeof(Views.ClassicMLTopic2));
            Routing.RegisterRoute("ClassicMLTopic3", typeof(Views.ClassicMLTopic3));
            Routing.RegisterRoute("ClassicMLTopic4", typeof(Views.ClassicMLTopic4));
            Routing.RegisterRoute("ClassicMLTopic5", typeof(Views.ClassicMLTopic5));
            Routing.RegisterRoute("ClassicMLTopic6", typeof(Views.ClassicMLTopic6));
            Routing.RegisterRoute("ClassicMLTopic7", typeof(Views.ClassicMLTopic7));
        }
    }
}
