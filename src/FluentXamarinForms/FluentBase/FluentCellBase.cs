using System;
using Xamarin.Forms;

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
    }
}