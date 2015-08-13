using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentContentViewBase<TFluent, T> : FluentLayout<TFluent, T>
        where TFluent: FluentBase<T>
        where T: ContentView, new()
    {
        public FluentContentViewBase ()
        {
        }

        public FluentContentViewBase (T instance)
            : base (instance)
        {
        }

        public TFluent Content (View view)
        {
            this.BuilderActions.Add (contentView => {
                    contentView.Content = view;
                });

            return this as TFluent;
        }

        public TFluent Content<TFluent2, T2> (FluentView<TFluent2, T2> fluentView)
            where TFluent2: FluentBase<T2>
            where T2: View, new()
        {
            this.BuilderActions.Add (contentView => {
                contentView.Content = fluentView.Build();;
            });

            return this as TFluent;
        }
    }
}