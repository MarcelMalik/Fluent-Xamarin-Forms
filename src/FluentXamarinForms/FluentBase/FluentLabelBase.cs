using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentLabelBase<TFluent, T> : FluentView<TFluent, T>
        where TFluent: FluentBase<T>
        where T: Label, new()
    {
        public FluentLabelBase ()
            : base ()
        {
        }

        public FluentLabelBase (T instance)
            : base (instance)
        {   
        }

        public TFluent XAlign (TextAlignment alignment)
        {
            this.BuilderActions.Add (label => label.XAlign = alignment);

            return this as TFluent;
        }

        public TFluent YAlign (TextAlignment alignment)
        {
            this.BuilderActions.Add (label => label.YAlign = alignment);

            return this as TFluent;
        }

        public TFluent Text (string text)
        {
            this.BuilderActions.Add (label => {
                    label.Text = text;
                });

            return this as TFluent;
        }

        public TFluent BindText (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (label => {
                    label.SetBinding (Label.TextProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindText<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                          BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (label => {
                    label.SetBinding<TSource> (Label.TextProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }
    }
}