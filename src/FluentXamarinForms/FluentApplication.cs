using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace FluentXamarinForms
{
    public class CreateableApplication : Application 
    {
        public CreateableApplication ()
            :base()
        {
        }
    }

    public class FluentApplication : FluentElement<FluentApplication, CreateableApplication>
    {
        public FluentApplication MainPage (Page page)
        {
            this.BuilderActions.Add (app => {
                    app.MainPage = page;
                });

            return this;
        }

        public FluentApplication AddProperty (KeyValuePair<string, object> item)
        {
            this.BuilderActions.Add (app => {
                    app.Properties.Add (item);
                });

            return this;
        }

        public FluentApplication AddProperty (string key, object value)
        {
            this.BuilderActions.Add (app => {
                    app.Properties.Add (key, value);
                });

            return this;
        }

        public FluentApplication RemoveProperty (KeyValuePair<string, object> item)
        {
            this.BuilderActions.Add (app => {
                    app.Properties.Remove (item);
                });

            return this;
        }

        public FluentApplication RemoveProperty (string key)
        {
            this.BuilderActions.Add (app => {
                    app.Properties.Remove (key);
                });

            return this;
        }

        public FluentApplication Resources(ResourceDictionary resourceDictionary)
        {
            this.BuilderActions.Add (app => app.Resources = resourceDictionary);

            return this;
        }

        public FluentApplication AddResource(Style implicitStyle)
        {
            this.BuilderActions.Add (app => app.Resources.Add(implicitStyle));

            return this;
        }

        public FluentApplication RemoveResource(string implicitStyleName)
        {
            this.BuilderActions.Add (app => app.Resources.Remove(implicitStyleName));

            return this;
        }
    }
}