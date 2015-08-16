using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentListViewBase<TFluent, T> : FluentItemsViewBase<TFluent, T, Cell>
        where TFluent: FluentBase<T>
        where T: ListView, new()
    {
        public FluentListViewBase ()
            : base ()
        {
        }

        public FluentListViewBase (T instance)
            : base (instance)
        {
        }

        public TFluent Footer (object footer)
        {
            this.BuilderActions.Add (itemsView => itemsView.Footer = footer);

            return this as TFluent;
        }

        public TFluent FooterTemplate (DataTemplate template)
        {
            this.BuilderActions.Add (itemsView => itemsView.FooterTemplate = template);

            return this as TFluent;
        }

        public TFluent GroupDisplayBinding (BindingBase binding)
        {
            this.BuilderActions.Add (itemsView => {
                    itemsView.GroupDisplayBinding = binding;
                });

            return this as TFluent;
        }

        public TFluent GroupDisplayBinding (string path, BindingMode mode = BindingMode.Default, 
                                            IValueConverter converter = null, object converterParameter = null, 
                                            string stringFormat = null, object source = null)
        {
            this.BuilderActions.Add (itemsView => {
                    itemsView.GroupDisplayBinding = new Binding (path, mode, 
                        converter, converterParameter, stringFormat, source);
                });

            return this as TFluent;
        }

        public TFluent GroupHeaderTemplate (DataTemplate templare)
        {
            this.BuilderActions.Add (itemsView => itemsView.GroupHeaderTemplate = templare);

            return this as TFluent;
        }

        public TFluent GroupShortNameBinding (BindingBase binding)
        {
            this.BuilderActions.Add (itemsView => {
                    itemsView.GroupShortNameBinding = binding;
                });

            return this as TFluent;
        }

        public TFluent GroupShortNameBinding (string path, BindingMode mode = BindingMode.Default, 
                                              IValueConverter converter = null, object converterParameter = null, 
                                              string stringFormat = null, object source = null)
        {
            this.BuilderActions.Add (itemsView => {
                    itemsView.GroupShortNameBinding = new Binding (path, mode, 
                        converter, converterParameter, stringFormat, source);
                });

            return this as TFluent;
        }

        public TFluent HasUnevenRows (bool unevenRows)
        {
            this.BuilderActions.Add (itemsView => itemsView.HasUnevenRows = unevenRows);

            return this as TFluent;
        }

        public TFluent Header (object header)
        {
            this.BuilderActions.Add (itemsView => itemsView.Header = header);

            return this as TFluent;
        }

        public TFluent HeaderTemplate (DataTemplate template)
        {
            this.BuilderActions.Add (itemsView => itemsView.HeaderTemplate = template);

            return this as TFluent;
        }

        public TFluent IsGroupingEnabled (bool enabled)
        {
            this.BuilderActions.Add (itemsView => itemsView.IsGroupingEnabled = enabled);

            return this as TFluent;
        }

        public TFluent IsPullToRefreshEnabled (bool enabled)
        {
            this.BuilderActions.Add (itemsView => itemsView.IsPullToRefreshEnabled = enabled);

            return this as TFluent;
        }

        public TFluent IsRefreshing (bool refreshing)
        {
            this.BuilderActions.Add (itemsView => itemsView.IsRefreshing = refreshing);

            return this as TFluent;
        }

        public TFluent RefreshCommand (ICommand command)
        {
            this.BuilderActions.Add (itemsView => itemsView.RefreshCommand = command);

            return this as TFluent;
        }

        public TFluent RowHeight (int height)
        {
            this.BuilderActions.Add (itemsView => itemsView.RowHeight = height);

            return this as TFluent;
        }

        public TFluent SelectedItem (object selected)
        {
            this.BuilderActions.Add (itemsView => itemsView.SelectedItem = selected);

            return this as TFluent;
        }

        public TFluent SeperatorColor (Color color)
        {
            this.BuilderActions.Add (itemsView => itemsView.SeparatorColor = color);

            return this as TFluent;
        }

        public TFluent SeperatorVisibility (SeparatorVisibility visibility)
        {
            this.BuilderActions.Add (itemsView => itemsView.SeparatorVisibility = visibility);

            return this as TFluent;
        }
    }
}