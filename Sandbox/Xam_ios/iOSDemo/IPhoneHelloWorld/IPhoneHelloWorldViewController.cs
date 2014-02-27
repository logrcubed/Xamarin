using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace IPhoneHelloWorld
{
	public partial class IPhoneHelloWorldViewController : UIViewController
	{
		private int counter = 0;

		public IPhoneHelloWorldViewController () : base ("IPhoneHelloWorldViewController", null)
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

			this.btnClickMe.TouchUpInside += (sender, e) => {
				this.counter++;
				this.lblText.Text = "Click count is " + counter;
			};
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void actBtn1 (MonoTouch.Foundation.NSObject sender)
		{
			this.lblText.Text = "You clicked " + ((UIButton)sender).CurrentTitle;
		}
	}
}

