using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentListView : FluentListViewBase<FluentListView, ListView>
    {
        public FluentListView ()
            : base ()
        {
        }

        public FluentListView (ListView instance)
            : base (instance)
        {
        }
    }
}