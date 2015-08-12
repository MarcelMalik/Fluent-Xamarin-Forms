using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentLayout<TFluent, T> : FluentView<TFluent, T>
        where TFluent: FluentBase<T>
        where T: Layout, new()
    {
        public FluentLayout ()
            : base ()
        {
        }

        public FluentLayout (T instance)
            : base (instance)
        {
        }

        public TFluent IsClippedToBounds (bool isClippedToBounds)
        {
            this.BuilderActions.Add (layout => layout.IsClippedToBounds = isClippedToBounds);

            return this as TFluent;
        }

        public TFluent Padding (Thickness padding)
        {
            this.BuilderActions.Add (layout => layout.Padding = padding);

            return this as TFluent;
        }
    }

    public class FluentLayout<TFluent, T, TChild> : FluentLayout<TFluent, T>
        where TFluent: FluentBase<T>
        where T: Layout<TChild>, new()
        where TChild : View//, new()
    {
        public FluentLayout ()
            : base ()
        {
        }

        public FluentLayout (T instance)
            : base (instance)
        {
        }

        public TFluent AddChild (TChild view)
        {
            this.BuilderActions.Add (layout => layout.Children.Add (view));

            return this as TFluent;
        }

        public TFluent RemoveChild (TChild view)
        {
            this.BuilderActions.Add (layout => layout.Children.Remove (view));

            return this as TFluent;
        }

        /*public TFluent AddChild (FluentView<TFluent, T> fluentChild)
        {
            this.BuilderActions.Add (layout => {
                var view = fluentChild.Build();
                layout.Children.Add(view);
            });

            return this as TFluent;
        }*/
    }
}