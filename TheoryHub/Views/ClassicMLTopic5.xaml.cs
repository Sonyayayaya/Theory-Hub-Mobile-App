namespace TheoryHub.Views;

public partial class ClassicMLTopic5 : ContentPage
{
	public ClassicMLTopic5()
	{
		InitializeComponent();
	}

    private void OnTermFrameTapped(object sender, EventArgs e)
    {
        if (sender is Frame frame)
        {
            // Находим соответствующий контент
            var parent = frame.Parent as StackLayout;
            if (parent != null && parent.Children.Count > 1)
            {
                if (parent.Children[1] is Label contentLabel)
                {
                    contentLabel.IsVisible = !contentLabel.IsVisible;
                }
            }
        }
    }

    private void OnQuestionFrameTapped(object sender, EventArgs e)
    {
        if (sender is Frame frame)
        {
            // Находим соответствующий контент
            var parent = frame.Parent as StackLayout;
            if (parent != null && parent.Children.Count > 1)
            {
                if (parent.Children[1] is Label contentLabel)
                {
                    contentLabel.IsVisible = !contentLabel.IsVisible;
                }
            }
        }
    }
}