using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms
{
    public abstract class FluentBindableObject<TFluent, T> : FluentBase<T> 
        where TFluent : FluentBase<T>
        where T : BindableObject, new()
    {
        public FluentBindableObject ()
            :base()
        {}

        public FluentBindableObject (T instance)
            :base(instance)
        {}

        public TFluent Bind(BindableProperty targetProperty, BindingBase binding)
        {
            this.BuilderActions.Add(bindableObj => {
                bindableObj.SetBinding(targetProperty, binding); 
            });

            return this as TFluent;
        }

        /*public TFluent Bind(string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add(bindableObj => {
                bindableObj.SetBinding(
                bindableObj.SetBinding(bindableObj, path, mode, converter, stringFormat); 
            });

            return this as TFluent;
        }

        public TFluent Bind<TSource>(Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add(bindableObj => {
                bindableObj.SetBinding<TSource>(bindableObj, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }*/

        public TFluent BindingContext(object context)
        {
            this.BuilderActions.Add (bindableObj => bindableObj.BindingContext = context);

            return this as TFluent;
        }
    }
}