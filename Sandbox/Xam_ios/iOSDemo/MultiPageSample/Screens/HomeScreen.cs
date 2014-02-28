using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MultiPageSample
{
	public partial class HomeScreen : UIViewController
	{
		HelloWorld helloWorldScreen;
		HelloUniverse helloUniverseScreen;

		public HomeScreen () : base ("HomeScreen", null)
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

			this.btnHelloWorld.TouchUpInside += (sender, e) => {
			
				if(this.helloWorldScreen == null)
					helloWorldScreen = new HelloWorld();

				this.NavigationController.PushViewController(helloWorldScreen, true);

			};

			this.btnHelloUniverse.TouchUpInside += (sender, e) => {

				if(this.helloUniverseScreen == null)
					helloUniverseScreen = new HelloUniverse();

				this.NavigationController.PushViewController(helloUniverseScreen, true);
			};
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

