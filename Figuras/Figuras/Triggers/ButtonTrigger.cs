using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Figuras.Triggers
{
    class ButtonTrigger : TriggerAction<ImageButton>
    {
        protected async override void Invoke(ImageButton sender)
        {
            await sender.ScaleTo(0.40, 50, Easing.CubicInOut);
            await sender.ScaleTo(1.05, 50, Easing.CubicOut);
        }
    }
}
