using System;
using Xamarin.Forms;
using System.Collections.Generic;
using FluentXamarinForms.Extensions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentGridBase<TFluent, T>  : FluentLayout<TFluent, T, View>
        where TFluent: FluentBase<T>
        where T: Grid, new()
    {
        public FluentGridBase ()
        {
        }

        public FluentGridBase (T instance)
            : base (instance)
        {
        }

        protected override void ResetStyles ()
        {
            base.ResetStyles ();

            this.BuilderActions.Add (grid => {
                    if (FluentSettings.StyleReset)
                    {
                        grid.RowSpacing = 0;
                        grid.ColumnSpacing = 0;
                    }
                });
        }

        //TODO: AddChild with int left, int right, int top, int bottom ?
        public TFluent AddChild (View view, int column = 0, int row = 0, int columnspan = 1, int rowspan = 1)
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

            return this as TFluent;
        }

        public TFluent AddChild<TFluent2, T2> (FluentView<TFluent2, T2> fluentView, int column = 0, int row = 0, int columnspan = 1, int rowspan = 1)
            where TFluent2: FluentBase<T2>
            where T2: View, new()
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

            return this as TFluent;
        }

        public TFluent AddChildHorizontal (View view)
        {
            this.BuilderActions.Add (grid => {
                    grid.Children.AddHorizontal (view);
                });

            return this as TFluent;
        }

        public TFluent AddChildHorizontal<TFluent2, T2> (FluentView<TFluent2, T2> fluentView)
            where TFluent2: FluentBase<T2>
            where T2: View, new()
        {
            this.BuilderActions.Add (grid => {
                    grid.Children.AddHorizontal (fluentView.Build ());
                });

            return this as TFluent;
        }

        public TFluent AddChildHorizontal (IEnumerable<View> views)
        {
            this.BuilderActions.Add (grid => {
                    grid.Children.AddHorizontal (views);
                });

            return this as TFluent;
        }

        public TFluent AddChildHorizontal<TFluent2, T2> (IEnumerable<FluentView<TFluent2, T2>> fluentViews)
            where TFluent2: FluentBase<T2>
            where T2: View, new()
        {
            this.BuilderActions.Add (grid => {
                    fluentViews.ForEach ((fluentView) => {
                            grid.Children.AddHorizontal (fluentView.Build ());
                        });
                });

            return this as TFluent;
        }

        public TFluent AddChildVertical (View view)
        {
            this.BuilderActions.Add (grid => grid.Children.AddVertical (view));

            return this as TFluent;
        }

        public TFluent AddChildVertical<TFluent2, T2> (FluentView<TFluent2, T2> fluentView)
            where TFluent2: FluentBase<T2>
            where T2: View, new()
        {
            this.BuilderActions.Add (grid => {
                    grid.Children.AddVertical (fluentView.Build ());
                });

            return this as TFluent;
        }

        public TFluent AddChildVertical (IEnumerable<View> views)
        {
            this.BuilderActions.Add (grid => grid.Children.AddVertical (views));

            return this as TFluent;
        }

        public TFluent AddChildVertical<TFluent2, T2> (IEnumerable<FluentView<TFluent2, T2>> fluentViews)
            where TFluent2: FluentBase<T2>
            where T2: View, new()
        {
            this.BuilderActions.Add (grid => {
                    fluentViews.ForEach ((fluentView) => {
                            grid.Children.AddVertical (fluentView.Build ());
                        });
                });

            return this as TFluent;
        }

        public TFluent ColumnDefinition (double value)
        {
            this.BuilderActions.Add (grid => grid.ColumnDefinitions.Add (
                    new ColumnDefinition { Width = new GridLength (value) }));

            return this as TFluent;
        }

        public TFluent ColumnDefinition (double value, GridUnitType type)
        {
            this.BuilderActions.Add (grid => grid.ColumnDefinitions.Add (
                    new ColumnDefinition { Width = new GridLength (value, type) }));

            return this as TFluent;
        }

        public TFluent ColumnSpacing (double spacing)
        {
            this.BuilderActions.Add (grid => grid.ColumnSpacing = spacing);

            return this as TFluent;
        }

        public TFluent RowDefinition (double value)
        {
            this.BuilderActions.Add (grid => grid.RowDefinitions.Add (
                    new RowDefinition { Height = new GridLength (value) }));

            return this as TFluent;
        }

        public TFluent RowDefinition (double value, GridUnitType type)
        {
            this.BuilderActions.Add (grid => grid.RowDefinitions.Add (
                    new RowDefinition { Height = new GridLength (value, type) }));

            return this as TFluent;
        }

        public TFluent RowSpacing (double spacing)
        {
            this.BuilderActions.Add (grid => grid.RowSpacing = spacing);

            return this as TFluent;
        }
    }
}