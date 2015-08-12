using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentLabel : FluentView<Label>
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
    }
}