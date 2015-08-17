using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public class FluentViewCellBase<TFluent, T> : FluentCellBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T : ViewCell, new()
    {
        public FluentViewCellBase ()
            : base ()
        {
        }

        public FluentViewCellBase (T instance)
            : base (instance)
        {
        }

        public TFluent View (View view)
        {
            this.BuilderActions.Add (viewCell => {
                    viewCell.View = view;
                });

            return this as TFluent;
        }

        public TFluent View<TFluent2, T2> (FluentViewBase<TFluent2, T2> fluentView)
            where TFluent2: FluentBase<T2>
            where T2: View, new()
        {
            this.BuilderActions.Add (viewCell => {
                    viewCell.View = fluentView.Build ();
                });

            return this as TFluent;
        }
    }
}