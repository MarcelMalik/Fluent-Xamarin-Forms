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
            this.BuilderActions.Add (contentPage => {
                    contentPage.Content = view;
                });

            return this as TFluent;
        }

        public TFluent Content<TFluent2, T2> (FluentView<TFluent2, T2> fluentView)
            where TFluent2: FluentBase<T2>
            where T2: View, new()
        {
            this.BuilderActions.Add (contentPage => {
                contentPage.Content = fluentView.Build();;
            });

            return this as TFluent;
        }
    }
}