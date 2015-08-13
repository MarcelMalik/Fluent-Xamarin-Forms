using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentTextCell : FluentTextCellBase<FluentTextCell, TextCell>
    {
        public FluentTextCell ()
            : base ()
        {
        }

        public FluentTextCell (TextCell instance)
            : base (instance)
        {
        }
    }
}