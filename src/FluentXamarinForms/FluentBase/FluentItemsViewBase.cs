using System;
using Xamarin.Forms;
using System.Collections;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentItemsViewBase<TFluent, T, TChild> : FluentViewBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: ItemsView<TChild>, new()
        where TChild : BindableObject
    {
        public FluentItemsViewBase ()
            : base ()
        {
        }

        public FluentItemsViewBase (T instance)
            : base (instance)
        {
        }

        public TFluent ItemSource (IEnumerable source)
        {
            this.BuilderActions.Add (itemsView => itemsView.ItemsSource = source);

            return this as TFluent;
        }

        public TFluent BindItemSource (string path, BindingMode mode = BindingMode.Default, 
                                       IValueConverter converter = null, object converterParameter = null, 
                                       string stringFormat = null, object source = null)
        {
            this.BuilderActions.Add (itemsView => {
                    itemsView.SetBinding (ItemsView<TChild>.ItemsSourceProperty, 
                        new Binding (path, mode, converter, converterParameter, stringFormat, source));
                });

            return this as TFluent;
        }

        public TFluent ItemTemplate (DataTemplate itemTemplate)
        {
            this.BuilderActions.Add (itemsView => itemsView.ItemTemplate = itemTemplate);

            return this as TFluent;
        }
    }
}