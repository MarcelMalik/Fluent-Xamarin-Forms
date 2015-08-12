using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentAbsoluteLayout : FluentLayout<AbsoluteLayout, View>
    {
        public FluentAbsoluteLayout AddChild (View view, Point position)
        {
            this.BuilderActions.Add (absoluteLayout => absoluteLayout.Children.Add (view, position));

            return this;
        }

        public FluentAbsoluteLayout AddChild<TChild> (FluentView<TChild> fluentView, Point position)
            where TChild : View, new()
        {
            this.BuilderActions.Add (absoluteLayout => {
                var view = fluentView.Build();
                absoluteLayout.Children.Add(view, position);
            });

            return this;
        }

        public FluentAbsoluteLayout AddChild (View view, 
            Rectangle bounds, AbsoluteLayoutFlags flags = AbsoluteLayoutFlags.None)
        {
            this.BuilderActions.Add (absoluteLayout => {
                absoluteLayout.Children.Add (view, bounds, flags);
            });

            return this;
        }

        public FluentAbsoluteLayout AddChild<TChild> (FluentView<TChild> fluentView,
            Rectangle bounds, AbsoluteLayoutFlags flags = AbsoluteLayoutFlags.None)
            where TChild : View, new()
        {
            this.BuilderActions.Add (absoluteLayout => {
                var view = fluentView.Build();
                absoluteLayout.Children.Add(view, bounds, flags);
            });

            return this;
        }
    }
}