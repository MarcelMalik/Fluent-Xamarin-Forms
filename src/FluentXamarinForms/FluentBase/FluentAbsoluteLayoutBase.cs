using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentAbsoluteLayoutBase<TFluent, T, TChild> : FluentLayout<TFluent, T, View> 
        where TFluent: FluentBase<T>
        where T: AbsoluteLayout, new()
    {
        public TFluent AddChild (View view, Point position)
        {
            this.BuilderActions.Add (absoluteLayout => {
                absoluteLayout.Children.Add (view, position);
            });

            return this as TFluent;
        }

        public TFluent AddChild (View view, Rectangle bounds, AbsoluteLayoutFlags flags = AbsoluteLayoutFlags.None)
        {
            this.BuilderActions.Add (absoluteLayout => {
                absoluteLayout.Children.Add (view, bounds, flags);
            });

            return this as TFluent;
        }
    }
}