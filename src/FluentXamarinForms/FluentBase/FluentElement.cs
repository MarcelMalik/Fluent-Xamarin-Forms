using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentElement<TFluent, T> : FluentBindableObject<TFluent, T>
        where TFluent: FluentBase<T>
        where T : Element, new()
    {
        public FluentElement ()
            :base()
        {}

        public FluentElement (T instance)
            :base(instance)
        {}

        public TFluent ClassId(string classId)
        {
            this.BuilderActions.Add (element => element.ClassId = classId);

            return this as TFluent;
        }

        public TFluent Parent(Element parent)
        {
            this.BuilderActions.Add (element => element.Parent = parent);

            return this as TFluent;
        }

        public TFluent StyleId(string styleId)
        {
            this.BuilderActions.Add (element => element.StyleId = styleId);

            return this as TFluent;
        }
    }
}