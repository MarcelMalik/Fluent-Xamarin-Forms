using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public class FluentEntryBase<TFluent, T> : FluentInputViewBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: Entry, new()
    {
        public FluentEntryBase ()
            : base ()
        {
        }

        public FluentEntryBase (T instance)
            : base (instance)
        {
        }

        public TFluent IsPassword (bool value)
        {
            this.BuilderActions.Add (entry => {
                    entry.IsPassword = value;
                });

            return this as TFluent;
        }

        public TFluent Placeholder (string placeholder)
        {
            this.BuilderActions.Add (entry => {
                    entry.Placeholder = placeholder;
                });

            return this as TFluent;
        }

        public TFluent Text (string text)
        {
            this.BuilderActions.Add (entry => {
                    entry.Text = text;
                });

            return this as TFluent;
        }

        public TFluent BindText (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (entry => {
                    entry.SetBinding (Entry.TextProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindText<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                          BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (entry => {
                    entry.SetBinding<TSource> (Entry.TextProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent TextColor (Color color)
        {
            this.BuilderActions.Add (entry => {
                    entry.TextColor = color;
                });

            return this as TFluent;
        }
    }
}