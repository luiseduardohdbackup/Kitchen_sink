
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

namespace Kitchen_sink.Touch
{
	public partial class ViewController : UIViewController
	{
//		static bool UserInterfaceIdiomIsPhone {
//			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
//		}

		public ViewController ()
			//: base (UserInterfaceIdiomIsPhone ? "ViewController_iPhone" : "ViewController_iPad", null)
			: base ()
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			RectangleF screenRect = UIScreen.MainScreen.Bounds;
			float screenWidth = screenRect.Size.Width;
			float screenHeight = screenRect.Size.Height;
			UILabel label=new UILabel(new RectangleF(0,0,100,20));
			string s="Hola Mundo";
			NSString nsString=new NSString(s);
			SizeF stringSize=nsString.StringSize(label.Font);
			//label.Text=s;
			UIGraphics.GetCurrentContext();
			//CGContext
			//CGContextGetTextWidthAndHeight
			label=new UILabel(new RectangleF(screenWidth/2-stringSize.Width/2,screenHeight/2-stringSize.Height/2,stringSize.Width,stringSize.Height));
			label.Text=s;
			this.View.AddSubview(label);
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			//ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
//			if (UserInterfaceIdiomIsPhone) {
//				return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
//			} else {
				return true;
//			}
		}
	}
}

