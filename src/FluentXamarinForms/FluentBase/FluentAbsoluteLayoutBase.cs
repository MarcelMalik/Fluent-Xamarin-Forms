using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentAbsoluteLayoutBase<TFluent, T, TChild> : FluentLayout<TFluent, T, View> 
        where TFluent: FluentBase<T>
        where T: AbsoluteLayout, new()
    {
        public FluentAbsoluteLayoutBase ()
            : base ()
        {
        }

        public FluentAbsoluteLayoutBase (T instance)
            : base (instance)
        {
        }

        public TFluent AddChild (View view, Point position)
        {
            this.BuilderActions.Add (absoluteLayout => {
                    absoluteLayout.Children.Add (view, position);
                });

            return this as TFluent;
        }

        public TFluent AddChild (View view, Rectangle bounds, AbsoluteLayoutFlags flags = AbsoluteLayoutFlags.None)
        {
            this.BuilderActions.Add (absoluteLayout => {
                    absoluteLayout.Children.Add (view, bounds, flags);
                });

            return this as TFluent;
        }

        public TFluent BindLayoutBounds (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (absoluteLayout => {
                    absoluteLayout.SetBinding (AbsoluteLayout.LayoutBoundsProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindLayoutBounds<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                                  BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (absoluteLayout => {
                    absoluteLayout.SetBinding<TSource> (AbsoluteLayout.LayoutBoundsProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindLayoutFlags (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (absoluteLayout => {
                    absoluteLayout.SetBinding (AbsoluteLayout.LayoutFlagsProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindLayoutFlags<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                                 BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (absoluteLayout => {
                    absoluteLayout.SetBinding<TSource> (AbsoluteLayout.LayoutFlagsProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }
    }
}