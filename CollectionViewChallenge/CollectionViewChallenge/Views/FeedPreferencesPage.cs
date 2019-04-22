using System.Collections.ObjectModel;
using System.Linq;
using CollectionViewChallenge.Extensions;
using CollectionViewChallenge.ValueConverters;
using Xamarin.Forms;

namespace CollectionViewChallenge.Views
{
    public class FeedPreferencesPage : ContentPage
    {
        public static Color QantasLightGray = Color.FromRgb(243, 243, 243);
        public static Color QantasRed = Color.FromHex("E80000");
        public static Color QantasCyan = Color.FromHex("7ADFDD");
        public static Color QantasText = Color.FromHex("393939");
        
        public static string RegularFont =>
            Device.RuntimePlatform == Device.iOS
                ? "Ciutadella-Rg"
                : "ciutadella_regular.ttf#Regular";

        public static string MediumFont =>
            Device.RuntimePlatform == Device.iOS
                ? "Ciutadella-Md"
                : "ciutadella_medium.ttf#Regular";

        public CollectionView CollectionView;
        public ObservableCollection<FeedCategory> FeedCategories;

        public FeedPreferencesPage()
        {
            Visual = VisualMarker.Material;
            BackgroundColor = QantasLightGray;

            Shell.SetTitleView(this, GetTitleView());

            Content = GetContent();
            SetupBindings();
        }

        private View GetTitleView()
            => new Label
            {
                FontFamily = MediumFont,
                FontSize = 20,
                TextColor = QantasText,
                Text = "Feed preferences",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };

        private int NavOffset = Device.RuntimePlatform == Device.iOS ? 88 : 0;
        private View GetContent() 
            => new Grid
            {
                TranslationY = NavOffset,
                BackgroundColor = QantasLightGray, 
                Padding = 0,
                RowSpacing = 0, 
                VerticalOptions = LayoutOptions.StartAndExpand, 
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }, 
                    new RowDefinition { Height = new GridLength(85, GridUnitType.Absolute) },   
                    new RowDefinition { Height = new GridLength(NavOffset + 2, GridUnitType.Absolute) },      
                }, 
                Children =
                {
                    new CollectionView
                    {
                        Margin = new Thickness(10, 0), 
                        ItemTemplate = new DataTemplate(() => GetCellTemplate()),
                        ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical),
                        SelectionMode = SelectionMode.Multiple,
                        ItemSizingStrategy = ItemSizingStrategy.MeasureFirstItem,
                    }
                    .Row(0) 
                    .Assign(out CollectionView),
                    
                    new Frame
                    {
                        BackgroundColor = Color.White, 
                        Padding = new Thickness(18, 18, 18, 22), 
                        Content = new Button
                        {
                            Text = "Save",
                            BackgroundColor = QantasRed,
                            
                            // strangely they don't seem to use their own font here
                            Font = Font.SystemFontOfSize(16, FontAttributes.Bold), 
                        },
                    }
                    .Row(1)
                } 
            };

        private readonly BoolToOpacityConverter boolToOpacityConverter = new BoolToOpacityConverter();
        private View GetCellTemplate()
            => new ContentView 
            { 
                BackgroundColor = QantasLightGray,
                InputTransparent = true, 
                CascadeInputTransparent = true,
                Content = new Frame
                {                
                    HasShadow = false,
                    BorderColor = Color.Transparent,
                    BackgroundColor = QantasLightGray,
                    Padding = 6,
                    Content = new Frame
                    {
                        Visual = VisualMarker.Material,
                        BorderColor = QantasCyan,
                        CornerRadius = 2,
                        Padding = 0,
                        Content = new Grid
                        {
                            RowDefinitions =
                            {
                                new RowDefinition { Height = 115 },
                                new RowDefinition { Height = 60 }
                            },
                            ColumnDefinitions =
                            {
                                new ColumnDefinition { },
                                new ColumnDefinition { Width = 25 }
                            },
                            Children =
                            {
                                new Image
                                {
                                     BackgroundColor = QantasRed,
                                     Aspect = Aspect.AspectFill
                                }
                                .Bind(Image.SourceProperty, nameof(FeedCategory.Image))
                                .Row(0).Col(0).ColSpan(2),

                                new Label
                                {
                                     Margin = new Thickness(10, 5),
                                     FontFamily = RegularFont,
                                     FontSize = 16,
                                     TextColor = QantasText,
                                }
                                .Bind(Label.TextProperty, nameof(FeedCategory.Name))
                                .Row(1),

                                new Image
                                {
                                     Margin = new Thickness(0, 5, 0, 0),
                                     Source = ImageSource.FromFile("ic_confirmed_16.png"),
                                     HorizontalOptions = LayoutOptions.Start,
                                     VerticalOptions = LayoutOptions.Start,
                                     HeightRequest = 18,
                                }
                                .Bind(OpacityProperty, nameof(FeedCategory.Selected), converter: boolToOpacityConverter) 
                                .Row(1).Col(1),
                            }
                        },
                        Opacity = 0
                    }.Invoke(x => x.FadeTo(1, 200)) // woof 
                } 
            };

        private void SetupBindings() 
        {
            FeedCategories = 
                Enumerable
                    .Range(0, 10) // so we can test with more data 
                    .SelectMany(_ => _categories.Select(FeedCategory.ForCategory)) 
                    .ToObservableCollection();

            CollectionView.SelectionChanged += (sender, e) =>
            {
                // this is not so great
                var selection = e.CurrentSelection.ToSet();
                foreach (FeedCategory item in FeedCategories) 
                    item.Selected = selection.Contains(item); 
            };
                        
            CollectionView.ItemsSource = FeedCategories;
        }

        private string[] _categories =
        {
            "Travel",
            "Food & Wine",
            "Smart Money",
            "Entertainment & Experiences",
            "Health & Wellness",
            "Fashion & Shopping",
            "Offers & Discounts",
            "Competitions",
            "Sport",
            "Business Rewards & Advice",
            "Family & Kids",
            "Technology & Innovation"
        };
    }
}