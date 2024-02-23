namespace _2Buy.Views;

public partial class MainPage : ContentPage
{
    readonly List<string> List = ["Banana", "Chocolate", "Feijão", "Carne", "Sabão em pó", "Pimenta do reinohvgvjuyvkcktctkk ugvuvou", "Suco", "Coca-cola", "Filé de tilápia", "Chiclete"]; 

    public MainPage()
    {
        InitializeComponent();
        collectionView.ItemsSource = List;
    }
}
