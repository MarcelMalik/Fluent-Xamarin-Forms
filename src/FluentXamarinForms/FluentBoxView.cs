using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentBoxView : FluentView<FluentBoxView, BoxView>
    {
        public FluentBoxView Color (Color color)
        {
            this.BuilderActions.Add (boxView => boxView.Color = color);

            return this;
        }
    }
}