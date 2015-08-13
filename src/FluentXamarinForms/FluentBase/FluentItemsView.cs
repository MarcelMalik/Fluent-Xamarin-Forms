using System;
using Xamarin.Forms;
using System.Collections;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentItemsView<TFluent, T, TChild> : FluentView<TFluent, T>
        where TFluent: FluentBase<T>
        where T: ItemsView<TChild>, new()
        where TChild : BindableObject
    {
        public FluentItemsView ()
            : base ()
        {
        }

        public FluentItemsView (T instance)
            : base (instance)
        {
        }

        public TFluent ItemSource (IEnumerable source)
        {
            this.BuilderActions.Add (itemsView => itemsView.ItemsSource = source);

            return this as TFluent;
        }

        public TFluent ItemTemplate (DataTemplate itemTemplate)
        {
            this.BuilderActions.Add (itemsView => itemsView.ItemTemplate = itemTemplate);

            return this as TFluent;
        }
    }
}