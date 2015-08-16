using System;
using Xamarin.Forms;
using System.Windows.Input;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentButtonBase<TFluent, T> : FluentViewBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: Button, new()
    {
        public FluentButtonBase ()
            : base ()
        {
        }

        public FluentButtonBase (T instance)
            : base (instance)
        {
        }

        public TFluent BorderColor (Color color)
        {
            this.BuilderActions.Add (button => {
                    button.BorderColor = color;
                });

            return this as TFluent;
        }

        public TFluent BindBorderColor (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding (Button.BorderColorProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindBorderColor<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding<TSource> (Button.BorderColorProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BorderRadius (int radius)
        {
            this.BuilderActions.Add (button => {
                    button.BorderRadius = radius;
                });

            return this as TFluent;
        }

        public TFluent BindBorderRadius (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding (Button.BorderRadiusProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindBorderRadius<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding<TSource> (Button.BorderRadiusProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BorderWidth (double width)
        {
            this.BuilderActions.Add (button => {
                    button.BorderWidth = width;
                });

            return this as TFluent;
        }

        public TFluent BindBorderWidth (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding (Button.BorderWidthProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindBorderWidth<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding<TSource> (Button.BorderWidthProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent Command (ICommand command)
        {
            this.BuilderActions.Add (button => {
                    button.Command = command;
                });

            return this as TFluent;
        }

        public TFluent BindCommand (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                    button.SetBinding (Button.CommandProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindCommand<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                             BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                    button.SetBinding<TSource> (Button.CommandProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent CommandParameter (object commandParameter)
        {
            this.BuilderActions.Add (button => {
                    button.CommandParameter = commandParameter;
                });

            return this as TFluent;
        }

        public TFluent BindCommandParameter (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                    button.SetBinding (Button.CommandParameterProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindCommandParameter<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                                      BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                    button.SetBinding<TSource> (Button.CommandParameterProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent Font (Font font)
        {
            this.BuilderActions.Add (button => {
                    button.Font = font;
                });

            return this as TFluent;
        }

        public TFluent BindFont (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding (Button.FontProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindFont<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding<TSource> (Button.FontProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent FontAttributes (FontAttributes attributes)
        {
            this.BuilderActions.Add (button => {
                    button.FontAttributes = attributes;
                });

            return this as TFluent;
        }

        public TFluent BindFontAttributes (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding (Button.FontAttributesProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindFontAttributes<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding<TSource> (Button.FontAttributesProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent FontFamily (string fontFamily)
        {
            this.BuilderActions.Add (button => {
                    button.FontFamily = fontFamily;
                });

            return this as TFluent;
        }

        public TFluent BindFontFamily (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding (Button.FontFamilyProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindFontFamily<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding<TSource> (Button.FontFamilyProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent FontSize (double fontSize)
        {
            this.BuilderActions.Add (button => {
                    button.FontSize = fontSize;
                });

            return this as TFluent;
        }

        public TFluent BindFontSize (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding (Button.FontSizeProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindFontSize<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding<TSource> (Button.FontSizeProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent Image (FileImageSource image)
        {
            this.BuilderActions.Add (button => {
                    button.Image = image;
                });

            return this as TFluent;
        }

        public TFluent BindImage (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding (Button.FontSizeProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindImage<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                button.SetBinding<TSource> (Button.FontSizeProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent Text (string text)
        {
            this.BuilderActions.Add (button => {
                    button.Text = text;
                });

            return this as TFluent;
        }

        public TFluent BindText (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                    button.SetBinding (Button.TextProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindText<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                          BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                    button.SetBinding<TSource> (Button.TextProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent TextColor (Color color)
        {
            this.BuilderActions.Add (button => {
                    button.TextColor = color;
                });

            return this as TFluent;
        }

        public TFluent BindTextColor (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                    button.SetBinding (Button.TextColorProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindTextColor<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                               BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (button => {
                    button.SetBinding<TSource> (Button.TextColorProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }
    }
}