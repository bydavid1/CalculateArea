using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Figuras.Triggers
{
   public class ButtonImageTrigger : TriggerAction<Button>
    {
        protected async override void Invoke(Button sender)
        {
            await sender.ScaleTo(0.40, 50, Easing.Linear);
            await sender.ScaleTo(1.05, 50, Easing.CubicOut);
        }
    }
}
