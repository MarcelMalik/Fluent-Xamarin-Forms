using System;
using Xamarin.Forms;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace FluentXamarinForms
{
    public class FluentGrid : FluentLayout<Grid, View>
    {
        //TODO: AddChild with int left, int right, int top, int bottom ?
        public FluentGrid AddChild (View view, int column = 0, int row = 0, 
                                    int columnspan = 1, int rowspan = 1)
        {
            if (view == null)
                throw new ArgumentNullException ("view");
            if (column < 0)
                throw new ArgumentOutOfRangeException ("column");
            if (row < 0)
                throw new ArgumentOutOfRangeException ("row");
            if (columnspan <= 0)
                throw new ArgumentOutOfRangeException ("columnspan");
            if (rowspan <= 0)
                throw new ArgumentOutOfRangeException ("rowspan");

            this.BuilderActions.Add (grid => {
                    Grid.SetRow ((BindableObject)view, row);
                    Grid.SetRowSpan ((BindableObject)view, rowspan);
                    Grid.SetColumn ((BindableObject)view, column);
                    Grid.SetColumnSpan ((BindableObject)view, columnspan);

                    grid.Children.Add (view);
                });

            return this;
        }

        public FluentGrid AddChild<TChild> (FluentView<TChild> fluentView, 
                                            int column = 0, int row = 0, int columnspan = 1, int rowspan = 1)
            where TChild : View, new()
        {
            if (fluentView == null)
                throw new ArgumentNullException ("view");
            if (column < 0)
                throw new ArgumentOutOfRangeException ("column");
            if (row < 0)
                throw new ArgumentOutOfRangeException ("row");
            if (columnspan <= 0)
                throw new ArgumentOutOfRangeException ("columnspan");
            if (rowspan <= 0)
                throw new ArgumentOutOfRangeException ("rowspan");

            this.BuilderActions.Add (grid => {
                    var view = fluentView.Build ();
                    Grid.SetRow ((BindableObject)view, row);
                    Grid.SetRowSpan ((BindableObject)view, rowspan);
                    Grid.SetColumn ((BindableObject)view, column);
                    Grid.SetColumnSpan ((BindableObject)view, columnspan);

                    grid.Children.Add (view);
                });

            return this;
        }

        public FluentGrid AddChildHorizontal (View view)
        {
            this.BuilderActions.Add (grid => grid.Children.AddHorizontal (view));

            return this;
        }

        public FluentGrid AddChildHorizontal (IEnumerable<View> views)
        {
            this.BuilderActions.Add (grid => grid.Children.AddHorizontal (views));

            return this;
        }

        public FluentGrid AddChildHorizontal<TChild>(FluentView<TChild> fluentview)
            where TChild : View, new()
        {
            this.BuilderActions.Add (grid => {
                var child = fluentview.Build();
                grid.Children.AddHorizontal (child);
            });

            return this;
        }

        public FluentGrid AddChildHorizontal<TChild> (IEnumerable<FluentView<TChild>> fluentViews)
            where TChild : View, new()
        {
            this.BuilderActions.Add (grid => {
                fluentViews.ForEach((fluentView) => {
                    var view = fluentView.Build();
                    grid.Children.AddHorizontal(view);
                });
            });

            return this;
        }

        public FluentGrid AddChildVertical (View child)
        {
            this.BuilderActions.Add (grid => grid.Children.AddVertical (child));

            return this;
        }

        public FluentGrid AddChildVertical (IEnumerable<View> childs)
        {
            this.BuilderActions.Add (grid => grid.Children.AddVertical (childs));

            return this;
        }

        public FluentGrid AddChildVertical<TChild>(FluentView<TChild> fluentChild)
            where TChild : View, new()
        {
            this.BuilderActions.Add (grid => {
                var child = fluentChild.Build();
                grid.Children.AddVertical (child);
            });

            return this;
        }

        public FluentGrid AddChildVertical<TChild> (IEnumerable<FluentView<TChild>> fluentChilds)
            where TChild : View, new()
        {
            this.BuilderActions.Add (grid => {
                fluentChilds.ForEach((fluentChild) => {
                    var child = fluentChild.Build();
                    grid.Children.AddVertical(child);
                });
            });

            return this;
        }


        public FluentGrid ColumnDefinition (double value)
        {
            this.BuilderActions.Add (grid => grid.ColumnDefinitions.Add (
                    new ColumnDefinition { Width = new GridLength (value) }));

            return this;
        }

        public FluentGrid ColumnDefinition (double value, GridUnitType type)
        {
            this.BuilderActions.Add (grid => grid.ColumnDefinitions.Add (
                    new ColumnDefinition { Width = new GridLength (value, type) }));

            return this;
        }

        public FluentGrid ColumnSpacing (double spacing)
        {
            this.BuilderActions.Add (grid => grid.ColumnSpacing = spacing);

            return this;
        }

        public FluentGrid RowDefinition (double value)
        {
            this.BuilderActions.Add (grid => grid.RowDefinitions.Add (
                    new RowDefinition { Height = new GridLength (value) }));

            return this;
        }

        public FluentGrid RowDefinition (double value, GridUnitType type)
        {
            this.BuilderActions.Add (grid => grid.RowDefinitions.Add (
                    new RowDefinition { Height = new GridLength (value, type) }));

            return this;
        }

        public FluentGrid RowSpacing (double spacing)
        {
            this.BuilderActions.Add (grid => grid.RowSpacing = spacing);

            return this;
        }
    }
}