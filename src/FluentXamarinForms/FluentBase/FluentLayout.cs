using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentLayout<TFluent, T> : FluentView<TFluent, T>
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

        protected override void ResetStyles ()
        {
            base.ResetStyles ();

            this.BuilderActions.Add (layout => {
                if (FluentSettings.StyleReset)
                {
                    layout.Padding = new Thickness (0);
                }
            });
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

        public TFluent Padding (int left = 1, int top = 1, int right = 1, int bottom = 1)
        {
            this.BuilderActions.Add (layout => {
                layout.Padding = FluentPadding.Padding (left, top, right, bottom);
            });

            return this as TFluent;
        }

        public TFluent Padding (int horizontalSize = 1, int verticalSize = 1)
        {
            this.BuilderActions.Add (layout => {
                layout.Padding = FluentPadding.Padding (horizontalSize, verticalSize);
            });

            return this as TFluent;
        }

        public TFluent Padding (int uniformSize = 1)
        {
            this.BuilderActions.Add (layout => {
                layout.Padding = FluentPadding.Padding (uniformSize);
            });

            return this as TFluent;
        }
    }

    public abstract class FluentLayout<TFluent, T, TChild> : FluentLayout<TFluent, T>
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