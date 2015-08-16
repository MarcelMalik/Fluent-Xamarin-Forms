using System;
using Xamarin.Forms;
using System.Collections.Generic;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentApplication<T> : FluentElementBase<FluentApplication<T>, T>
        where T : Application, new()
    {
        public FluentApplication ()
            : base ()
        {
        }

        public FluentApplication (T instance)
            : base (instance)
        {
        }

        public FluentApplication<T> MainPage (Page page)
        {
            this.BuilderActions.Add (app => {
                    app.MainPage = page;
                });

            return this;
        }

        public FluentApplication<T> AddProperty (KeyValuePair<string, object> item)
        {
            this.BuilderActions.Add (app => {
                    app.Properties.Add (item);
                });

            return this;
        }

        public FluentApplication<T> AddProperty (string key, object value)
        {
            this.BuilderActions.Add (app => {
                    app.Properties.Add (key, value);
                });

            return this;
        }

        public FluentApplication<T> RemoveProperty (KeyValuePair<string, object> item)
        {
            this.BuilderActions.Add (app => {
                    app.Properties.Remove (item);
                });

            return this;
        }

        public FluentApplication<T> RemoveProperty (string key)
        {
            this.BuilderActions.Add (app => {
                    app.Properties.Remove (key);
                });

            return this;
        }

        public FluentApplication<T> Resources (ResourceDictionary resourceDictionary)
        {
            this.BuilderActions.Add (app => app.Resources = resourceDictionary);

            return this;
        }

        public FluentApplication<T> AddResource (Style implicitStyle)
        {
            this.BuilderActions.Add (app => app.Resources.Add (implicitStyle));

            return this;
        }

        public FluentApplication<T> RemoveResource (string implicitStyleName)
        {
            this.BuilderActions.Add (app => app.Resources.Remove (implicitStyleName));

            return this;
        }
    }
}