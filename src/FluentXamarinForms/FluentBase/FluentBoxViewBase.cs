using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentBoxViewBase<TFluent, T> : FluentViewBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: BoxView, new()
    {
        public FluentBoxViewBase ()
            :base()
        {
        }

        public FluentBoxViewBase (T instance)
            :base(instance)
        {
        }

        public TFluent Color (Color color)
        {
            this.BuilderActions.Add (boxView => boxView.Color = color);

            return this as TFluent;
        }

        public TFluent BindColor (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (boxView => {
                    boxView.SetBinding (BoxView.ColorProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindColor<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                           BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (boxView => {
                    boxView.SetBinding<TSource> (BoxView.ColorProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }
    }
}