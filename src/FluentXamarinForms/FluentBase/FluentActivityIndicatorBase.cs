using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentActivityIndicatorBase<TFluent, T> : FluentView<TFluent, T>
        where TFluent: FluentBase<T>
        where T: ActivityIndicator, new()
    {
        public TFluent Color (Color color)
        {
            this.BuilderActions.Add (activityIndicator => {
                activityIndicator.Color = color;
            });

            return this as TFluent;
        }

        public TFluent IsRunning (bool running)
        {
            this.BuilderActions.Add (activityIndicator => {
                activityIndicator.IsRunning = running;
            });

            return this as TFluent;
        }
    }
}