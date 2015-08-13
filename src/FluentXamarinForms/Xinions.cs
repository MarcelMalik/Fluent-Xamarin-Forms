using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    /// <summary>
    /// Created by Adam J. Wolf 
    /// Source: https://www.syntaxismyui.com/xinions-xamarin-forms-style-minions-that-do-the-dirty-work-for-you/
    /// </summary>
    public static class Xinions
    {
        public static Style Clone (this Style style)
        {
            var newStyle = new Style (style.TargetType) {
                BasedOn = style
            }; 
            return newStyle;
        }

        public static Style Set<T> (this Style style, BindableProperty property, T value)
        {
            style.Setters.Add (new Setter () { Property = property, Value = value });
            return style;
        }
    }
}