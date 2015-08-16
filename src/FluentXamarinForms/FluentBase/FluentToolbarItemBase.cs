using System;
using Xamarin.Forms;
using System.Windows.Input;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{


    public abstract class FluentToolbarItemBase<TFluent, T> : FluentMenuItemBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T : ToolbarItem, new()
    {
        public FluentToolbarItemBase ()
            : base ()
        {
        }

        public FluentToolbarItemBase (T instance)
            : base (instance)
        {
        }

        public TFluent Order (ToolbarItemOrder order)
        {
            this.BuilderActions.Add (menuItem => {
                    menuItem.Order = order;
                });

            return this as TFluent;
        }

        public TFluent Priority (int priority)
        {
            this.BuilderActions.Add (menuItem => {
                    menuItem.Priority = priority;
                });

            return this as TFluent;
        }
    }
}