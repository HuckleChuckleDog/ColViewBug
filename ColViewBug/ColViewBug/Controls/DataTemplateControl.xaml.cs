using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColViewBug.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataTemplateControl : ContentView
    {
        public DataTemplateControl()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty LabelTextProperty = BindableProperty.Create(nameof(LabelText), typeof(string), typeof(DataTemplateControl));
        public static readonly BindableProperty TapGestCommandProperty = BindableProperty.Create(nameof(TapGestCommand), typeof(ICommand), typeof(DataTemplateControl));

        public string LabelText
        {
            get => ((string)GetValue(LabelTextProperty));
            set => SetValue(LabelTextProperty, value);
        }

        public ICommand TapGestCommand
        {
            get => ((ICommand)GetValue(TapGestCommandProperty));
            set => SetValue(TapGestCommandProperty, value);
        }
    }
}