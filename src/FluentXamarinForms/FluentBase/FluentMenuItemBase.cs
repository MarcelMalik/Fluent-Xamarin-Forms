using System;
using Xamarin.Forms;
using System.Windows.Input;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentMenuItemBase<TFluent, T> : FluentBaseMenuItemBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T : MenuItem, new()
    {
        public FluentMenuItemBase ()
            : base ()
        {
        }

        public FluentMenuItemBase (T instance)
            : base (instance)
        {
        }

        public TFluent Command (ICommand command)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.Command = command;
            });

            return this as TFluent;
        }

        public TFluent BindCommand (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.SetBinding (MenuItem.CommandProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindCommand<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.SetBinding<TSource> (MenuItem.CommandProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent CommandParameter (object commandParameter)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.CommandParameter = commandParameter;
            });

            return this as TFluent;
        }

        public TFluent BindCommandParameter (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.SetBinding (MenuItem.CommandParameterProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindCommandParameter<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.SetBinding<TSource> (MenuItem.CommandParameterProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent Icon (FileImageSource fileImageSource)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.Icon = fileImageSource;
            });

            return this as TFluent;
        }

        public TFluent BindIcon (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.SetBinding (MenuItem.IconProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindIcon<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.SetBinding<TSource> (MenuItem.IconProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent IsDestructive (bool destructive)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.IsDestructive = destructive;
            });

            return this as TFluent;
        }

        public TFluent BindIsDestructive (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.SetBinding (MenuItem.IsDestructiveProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindIsDestructive<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.SetBinding<TSource> (MenuItem.IsDestructiveProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent Text (string text)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.Text = text;
            });

            return this as TFluent;
        }

        public TFluent BindText (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.SetBinding (MenuItem.TextProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindText<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (menuItem => {
                menuItem.SetBinding<TSource> (MenuItem.TextProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }
    }
}