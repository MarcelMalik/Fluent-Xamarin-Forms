using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentFrame : FluentFrameBase<FluentFrame, Frame>
    {
        public FluentFrame ()
            : base ()
        {
        }

        public FluentFrame (Frame instance)
            : base (instance)
        {
        }
    }
}