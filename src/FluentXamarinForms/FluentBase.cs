using System;
using System.Collections.Generic;

namespace FluentXamarinForms
{
    public interface IFluentBase
    {
        
    }

    public abstract class FluentBase<T> : IFluentBase
        where T: new()
    {
        private readonly T instance;

        public FluentBase ()
        {
            this.BuilderActions = new List<Action<T>> ();
        }

        public FluentBase(T instance)
            : this()
        {
            this.instance = instance;
        }

        protected List<Action<T>> BuilderActions { get; }

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