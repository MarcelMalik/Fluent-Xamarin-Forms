using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    /// <summary>
    /// Idea by Adam J Wolf
    /// Source: https://www.syntaxismyui.com/xamarin-forms-nugget-paddington/
    /// </summary>
    public static class FluentPadding
    {
        public static Thickness Padding (double left = 1, double top = 1, double right = 1, double bottom = 1)
        {
            return new Thickness (
                left * FluentSettings.PaddingMultiplier,
                top * FluentSettings.PaddingMultiplier,
                right * FluentSettings.PaddingMultiplier,
                bottom * FluentSettings.PaddingMultiplier
            );
        }

        public static Thickness Padding (double horizontalSize = 1, double verticalSize = 1)
        {
            return new Thickness (horizontalSize * FluentSettings.PaddingMultiplier, verticalSize * FluentSettings.PaddingMultiplier);
        }

        public static Thickness Padding (double uniformSize = 1)
        {
            return new Thickness (uniformSize * FluentSettings.PaddingMultiplier);
        }
    }
}