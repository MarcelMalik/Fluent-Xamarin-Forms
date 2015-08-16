using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentViewBase<TFluent, T> : FluentVisualElementBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: View, new()
    {
        public FluentViewBase ()
            : base ()
        {
        }

        public FluentViewBase (T instance)
            : base (instance)
        {
        }

        public TFluent Horizontal (LayoutOptions options)
        {
            this.BuilderActions.Add (view => view.HorizontalOptions = options);

            return this as TFluent;
        }

        public TFluent Vertical (LayoutOptions options)
        {
            this.BuilderActions.Add (view => view.VerticalOptions = options);

            return this as TFluent;
        }
    }
}