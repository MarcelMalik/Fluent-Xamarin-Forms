using System;
using Xamarin.Forms;

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

        public TFluent Padding (int left = 1, int top = 1, int right = 1, int bottom = 1)
        {
            this.BuilderActions.Add (page => {
                    page.Padding = FluentPadding.Padding (left, top, right, bottom);
                });

            return this as TFluent;
        }

        public TFluent Padding (int horizontalSize = 1, int verticalSize = 1)
        {
            this.BuilderActions.Add (page => {
                    page.Padding = FluentPadding.Padding (horizontalSize, verticalSize);
                });

            return this as TFluent;
        }

        public TFluent Padding (int uniformSize = 1)
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