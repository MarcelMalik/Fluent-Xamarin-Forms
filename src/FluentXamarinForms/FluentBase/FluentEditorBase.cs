using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentEditorBase<TFluent, T> : FluentInputViewBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: Editor, new()
    {
        public FluentEditorBase ()
            : base ()
        {
        }

        public FluentEditorBase (T instance)
            : base (instance)
        {
        }

        public TFluent Text (string text)
        {
            this.BuilderActions.Add (editor => {
                    editor.Text = text;
                });

            return this as TFluent;
        }

        public TFluent BindText (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (editor => {
                    editor.SetBinding (Editor.TextProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindText<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                          BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (editor => {
                    editor.SetBinding<TSource> (Editor.TextProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }
    }
}