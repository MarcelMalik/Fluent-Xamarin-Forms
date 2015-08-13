using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentImage : FluentImageBase<FluentImage, Image>
    {
        public FluentImage ()
            : base ()
        {
        }

        public FluentImage (Image instance)
            : base (instance)
        {
        }
    }
}