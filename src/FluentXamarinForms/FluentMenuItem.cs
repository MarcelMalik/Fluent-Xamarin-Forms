using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentMenuItem : FluentMenuItemBase<FluentMenuItem, MenuItem>
    {
        public FluentMenuItem ()
            :base()
        {
        }

        public FluentMenuItem (MenuItem instance)
            :base(instance)
        {
        }
    }
}