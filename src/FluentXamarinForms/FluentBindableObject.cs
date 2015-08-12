using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public abstract class FluentBindableObject<TBindableObject> : FluentBase<TBindableObject> 
        where TBindableObject : BindableObject, new()
    {
        public TBindableObject BindingContext(object context)
        {
            this.BuilderActions.Add (bindableObj => bindableObj.BindingContext = context);

            return this as TBindableObject;
        }
    }
}