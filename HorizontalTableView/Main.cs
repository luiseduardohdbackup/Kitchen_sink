//https://gist.github.com/1261104
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XibLess
{
	public class Application
	{
		static void Main (string[] args)
		{
			try
			{
				UIApplication.Main (args, null, "XibLessAppDelegate");
			}
			catch (Exception ex)
			{	
				// any unhandled exceptions end up here
				Console.WriteLine(ex);
			}
		}
	}
	
	[MonoTouch.Foundation.Register("XibLessAppDelegate")]
	public partial class XibLessAppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		//UINavigationController navcontroller;
		HorizontalTableView viewcontroller;
		UIView view;

		public override bool FinishedLaunching (UIApplication application, NSDictionary options)
		{
			window = new UIWindow();

			//navcontroller = new UINavigationController();

			viewcontroller = new UIViewController();
			//viewcontroller.Title = "XibLess";

			view = new UIView(new RectangleF(0, 0, 320, 640));
			//view.BackgroundColor = UIColor.Blue;

			viewcontroller.Add(view);
			//navcontroller.PushViewController(viewcontroller, false);

			//window.AddSubview (navcontroller.View);
			window.AddSubview (viewcontroller.View);
			window.MakeKeyAndVisible ();
			
			return true;
		}

	}
}