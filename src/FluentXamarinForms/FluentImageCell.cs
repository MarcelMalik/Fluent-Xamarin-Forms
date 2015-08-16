using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentImageCell : FluentImageCellBase<FluentImageCell, ImageCell>
    {
        public FluentImageCell ()
            : base ()
        {
        }

        public FluentImageCell (ImageCell instance)
            : base (instance)
        {
        }
    }
}