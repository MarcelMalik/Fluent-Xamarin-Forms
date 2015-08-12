using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public abstract class FluentElement<TElement> : FluentBindableObject<TElement>
        where TElement : Element, new()
    {
        public TElement ClassId(string classId)
        {
            this.BuilderActions.Add (element => element.ClassId = classId);

            return this as TElement;
        }

        public TElement Parent(Element parent)
        {
            this.BuilderActions.Add (element => element.Parent = parent);

            return this as TElement;
        }

        public TElement StyleId(string styleId)
        {
            this.BuilderActions.Add (element => element.StyleId = styleId);

            return this as TElement;
        }
    }
}