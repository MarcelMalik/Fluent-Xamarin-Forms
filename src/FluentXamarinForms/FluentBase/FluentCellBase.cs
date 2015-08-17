using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentCellBase<TFluent, T> : FluentElementBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T : Cell, new()
    {
        public FluentCellBase ()
            : base ()
        {
        }

        public FluentCellBase (T instance)
            : base (instance)
        {
        }

        public TFluent AddContextAction (MenuItem item)
        {
            this.BuilderActions.Add (cell => {
                    cell.ContextActions.Add (item);
                });

            return this as TFluent;
        }

        public TFluent AddContextAction<TFluent2, T2> (FluentMenuItemBase<TFluent2, T2> fluentMenuItem)
            where TFluent2: FluentBase<T2>
            where T2: MenuItem, new()
        {
            this.BuilderActions.Add (cell => {
                    cell.ContextActions.Add (fluentMenuItem.Build ());
                });

            return this as TFluent;
        }

        public TFluent RemoveContextAction (MenuItem item)
        {
            this.BuilderActions.Add (cell => {
                    cell.ContextActions.Remove (item);
                });

            return this as TFluent;
        }

        public TFluent Height (double value)
        {
            this.BuilderActions.Add (cell => {
                    cell.Height = value;
                });
            
            return this as TFluent;
        }

        public TFluent IsEnabled (bool enabled)
        {
            this.BuilderActions.Add (cell => {
                    cell.IsEnabled = enabled;
                });

            return this as TFluent;
        }

        public TFluent BindIsEnabled (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (cell => {
                    cell.SetBinding (Cell.IsEnabledProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindIsEnabled<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                               BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (cell => {
                    cell.SetBinding<TSource> (Cell.IsEnabledProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }
    }
}