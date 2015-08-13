using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentContentPageBase<TFluent, T> : FluentPageBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: ContentPage, new()
    {
        public FluentContentPageBase ()
            : base ()
        {
        }

        public FluentContentPageBase (T instance)
            : base (instance)
        {
        }

        public TFluent Content (View view)
        {
            this.BuilderActions.Add (contentPage => contentPage.Content = view);

            return this as TFluent;
        }
    }
}