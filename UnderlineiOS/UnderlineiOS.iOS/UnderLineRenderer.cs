using System;
using CoreGraphics;
using UIKit;
using UnderlineiOS.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(TabbedPage),typeof(UnderLineRenderer))]
namespace UnderlineiOS.iOS
{
    public class UnderLineRenderer : TabbedRenderer
    {
        UITabBarController tabbedController;
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                tabbedController = (UITabBarController)ViewController;
            }
        }

        public override void ViewWillAppear(bool animated)
        {
            if (base.ViewControllers != null)
            {
                UITabBar.Appearance.SelectionIndicatorImage = UndeLineColorPosition(Color.Red.ToUIColor(), new CGSize(UIScreen.MainScreen.Bounds.Width / base.ViewControllers.Length, tabbedController.TabBar.Bounds.Size.Height + 4), new CGSize(UIScreen.MainScreen.Bounds.Width / base.ViewControllers.Length, 4));
            }
            base.ViewWillAppear(animated);
        }

        UIImage UndeLineColorPosition(UIColor color, CGSize size, CGSize lineSize)
        {
            var rect = new CGRect(0, 0, size.Width, size.Height);
            var rectLine = new CGRect(0, size.Height - lineSize.Height, lineSize.Width, lineSize.Height);
            UIGraphics.BeginImageContextWithOptions(size, false, 0);
            UIColor.Clear.SetFill();
            UIGraphics.RectFill(rect);
            color.SetFill();
            UIGraphics.RectFill(rectLine);
            var img = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return img;
        }
    }
}
