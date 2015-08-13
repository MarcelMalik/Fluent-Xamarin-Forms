using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public class FluentInputViewBase<TFluent, T> : FluentView<TFluent, T>
        where TFluent: FluentBase<T>
        where T: InputView, new()
    {
        public FluentInputViewBase ()
            : base ()
        {
        }

        public FluentInputViewBase (T instance)
            : base (instance)
        {
        }

        public TFluent Keyboard (Keyboard keyboard)
        {
            this.BuilderActions.Add (inputView => {
                    inputView.Keyboard = keyboard;
                });

            return this as TFluent;
        }
    }
}