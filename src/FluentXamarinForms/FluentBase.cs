using System;
using System.Collections.Generic;

namespace FluentXamarinForms
{
    public abstract class FluentBase<T>
        where T: new()
    {
        public FluentBase ()
        {
            this.BuilderActions = new List<Action<T>> ();
        }

        protected List<Action<T>> BuilderActions { get; }

        public virtual T Build ()
        {
            var result = new T ();

            this.BuilderActions.ForEach (action => action (result));

            return result;
        }
    }
}