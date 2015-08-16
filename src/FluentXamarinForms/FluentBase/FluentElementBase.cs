using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentElementBase<TFluent, T> : FluentBindableObjectBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T : Element, new()
    {
        public FluentElementBase ()
            :base()
        {}

        public FluentElementBase (T instance)
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