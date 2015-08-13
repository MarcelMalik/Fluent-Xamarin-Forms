using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentPageBase<TFluent, T> : FluentVisualElement<TFluent, T>
        where TFluent: FluentBase<T>
        where T: Page, new()
    {
        public FluentPageBase ()
            : base ()
        {
        }

        public FluentPageBase (T instance)
            : base (instance)
        {
        }

        protected override void ResetStyles ()
        {
            base.ResetStyles ();

            this.BuilderActions.Add (page => {
                    if (FluentSettings.StyleReset)
                    {
                        page.Padding = new Thickness (0);
                    }
                });
        }

        public TFluent BackgroundImage (string source)
        {
            this.BuilderActions.Add (page => page.BackgroundImage = source);

            return this as TFluent;
        }

        public TFluent Icon (FileImageSource source)
        {
            this.BuilderActions.Add (page => page.Icon = source);

            return this as TFluent;
        }

        public TFluent IsBusy (bool busy)
        {
            this.BuilderActions.Add (page => page.IsBusy = busy);

            return this as TFluent;
        }

        public TFluent Padding (Thickness value)
        {
            this.BuilderActions.Add (page => page.Padding = value);

            return this as TFluent;
        }

        public TFluent Padding (double left = 1, double top = 1, double right = 1, double bottom = 1)
        {
            this.BuilderActions.Add (page => {
                    page.Padding = FluentPadding.Padding (left, top, right, bottom);
                });

            return this as TFluent;
        }

        public TFluent Padding (double horizontalSize = 1, double verticalSize = 1)
        {
            this.BuilderActions.Add (page => {
                    page.Padding = FluentPadding.Padding (horizontalSize, verticalSize);
                });

            return this as TFluent;
        }

        public TFluent Padding (double uniformSize = 1)
        {
            this.BuilderActions.Add (page => {
                    page.Padding = FluentPadding.Padding (uniformSize);
                });

            return this as TFluent;
        }

        public TFluent Title (string title)
        {
            this.BuilderActions.Add (page => {
                    page.Title = title;
                });

            return this as TFluent;
        }

        public TFluent BindTitle (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (page => {
                    page.SetBinding (Page.TitleProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindTitle<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                           BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (page => {
                    page.SetBinding<TSource> (Page.TitleProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent AddToolbarItem (ToolbarItem item)
        {
            this.BuilderActions.Add (page => page.ToolbarItems.Add (item));
        
            return this as TFluent;
        }

        public TFluent RemoveToolbarItem (ToolbarItem item)
        {
            this.BuilderActions.Add (page => page.ToolbarItems.Remove (item));
        
            return this as TFluent;
        }
    }
}