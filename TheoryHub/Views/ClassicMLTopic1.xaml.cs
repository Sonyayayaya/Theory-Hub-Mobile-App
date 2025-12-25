namespace TheoryHub.Views;

public partial class ClassicMLTopic1 : ContentPage
{
	public ClassicMLTopic1()
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

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        // Сбрасываем видимость всех элементов
        definition1.IsVisible = false;
        definition2.IsVisible = false;
        answer1.IsVisible = false;
        answer2.IsVisible = false;
    }
}