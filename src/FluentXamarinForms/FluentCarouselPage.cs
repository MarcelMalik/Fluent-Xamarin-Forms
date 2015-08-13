//using System;
//using Xamarin.Forms;
//
//namespace FluentXamarinForms
//{
//    public class FluentPage : FluentPageBase<FluentPage, Page>
//    {
//        
//    }
//
//    public class FluentContentPage : FluentPageBase<FluentContentPage, ContentPage>
//    {
//        public FluentContentPage ()
//            : base ()
//        {
//        }
//
//        public FluentContentPage (ContentPage instance)
//            : base (instance)
//        {
//        }
//    }
//
//
//    public abstract class FluentPageBase<TFluent, T> : FluentVisualElement<TFluent, T>
//        where TFluent: FluentBase<T>
//        where T : Page, new()
//    {
//        public FluentPageBase ()
//            : base ()
//        {
//        }
//
//        public FluentPageBase (T instance)
//            : base (instance)
//        {
//        }
//
//        public TFluent BackgroundImage (string backgroundImage)
//        {
//            this.BuilderActions.Add (page => page.BackgroundImage = backgroundImage);
//
//            return this as TFluent;
//        }
//
//        public TFluent Icon (FileImageSource icon)
//        {
//            this.BuilderActions.Add (page => page.Icon = icon);
//
//            return this as TFluent;
//        }
//
//        public TFluent IsBusy (bool busy)
//        {
//            this.BuilderActions.Add (page => page.IsBusy = busy);
//
//            return this as TFluent;
//        }
//
//        public TFluent Padding (Thickness padding)
//        {
//            this.BuilderActions.Add (page => page.Padding = padding);
//
//            return this as TFluent;
//        }
//
//        public TFluent Title (string text)
//        {
//            this.BuilderActions.Add (page => page.Title = text);
//
//            return this as TFluent;
//        }
//
//        public TFluent AddToolbarItem (ToolbarItem item)
//        {
//            this.BuilderActions.Add (page => page.ToolbarItems.Add (item));
//
//            return this as TFluent;
//        }
//
//        public TFluent RemoveToolbarItem (ToolbarItem item)
//        {
//            this.BuilderActions.Add (page => page.ToolbarItems.Remove (item));
//
//            return this as TFluent;
//        }
//    }
//
//    public abstract class FluentMultiPage<TPageContent> : FluentPage
//    {
//        
//    }
//    /*public class FluentCarouselPage : FluentMultiPage<CarouselPage>
//    {
//    }*/
//}