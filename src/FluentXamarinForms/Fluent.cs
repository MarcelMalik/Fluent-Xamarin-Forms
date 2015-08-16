using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public static partial class Fluent
    {
        public static FluentAbsoluteLayout CreateAbsoluteLayout (AbsoluteLayout instance = null)
        {
            return new FluentAbsoluteLayout (instance);
        }

        public static FluentActivityIndicator CreateActivityIndicator (ActivityIndicator instance = null)
        {
            return new FluentActivityIndicator (instance);
        }

        public static FluentBoxView CreateBoxView (BoxView instance = null)
        {
            return new FluentBoxView (instance);
        }

        public static FluentButton CreateButton (Button instance = null)
        {
            return new FluentButton (instance);
        }

        public static FluentCarouselPage CreateCarouselPage (CarouselPage instance = null)
        {
            return new FluentCarouselPage (instance);
        }

        public static FluentContentPage CreateContentPage (ContentPage instance = null)
        {
            return new FluentContentPage (instance);
        }

        public static FluentContentView CreateContentView (ContentView instance = null)
        {
            return new FluentContentView (instance);
        }

        public static FluentDatePicker CreateDatePicker (DatePicker instance = null)
        {
            return new FluentDatePicker (instance);
        }

        public static FluentEditor CreateEditor (Editor instance = null)
        {
            return new FluentEditor (instance);
        }

        public static FluentEntry CreateEntry (Entry instance = null)
        {
            return new FluentEntry (instance);
        }

        public static FluentEntryCell CreateEntryCell (EntryCell instance = null)
        {
            return new FluentEntryCell (instance);
        }

        public static FluentFrame CreateFrame (Frame instance = null)
        {
            return new FluentFrame (instance);
        }

        public static FluentGrid CreateGrid (Grid instance = null)
        {
            return new FluentGrid (instance);
        }

        public static FluentImage CreateImage (Image instance = null)
        {
            return new FluentImage (instance);
        }

        public static FluentImageCell CreateImageCell (ImageCell instance = null)
        {
            return new FluentImageCell (instance);
        }

        public static FluentLabel CreateLabel (Label instance = null)
        {
            return new FluentLabel (instance);
        }

        public static FluentListView CreateListView (ListView instance = null)
        {
            return new FluentListView (instance);
        }

        public static FluentMasterDetailPage CreateMasterDetailPage (MasterDetailPage instance = null)
        {
            return new FluentMasterDetailPage (instance);
        }

        public static FluentPage CreatePage (Page instance = null)
        {
            return new FluentPage (instance);
        }

        public static FluentStackLayout CreateStackLayout (StackLayout instance = null)
        {
            return new FluentStackLayout (instance);
        }

        public static FluentTextCell CreateTextCell (TextCell instance = null)
        {
            return new FluentTextCell (instance);
        }
    }
}