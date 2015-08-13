using System;
using Xamarin.Forms;
using System.Collections.Generic;

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
        public TFluent AddChild (View view, int column = 0, int row = 0, 
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

            return this as TFluent;
        }

        // TODO
        /*public TFluent AddChild<TChild> (FluentView<FluentGrid, TChild> fluentView, 
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

            return this as TFluent;
        }*/

        public TFluent AddChildHorizontal (T view)
        {
            this.BuilderActions.Add (grid => grid.Children.AddHorizontal (view));

            return this as TFluent;
        }

        public TFluent AddChildHorizontal (IEnumerable<View> views)
        {
            this.BuilderActions.Add (grid => grid.Children.AddHorizontal (views));

            return this as TFluent;
        }

        // TODO
        /*public FluentGrid AddChildHorizontal<TChild>(FluentView<FluentGrid, TChild> fluentview)
            where TChild : View, new()
        {
            this.BuilderActions.Add (grid => {
                var child = fluentview.Build();
                grid.Children.AddHorizontal (child);
            });

            return this;
        }*/

        // TODO
        /*public FluentGrid AddChildHorizontal<TChild> (IEnumerable<FluentView<FluentGrid, TChild>> fluentViews)
            where TChild : View, new()
        {
            this.BuilderActions.Add (grid => {
                fluentViews.ForEach((fluentView) => {
                    var view = fluentView.Build();
                    grid.Children.AddHorizontal(view);
                });
            });

            return this;
        }*/

        public TFluent AddChildVertical (View view)
        {
            this.BuilderActions.Add (grid => grid.Children.AddVertical (view));

            return this as TFluent;
        }

        public TFluent AddChildVertical (IEnumerable<View> views)
        {
            this.BuilderActions.Add (grid => grid.Children.AddVertical (views));

            return this as TFluent;
        }

        // TODO
        /*public TFluent AddChildVertical<TChild>(FluentView<FluentGrid, TChild> fluentChild)
            where TChild : View, new()
        {
            this.BuilderActions.Add (grid => {
                var child = fluentChild.Build();
                grid.Children.AddVertical (child);
            });

            return this as TFluent;
        }*/

        // TODO
        /*public TFluent AddChildVertical<TChild> (IEnumerable<FluentView<FluentGrid, TChild>> fluentChilds)
            where TChild : View, new()
        {
            this.BuilderActions.Add (grid => {
                fluentChilds.ForEach((fluentChild) => {
                    var child = fluentChild.Build();
                    grid.Children.AddVertical(child);
                });
            });

            return this as TFluent;
        }*/


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