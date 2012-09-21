using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Kitchen_sink.Touch
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			try
			{
				UIApplication.Main (args, null, "AppDelegate");
			}
			catch (Exception ex)
			{	
				// any unhandled exceptions end up here
				Console.WriteLine(ex);
			}
		}
	}
}
