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
        public static Thickness Padding (int left = 1, int top = 1, int right = 1, int bottom = 1)
        {
            return new Thickness (
                left * FluentSettings.PaddingMultiplier,
                top * FluentSettings.PaddingMultiplier,
                right * FluentSettings.PaddingMultiplier,
                bottom * FluentSettings.PaddingMultiplier
            );
        }

        public static Thickness Padding (int horizontalSize = 1, int verticalSize = 1)
        {
            return new Thickness (horizontalSize * FluentSettings.PaddingMultiplier, verticalSize * FluentSettings.PaddingMultiplier);
        }

        public static Thickness Padding (int uniformSize = 1)
        {
            return new Thickness (uniformSize * FluentSettings.PaddingMultiplier);
        }
    }
}