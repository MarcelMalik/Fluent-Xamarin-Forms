using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentActivityIndicator : FluentView<ActivityIndicator>
    {
        public FluentActivityIndicator Color (Color color)
        {
            this.BuilderActions.Add (activityIndicator => {
                    activityIndicator.Color = color;
                });

            return this;
        }

        public FluentActivityIndicator IsRunning (bool running)
        {
            this.BuilderActions.Add (activityIndicator => {
                activityIndicator.IsRunning = running;
            });

            return this;
        }
    }
}