using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public abstract class FluentView<TView> : FluentVisualElement<TView>
        where TView: View, new()
    {
        public TView Horizontal (LayoutOptions options)
        {
            this.BuilderActions.Add (view => view.HorizontalOptions = options);

            return this as TView;
        }

        public TView Vertical (LayoutOptions options)
        {
            this.BuilderActions.Add (view => view.VerticalOptions = options);

            return this as TView;
        }
    }
}