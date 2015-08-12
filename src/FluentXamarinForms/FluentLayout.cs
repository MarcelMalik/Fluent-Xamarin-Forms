using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentLayout<TLayout> : FluentView<TLayout>
        where TLayout: Layout, new()
    {
        public TLayout IsClippedToBounds (bool isClippedToBounds)
        {
            this.BuilderActions.Add (layout => layout.IsClippedToBounds = isClippedToBounds);

            return this as TLayout;
        }

        public TLayout Padding (Thickness padding)
        {
            this.BuilderActions.Add (layout => layout.Padding = padding);

            return this as TLayout;
        }
    }

    public class FluentLayout<TLayout, TChild> : FluentLayout<TLayout>
        where TLayout: Layout<TChild>, new()
        where TChild : View//, new()
    {
        public TLayout AddChild (TChild child)
        {
            this.BuilderActions.Add (layout => layout.Children.Add (child));

            return this as TLayout;
        }

        public TLayout RemoveChild (TChild child)
        {
            this.BuilderActions.Add (layout => layout.Children.Remove (child));

            return this as TLayout;
        }

        /*public FluentLayout<TLayout, TChild> AddChild (FluentView<TChild> fluentChild)
        {
            this.BuilderActions.Add (layout => {
                var view = fluentChild.Build();
                layout.Children.Add(view);
            });

            return this;
        }*/
    }
}