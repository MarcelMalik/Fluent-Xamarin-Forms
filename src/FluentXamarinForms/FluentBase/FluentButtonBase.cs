using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentButtonBase<TFluent, T> : FluentView<TFluent, T>
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
            this.BuilderActions.Add (button => button.BorderColor = color);

            return this as TFluent;
        }

        public TFluent BorderRadius (int radius)
        {
            this.BuilderActions.Add (button => button.BorderRadius = radius);

            return this as TFluent;
        }

        public TFluent BorderWidth (double width)
        {
            this.BuilderActions.Add (button => button.BorderWidth = width);

            return this as TFluent;
        }

        public TFluent Command (ICommand command)
        {
            this.BuilderActions.Add (button => button.Command = command);

            return this as TFluent;
        }

        public TFluent CommandParameter (object commandParameter)
        {
            this.BuilderActions.Add (button => button.CommandParameter = commandParameter);

            return this as TFluent;
        }

        public TFluent Font (Font font)
        {
            this.BuilderActions.Add (button => button.Font = font);

            return this as TFluent;
        }

        public TFluent FontAttributes (FontAttributes attributes)
        {
            this.BuilderActions.Add (button => button.FontAttributes = attributes);

            return this as TFluent;
        }

        public TFluent FontFamily (string fontFamily)
        {
            this.BuilderActions.Add (button => button.FontFamily = fontFamily);

            return this as TFluent;
        }

        public TFluent FontSize (double fontSize)
        {
            this.BuilderActions.Add (button => button.FontSize = fontSize);

            return this as TFluent;
        }

        public TFluent Image (FileImageSource image)
        {
            this.BuilderActions.Add (button => button.Image = image);

            return this as TFluent;
        }

        public TFluent Text (string value)
        {
            this.BuilderActions.Add (button => button.Text = value);

            return this as TFluent;
        }

        public TFluent TextColor (Color color)
        {
            this.BuilderActions.Add (button => button.TextColor = color);

            return this as TFluent;
        }
    }
}