using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentToolbarItem : FluentToolbarItemBase<FluentToolbarItem, ToolbarItem>
    {
        public FluentToolbarItem ()
            : base ()
        {
        }

        public FluentToolbarItem (ToolbarItem instance)
            : base (instance)
        {
        }
    }
}