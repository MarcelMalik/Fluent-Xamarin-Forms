using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public static class LabelAlignmentExtensions
    {
        public static Style AlignTopLeft (this Style style)
        {
            return style
                    .Clone ()
                    .Set (Label.YAlignProperty, TextAlignment.Start)
                    .Set (Label.XAlignProperty, TextAlignment.Start);
        }

        public static Style AlignTopCenter (this Style style)
        {
            return style
                    .Clone ()
                    .Set (Label.YAlignProperty, TextAlignment.Start)
                    .Set (Label.XAlignProperty, TextAlignment.Center);
        }

        public static Style AlignTopRight (this Style style)
        {
            return style
                    .Clone ()
                    .Set (Label.YAlignProperty, TextAlignment.Start)
                    .Set (Label.XAlignProperty, TextAlignment.End);
        }

        public static Style AlignCenterLeft (this Style style)
        {
            return style
                    .Clone ()
                    .Set (Label.YAlignProperty, TextAlignment.Center)
                    .Set (Label.XAlignProperty, TextAlignment.Start);
        }

        public static Style AlignCenterCenter (this Style style)
        {
            return style
                    .Clone ()
                    .Set (Label.YAlignProperty, TextAlignment.Center)
                    .Set (Label.XAlignProperty, TextAlignment.Center);
        }

        public static Style AlignCenterRight (this Style style)
        {
            return style
                    .Clone ()
                    .Set (Label.YAlignProperty, TextAlignment.Center)
                    .Set (Label.XAlignProperty, TextAlignment.End);
        }

        public static Style AlignBottomLeft (this Style style)
        {
            return style
                    .Clone ()
                    .Set (Label.YAlignProperty, TextAlignment.End)
                    .Set (Label.XAlignProperty, TextAlignment.Start);
        }

        public static Style AlignBottomCenter (this Style style)
        {
            return style
                    .Clone ()
                    .Set (Label.YAlignProperty, TextAlignment.End)
                    .Set (Label.XAlignProperty, TextAlignment.Center);
        }

        public static Style AlignBottomRight (this Style style)
        {
            return style
                    .Clone ()
                    .Set (Label.YAlignProperty, TextAlignment.End)
                    .Set (Label.XAlignProperty, TextAlignment.End);
        }
    }
}