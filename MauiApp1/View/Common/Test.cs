using System;

using UIKit;
using Foundation;

namespace MauiApp1.View.Common;

[Register("Test")]
public partial class Test : UIViewController
{
    public Test() : base("Test", null)
    {
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();
        // Perform any additional setup after loading the view, typically from a nib.
    }

    public override void DidReceiveMemoryWarning()
    {
        base.DidReceiveMemoryWarning();
        // Release any cached data, images, etc that aren't in use.
    }
}