using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentBoxViewBase<TFluent, T> : FluentView<TFluent, T>
        where TFluent: FluentBase<T>
        where T: BoxView, new()
    {
        public TFluent Color (Color color)
        {
            this.BuilderActions.Add (boxView => boxView.Color = color);

            return this as TFluent;
        }
    }
}