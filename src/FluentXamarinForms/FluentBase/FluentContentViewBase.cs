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
            this.BuilderActions.Add (contentView => contentView.Content = view);

            return this as TFluent;
        }

        /*public TFluent Content<TFluentOther, TOther> (FluentView<TFluentOther, TOther> fluentView)
            where TFluentOther: FluentBase<TOther>
            where TOther: View, new()
        {
            this.BuilderActions.Add (contentView => {
                    var view = fluentView.Build ();
                    contentView.Content = view; 
                });

            return this as TFluent;
        }*/
    }
}