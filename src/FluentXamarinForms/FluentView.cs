using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public abstract class FluentView<TFluent, T> : FluentVisualElement<TFluent, T>
        where TFluent: FluentBase<T>
        where T: View, new()
    {
        public FluentView ()
            : base ()
        {
        }

        public FluentView (T instance)
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