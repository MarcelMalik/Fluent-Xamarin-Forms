using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentActivityIndicatorBase<TFluent, T> : FluentViewBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: ActivityIndicator, new()
    {
        public FluentActivityIndicatorBase ()
            :base()
        {
        }

        public FluentActivityIndicatorBase (T instance)
            :base(instance)
        {
        }

        public TFluent Color (Color color)
        {
            this.BuilderActions.Add (activityIndicator => {
                    activityIndicator.Color = color;
                });

            return this as TFluent;
        }

        public TFluent BindColor (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (activityIndicator => {
                    activityIndicator.SetBinding (ActivityIndicator.ColorProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindColor<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                           BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (activityIndicator => {
                    activityIndicator.SetBinding<TSource> (ActivityIndicator.ColorProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent IsRunning (bool running)
        {
            this.BuilderActions.Add (activityIndicator => {
                    activityIndicator.IsRunning = running;
                });

            return this as TFluent;
        }

        public TFluent BindIsRunning (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (activityIndicator => {
                    activityIndicator.SetBinding (ActivityIndicator.IsRunningProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindIsRunning<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                               BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (activityIndicator => {
                    activityIndicator.SetBinding<TSource> (ActivityIndicator.IsRunningProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }
    }
}