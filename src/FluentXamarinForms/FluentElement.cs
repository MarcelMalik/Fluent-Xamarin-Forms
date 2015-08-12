using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public abstract class FluentElement<TElement> : FluentBindableObject<TElement>
        where TElement : Element, new()
    {
        public FluentElement<TElement> ClassId(string classId)
        {
            this.BuilderActions.Add (element => element.ClassId = classId);

            return this;
        }

        public FluentElement<TElement> Parent(Element parent)
        {
            this.BuilderActions.Add (element => element.Parent = parent);

            return this;
        }

        public FluentElement<TElement> StyleId(string styleId)
        {
            this.BuilderActions.Add (element => element.StyleId = styleId);

            return this;
        }
    }
}