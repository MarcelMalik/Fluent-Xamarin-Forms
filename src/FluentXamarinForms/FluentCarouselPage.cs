using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public abstract class FluentPage : FluentVisualElement<Page>
    {
        public FluentPage BackgroundImage (string backgroundImage)
        {
            this.BuilderActions.Add (page => page.BackgroundImage = backgroundImage);

            return this;
        }

        public FluentPage Icon (FileImageSource icon)
        {
            this.BuilderActions.Add (page => page.Icon = icon);

            return this;
        }

        public FluentPage IsBusy (bool busy)
        {
            this.BuilderActions.Add (page => page.IsBusy = busy);

            return this;
        }

        public FluentPage Padding (Thickness padding)
        {
            this.BuilderActions.Add (page => page.Padding = padding);

            return this;
        }

        public FluentPage Title (string text)
        {
            this.BuilderActions.Add (page => page.Title = text);

            return this;
        }

        public FluentPage AddToolbarItem (ToolbarItem item)
        {
            this.BuilderActions.Add (page => page.ToolbarItems.Add(item));

            return this;
        }

        public FluentPage RemoveToolbarItem (ToolbarItem item)
        {
            this.BuilderActions.Add (page => page.ToolbarItems.Remove(item));

            return this;
        }
    }
    public abstract class FluentMultiPage<TPageContent> : FluentPage
    {
        
    }
    /*public class FluentCarouselPage : FluentMultiPage<CarouselPage>
    {
    }*/
}

