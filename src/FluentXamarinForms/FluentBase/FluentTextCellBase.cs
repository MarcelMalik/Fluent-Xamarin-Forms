using System;
using Xamarin.Forms;
using System.Windows.Input;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public class FluentTextCellBase<TFluent, T> : FluentCellBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T : TextCell, new()
    {
        public FluentTextCellBase ()
            : base ()
        {
        }

        public FluentTextCellBase (T instance)
            : base (instance)
        {
        }

        public TFluent Command (ICommand command)
        {
            this.BuilderActions.Add (textCell => {
                textCell.Command = command;
            }
            );

            return this as TFluent;
        }

        public TFluent BindCommand (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding (TextCell.CommandProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindCommand<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding<TSource> (TextCell.CommandProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent CommandParameter (object commandParameter)
        {
            this.BuilderActions.Add (textCell => {
                textCell.CommandParameter = commandParameter;
            });

            return this as TFluent;
        }

        public TFluent BindCommandParameter (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding (TextCell.CommandParameterProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindCommandParameter<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding<TSource> (TextCell.CommandParameterProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent Detail (string detail)
        {
            this.BuilderActions.Add (textCell => {
                textCell.Detail = detail;
            });

            return this as TFluent;
        }

        public TFluent BindDetail (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding (TextCell.DetailProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindDetail<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding<TSource> (TextCell.DetailProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent DetailColor (Color color)
        {
            this.BuilderActions.Add (textCell => {
                textCell.DetailColor = color;
            });

            return this as TFluent;
        }

        public TFluent BindDetailColor (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding (TextCell.DetailColorProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindDetailColor<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding<TSource> (TextCell.DetailColorProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent Text (string text)
        {
            this.BuilderActions.Add (textCell => {
                textCell.Text = text;
            });

            return this as TFluent;
        }

        public TFluent BindText (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding (TextCell.TextProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindText<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding<TSource> (TextCell.TextProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent TextColor (Color color)
        {
            this.BuilderActions.Add (textCell => {
                textCell.TextColor = color;
            });

            return this as TFluent;
        }

        public TFluent BindTextColor (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding (TextCell.TextColorProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindTextColor<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (textCell => {
                textCell.SetBinding<TSource> (TextCell.TextColorProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }
    }
}