using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms
{
    public class FluentLabel : FluentView<FluentLabel, Label>
    {
        public FluentLabel XAlign (TextAlignment alignment)
        {
            this.BuilderActions.Add (label => label.XAlign = alignment);

            return this;
        }

        public FluentLabel YAlign (TextAlignment alignment)
        {
            this.BuilderActions.Add (label => label.YAlign = alignment);

            return this;
        }

        public FluentLabel Text (string text)
        {
            this.BuilderActions.Add (label => label.Text = text);

            return this;
        }

        public FluentLabel BindText(string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add(label => {
                label.SetBinding(Label.TextProperty, path, mode, converter, stringFormat);
            });
                
            return this;
        }

        public FluentLabel BindText<TSource>( Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (label => {
                    label.SetBinding<TSource> (Label.TextProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this;
        }
    }
}