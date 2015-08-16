using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentBindableObjectBase<TFluent, T> : FluentBase<T> 
        where TFluent : FluentBase<T>
        where T : BindableObject, new()
    {
        public FluentBindableObjectBase ()
            : base ()
        {
        }

        public FluentBindableObjectBase (T instance)
            : base (instance)
        {
        }

        public TFluent Bind (BindableProperty targetProperty, BindingBase binding)
        {
            this.BuilderActions.Add (bindableObject => {
                    bindableObject.SetBinding (targetProperty, binding); 
                });

            return this as TFluent;
        }

        public TFluent BindingContext (object context)
        {
            this.BuilderActions.Add (bindableObject => {
                    bindableObject.BindingContext = context;
                });

            return this as TFluent;
        }

        public TFluent BindBindingContext (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (bindableObject => {
                    bindableObject.SetBinding (BindableObject.BindingContextProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindBindingContext<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                               BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (bindableObject => {
                    bindableObject.SetBinding<TSource> (BindableObject.BindingContextProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }
    }
}