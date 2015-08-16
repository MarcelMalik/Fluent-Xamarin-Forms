using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentBaseMenuItemBase<TFluent, T> : FluentElementBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T : BaseMenuItem, new()
    {
        public FluentBaseMenuItemBase ()
            :base()
        {
        }

        public FluentBaseMenuItemBase (T instance)
            :base(instance)
        {
        }
    }
}