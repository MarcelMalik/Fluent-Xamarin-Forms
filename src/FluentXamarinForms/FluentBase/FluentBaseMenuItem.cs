using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentBaseMenuItem<TFluent, T> : FluentElement<TFluent, T>
        where TFluent: FluentBase<T>
        where T : BaseMenuItem, new()
    {
        public FluentBaseMenuItem ()
            :base()
        {
        }

        public FluentBaseMenuItem (T instance)
            :base(instance)
        {
        }
    }
}