using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    /// <summary>
    /// Fluent settings.
    /// </summary>
    public static class FluentSettings
    {
        static FluentSettings ()
        {
            PaddingMultiplier = Device.OnPlatform (
                8, // iOS
                8, // Android
                10 // WinPhone
            );
        }

        /// <summary>
        /// Create all control paddings & spacings with zero values (like CSS Style Reset) for precise custom layouts.
        /// </summary>
        /// <value><c>true</c> if style reset; otherwise, <c>false</c>.</value>
        public static bool StyleReset { get; set; }

        /// <summary>
        /// The padding multiplier.
        /// Idea by Adam J Wolf
        /// Source: https://www.syntaxismyui.com/xamarin-forms-nugget-paddington/
        /// </summary>
        public static double PaddingMultiplier { get; set; }
    }
}