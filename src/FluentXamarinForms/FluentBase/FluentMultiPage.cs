using System;
using Xamarin.Forms;
using System.Collections;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentMultiPage<TFluent, T, TPage> : FluentPageBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: MultiPage<TPage>, new()
        where TPage: Page
    {
        public FluentMultiPage ()
            : base ()
        {
        }

        public FluentMultiPage (T instance)
            : base (instance)
        {
        }

        public TFluent AddChild (TPage page)
        {
            this.BuilderActions.Add (multiPage => {
                    multiPage.Children.Add (page);
                });

            return this as TFluent;
        }

        public TFluent AddChild<TFluent2, T2> (FluentPageBase<TFluent2, T2> fluentPage)
            where TFluent2: FluentBase<T2>
            where T2: TPage, new()
        {
            this.BuilderActions.Add (multiPage => {
                    multiPage.Children.Add (fluentPage.Build ());
                });

            return this as TFluent;
        }

        public TFluent RemoveChild (TPage page)
        {
            this.BuilderActions.Add (multiPage => {
                    multiPage.Children.Remove (page);
                });

            return this as TFluent;
        }

        public TFluent CurrentPage (TPage current)
        {
            this.BuilderActions.Add (multiPage => {
                    multiPage.CurrentPage = current;
                });
            
            return this as TFluent;
        }

        public TFluent ItemSource (IEnumerable source)
        {
            this.BuilderActions.Add (multiPage => {
                    multiPage.ItemsSource = source;
                });

            return this as TFluent;
        }

        public TFluent BindItemSource (string path, BindingMode mode = BindingMode.Default, 
                                       IValueConverter converter = null, object converterParameter = null, 
                                       string stringFormat = null, object source = null)
        {
            this.BuilderActions.Add (multiPage => {
                    multiPage.SetBinding (ItemsView<TPage>.ItemsSourceProperty, 
                        new Binding (path, mode, converter, converterParameter, stringFormat, source));
                });

            return this as TFluent;
        }

        public TFluent ItemTemplate (DataTemplate itemTemplate)
        {
            this.BuilderActions.Add (multiPage => multiPage.ItemTemplate = itemTemplate);

            return this as TFluent;
        }

        public TFluent SelectedItem (object item)
        {
            this.BuilderActions.Add (multiPage => {
                    multiPage.SelectedItem = item;
                });

            return this as TFluent;
        }
    }
}