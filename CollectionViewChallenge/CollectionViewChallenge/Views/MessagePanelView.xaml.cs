using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessagePanelView : ContentView
    {
        public static BindableProperty SpacingProperty = BindableProperty.Create(nameof(Spacing), typeof(int), typeof(MessagePanelView), 10);

        public int Spacing
        {
            get { return (int)GetValue(SpacingProperty); }
            set { SetValue(SpacingProperty, value); }
        }

        #region Image

        public static BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(MessagePanelView), String.Empty);

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static BindableProperty ImageHeightRequestProperty = BindableProperty.Create(nameof(ImageHeightRequest), typeof(int), typeof(MessagePanelView), 200);

        public int ImageHeightRequest
        {
            get { return (int)GetValue(ImageHeightRequestProperty); }
            set { SetValue(ImageHeightRequestProperty, value); }
        }

        #endregion

        #region Message

        public static BindableProperty MessageProperty = BindableProperty.Create(nameof(Message), typeof(string), typeof(MessagePanelView), String.Empty);

        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        #endregion

        #region Button

        public static BindableProperty ButtonTextProperty = BindableProperty.Create(nameof(ButtonText), typeof(string), typeof(MessagePanelView), String.Empty);

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public static BindableProperty ButtonCommandProperty = BindableProperty.Create(nameof(ButtonCommand), typeof(ICommand), typeof(MessagePanelView));

        public ICommand ButtonCommand
        {
            get { return (ICommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }

        public static BindableProperty ButtonBackgroundColourProperty = BindableProperty.Create(nameof(ButtonBackgroundColour), typeof(Color), typeof(MessagePanelView), Color.Default);

        public Color ButtonBackgroundColour
        {
            get { return (Color)GetValue(ButtonBackgroundColourProperty); }
            set { SetValue(ButtonBackgroundColourProperty, value); }
        }

        public static BindableProperty ButtonTextColourProperty = BindableProperty.Create(nameof(ButtonTextColour), typeof(Color), typeof(MessagePanelView), Color.Default);

        public Color ButtonTextColour
        {
            get { return (Color)GetValue(ButtonTextColourProperty); }
            set { SetValue(ButtonTextColourProperty, value); }
        }

        public static BindableProperty ButtonIsVisibleProperty = BindableProperty.Create(nameof(ButtonIsVisible), typeof(bool), typeof(MessagePanelView), true);

        public bool ButtonIsVisible
        {
            get { return (bool)GetValue(ButtonIsVisibleProperty); }
            set { SetValue(ButtonIsVisibleProperty, value); }
        }

        #endregion

        public MessagePanelView()
        {
            InitializeComponent();
        }
    }
}