using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentViewCell : FluentViewCellBase<FluentViewCell, ViewCell>
    {
        public FluentViewCell ()
            :base()
        {
        }

        public FluentViewCell (ViewCell instance)
            :base(instance)
        {
        }
    }
}