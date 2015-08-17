using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public class FluentSwitchBase<TFluent, T> : FluentViewBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: Switch, new()
    {
        public FluentSwitchBase ()
            : base ()
        {
        }

        public FluentSwitchBase (T instance)
            : base (instance)
        {
        }

        public TFluent IsToggled (bool value)
        {
            this.BuilderActions.Add (switchControl => {
                switchControl.IsToggled = value;
            });

            return this as TFluent;
        }

        public TFluent BindIsToggled (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (switchControl => {
                switchControl.SetBinding (Switch.IsToggledProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindIsToggled<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (switchControl => {
                switchControl.SetBinding<TSource> (Switch.IsToggledProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }
    }
}