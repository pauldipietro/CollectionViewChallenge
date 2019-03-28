using System;
using System.Linq;
using System.Reflection;
using ContextMenu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        public CollectionViewChallengePage()
        {
            InitializeComponent();
            SampleList.ItemsSource = Enumerable.Range(0, 300);
            SampleList.ItemTemplate = new DataTemplate(() =>
            {
                var cell = new CustomCell();
                cell.Content.SetBinding(WidthRequestProperty, new Binding
                {
                    Source = SampleList,
                    Path = WidthProperty.PropertyName
                });
                cell.SetBinding(BindingContextProperty, new Binding
                {
                    Source = cell.View,
                    Path = BindingContextProperty.PropertyName
                });
                cell.GetType().GetMethod(nameof(OnAppearing), BindingFlags.NonPublic | BindingFlags.Instance).Invoke(cell, null);
                cell.View.HeightRequest = 80;
                return cell.View;
            });
        }
    }
}