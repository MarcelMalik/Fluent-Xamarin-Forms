using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentFrameBase<TFluent, T> : FluentContentViewBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: Frame, new()
    {
        public FluentFrameBase ()
            : base ()
        {
        }

        public FluentFrameBase (T instance)
            : base (instance)
        {
        }

        public TFluent HasShadow (bool shadow)
        {
            this.BuilderActions.Add (frame => {
                    frame.HasShadow = shadow;
                });
            return this as TFluent;
        }

        public TFluent OutlineColor (Color color)
        {
            this.BuilderActions.Add (frame => {
                    frame.OutlineColor = color;
                });
            return this as TFluent;
        }
    }
}