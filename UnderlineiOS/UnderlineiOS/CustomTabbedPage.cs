using System;
using Xamarin.Forms;

namespace UnderlineiOS
{
    public class CustomTabbedPage : TabbedPage
    {
        public readonly static BindableProperty UnderLineIndicatorColorProperty =
            BindableProperty.Create("UnderLineIndicatorColor",
                typeof(Color),
                typeof(CustomTabbedPage),
                Color.Default,
                BindingMode.OneWay,
                null,
                null,
                null,
                null,
                null);
        public Color UnderLineIndicatorColor
        {
            get
            {
                return (Color)base.GetValue(CustomTabbedPage.UnderLineIndicatorColorProperty);
            }
            set
            {
                base.SetValue(CustomTabbedPage.UnderLineIndicatorColorProperty, value);
            }
        }

        public readonly static BindableProperty TitleColorUnSelectedProperty =
            BindableProperty.Create("TitleColorUnSelected",
                typeof(Color),
                typeof(CustomTabbedPage),
                Color.Default,
                BindingMode.OneWay,
                null,
                null,
                null,
                null,
                null);
        public Color TitleColorUnSelected
        {
            get
            {
                return (Color)base.GetValue(CustomTabbedPage.TitleColorUnSelectedProperty);
            }
            set
            {
                base.SetValue(CustomTabbedPage.TitleColorUnSelectedProperty, value);
            }
        }
    }
}
