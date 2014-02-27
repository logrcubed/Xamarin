// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace IPhoneHelloWorld
{
	[Register ("IPhoneHelloWorldViewController")]
	partial class IPhoneHelloWorldViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnClickMe { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblText { get; set; }

		[Action ("actBtn1:")]
		partial void actBtn1 (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btnClickMe != null) {
				btnClickMe.Dispose ();
				btnClickMe = null;
			}

			if (lblText != null) {
				lblText.Dispose ();
				lblText = null;
			}
		}
	}
}
