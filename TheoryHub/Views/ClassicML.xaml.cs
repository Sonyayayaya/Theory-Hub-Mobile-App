namespace TheoryHub.Views;

[QueryProperty(nameof(SectionName), "Name")]
public partial class ClassicML : ContentPage
{
    public string SectionName { get; set; } = "DefaultName";
    public ClassicML()
	{
		InitializeComponent();
	}

    private async void OnSectionSelected(object sender, SelectionChangedEventArgs e)
    {
        // Проверяем, что что-то было выбрано
        if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
        {
            // Получаем выбранный объект Section
            var selectedSection = e.CurrentSelection[0] as Models.Theme;

            if (selectedSection != null)
            {
                // 1. Снимаем выделение сразу, чтобы пользователь мог вернуться 
                //    на эту страницу и снова нажать на тот же элемент.
                ((CollectionView)sender).SelectedItem = null;

                // 2. Выполняем навигацию на новую страницу
                //    (Предполагается, что у вас настроена навигация NavigationPage или Shell)
                await Shell.Current.GoToAsync($"ClassicMLTheme1?Name={selectedSection.NavigationTarget}");

                // Пример навигации в Xamarin.Forms с NavigationPage.PushAsync:
                // await Navigation.PushAsync(new DetailPage(selectedSection)); 
            }
        }
    }
}