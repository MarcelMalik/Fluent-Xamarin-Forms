using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace FluentXamarinForms
{
    public class FluentButton : FluentView<Button>
    {
        public FluentButton BorderColor (Color color)
        {
            this.BuilderActions.Add (button => button.BorderColor = color);

            return this;
        }

        public FluentButton BorderRadius (int radius)
        {
            this.BuilderActions.Add (button => button.BorderRadius = radius);

            return this;
        }
    
        public FluentButton BorderWidth (double width)
        {
            this.BuilderActions.Add (button => button.BorderWidth = width);

            return this;
        }

        public FluentButton Command (ICommand command)
        {
            this.BuilderActions.Add (button => button.Command = command);

            return this;
        }

        public FluentButton CommandParameter (object commandParameter)
        {
            this.BuilderActions.Add (button => button.CommandParameter = commandParameter);

            return this;
        }

        public FluentButton Font (Font font)
        {
            this.BuilderActions.Add (button => button.Font = font);

            return this;
        }

        public FluentButton FontAttributes (FontAttributes attributes)
        {
            this.BuilderActions.Add (button => button.FontAttributes = attributes);

            return this;
        }

        public FluentButton FontFamily (string fontFamily)
        {
            this.BuilderActions.Add (button => button.FontFamily = fontFamily);

            return this;
        }

        public FluentButton FontSize (double fontSize)
        {
            this.BuilderActions.Add (button => button.FontSize = fontSize);

            return this;
        }

        public FluentButton Image (FileImageSource image)
        {
            this.BuilderActions.Add (button => button.Image = image);

            return this;
        }
    
        public FluentButton Text (string value)
        {
            this.BuilderActions.Add (button => button.Text = value);

            return this;
        }

        public FluentButton TextColor (Color color)
        {
            this.BuilderActions.Add (button => button.TextColor = color);

            return this;
        }
    }
}