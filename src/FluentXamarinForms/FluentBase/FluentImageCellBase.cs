using System;
using Xamarin.Forms;
using System.Windows.Input;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public class FluentImageCellBase<TFluent, T> : FluentTextCellBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T : ImageCell, new()
    {
        public FluentImageCellBase ()
            : base ()
        {
        }

        public FluentImageCellBase (T instance)
            : base (instance)
        {
        }
    }
}