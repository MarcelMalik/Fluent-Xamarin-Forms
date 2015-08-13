using System;
using System.Collections.Generic;
using FluentXamarinForms.Extensions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentBase<T>
        where T: new()
    {
        private readonly T instance;

        public FluentBase ()
        {
            this.BuilderActions = new List<Action<T>> ();
            this.ResetStyles ();
        }

        public FluentBase(T instance)
            : this()
        {
            this.instance = instance;
        }

        protected List<Action<T>> BuilderActions { get; }

        protected virtual void ResetStyles()
        {
        }

        public virtual T Build ()
        {
            var result = this.instance;
            if (result == null)
                result = new T ();

            this.BuilderActions.ForEach (action => action (result));

            return result;
        }
    }
}