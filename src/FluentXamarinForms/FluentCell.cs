using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public abstract class FluentCell<T> : FluentCellBase<FluentCell<T>, T>
        where T : Cell, new()
    {
        public FluentCell ()
            : base ()
        {
        }

        public FluentCell (T instance)
            : base (instance)
        {
        }
    }
}