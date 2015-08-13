using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentStackLayoutBase<TFluent, T> : FluentLayout<TFluent, T, View>
        where TFluent: FluentBase<T>
        where T: StackLayout, new()
    {
        public FluentStackLayoutBase ()
            : base ()
        {
        }

        public FluentStackLayoutBase (T instance)
            : base (instance)
        {
        }

        protected override void ResetStyles ()
        {
            base.ResetStyles ();

            this.BuilderActions.Add (stackLayout => {
                    if (FluentSettings.StyleReset)
                    {
                        stackLayout.Spacing = 0;
                    }
                });
        }

        public TFluent OrientationHorizontal ()
        {
            this.BuilderActions.Add (stackLayout => {
                    stackLayout.Orientation = StackOrientation.Horizontal;
                });

            return this as TFluent;
        }

        public TFluent OrientationVertical ()
        {
            this.BuilderActions.Add (stackLayout => {
                    stackLayout.Orientation = StackOrientation.Vertical;
                });

            return this as TFluent;
        }

        public TFluent Spacing (double value)
        {
            this.BuilderActions.Add (stackLayout => {
                    stackLayout.Spacing = value;
                });

            return this as TFluent;
        }
    }
}