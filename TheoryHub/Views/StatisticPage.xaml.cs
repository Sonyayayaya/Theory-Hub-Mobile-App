namespace TheoryHub.Views;

public partial class StatisticPage : ContentPage
{
	public StatisticPage()
	{
		InitializeComponent();
	}

    private void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        // Обработка выбранной даты (e.NewDate)
        System.Diagnostics.Debug.WriteLine($"Выбрана дата: {e.NewDate.ToShortDateString()}");
    }
}