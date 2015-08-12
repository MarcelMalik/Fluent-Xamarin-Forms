using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentStackLayout : FluentView<StackLayout>
    {
        public FluentStackLayout AddChild(View view)
        {
            if (view == null)
                throw new ArgumentNullException ("view");

            this.BuilderActions.Add (stackLayout => {
                stackLayout.Children.Add(view);
                });

            return this;
        }

        public FluentStackLayout AddChild<TChild>(FluentView<TChild> fluentView)
            where TChild : View, new()
        {
            if (fluentView == null)
                throw new ArgumentNullException ("view");

            this.BuilderActions.Add (stackLayout => {
                var view = fluentView.Build();
                stackLayout.Children.Add(view);
            });

            return this;
        }
    }
}