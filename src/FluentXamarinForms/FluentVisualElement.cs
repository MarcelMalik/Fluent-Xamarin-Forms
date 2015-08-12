using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public abstract class FluentVisualElement<TVisualElement> : FluentElement<TVisualElement>
        where TVisualElement : VisualElement, new()
    {
        public TVisualElement AnchorX(double value)
        {
            this.BuilderActions.Add (visualElement => visualElement.AnchorX = value);

            return this as TVisualElement;
        }

        public TVisualElement AnchorY(double value)
        {
            this.BuilderActions.Add (visualElement => visualElement.AnchorY = value);

            return this as TVisualElement;
        }

        public TVisualElement BackgroundColor(Color color)
        {
            this.BuilderActions.Add (visualElement => visualElement.BackgroundColor = color);

            return this as TVisualElement;
        }

        public TVisualElement AddBehavior(Behavior behavior)
        {
            this.BuilderActions.Add (visualElement => visualElement.Behaviors.Add (behavior));

            return this as TVisualElement;
        }

        public TVisualElement RemoveBehavior(Behavior behavior)
        {
            this.BuilderActions.Add (visualElement => visualElement.Behaviors.Remove (behavior));

            return this as TVisualElement;
        }

        public TVisualElement HeightRequest(double height)
        {
            this.BuilderActions.Add (visualElement => visualElement.HeightRequest = height);

            return this as TVisualElement;
        }

        public TVisualElement InputTransparent(bool transparent)
        {
            this.BuilderActions.Add (visualElement => visualElement.InputTransparent = transparent);

            return this as TVisualElement;
        }
    
        public TVisualElement IsEnabled(bool enabled)
        {
            this.BuilderActions.Add (visualElement => visualElement.IsEnabled = enabled);

            return this as TVisualElement;
        }

        public TVisualElement IsVisible(bool visible)
        {
            this.BuilderActions.Add (visualElement => visualElement.IsVisible = visible);

            return this as TVisualElement;
        }

        public TVisualElement MinimumHeightRequest(double minimumHeight)
        {
            this.BuilderActions.Add (visualElement => visualElement.MinimumHeightRequest = minimumHeight);

            return this as TVisualElement;
        }

        public TVisualElement MinimumWidthRequest(double minimumWidth)
        {
            this.BuilderActions.Add (visualElement => visualElement.MinimumWidthRequest = minimumWidth);

            return this as TVisualElement;
        }

        public TVisualElement Opacity(double opacity)
        {
            this.BuilderActions.Add (visualElement => visualElement.Opacity = opacity);

            return this as TVisualElement;
        }

        public TVisualElement Resources(ResourceDictionary resourceDictionary)
        {
            this.BuilderActions.Add (visualElement => visualElement.Resources = resourceDictionary);

            return this as TVisualElement;
        }

        public TVisualElement AddResource(Style implicitStyle)
        {
            this.BuilderActions.Add (visualElement => visualElement.Resources.Add(implicitStyle));

            return this as TVisualElement;
        }

        public TVisualElement RemoveResource(string implicitStyleName)
        {
            this.BuilderActions.Add (visualElement => visualElement.Resources.Remove(implicitStyleName));

            return this as TVisualElement;
        }
    
        public TVisualElement Rotation(double rotation)
        {
            this.BuilderActions.Add (visualElement => visualElement.Rotation = rotation);

            return this as TVisualElement;
        }

        public TVisualElement RotationX(double rotation)
        {
            this.BuilderActions.Add (visualElement => visualElement.RotationX = rotation);

            return this as TVisualElement;
        }

        public TVisualElement RotationY(double rotation)
        {
            this.BuilderActions.Add (visualElement => visualElement.RotationY = rotation);

            return this as TVisualElement;
        }

        public TVisualElement Scale(double scale)
        {
            this.BuilderActions.Add (visualElement => visualElement.Scale = scale);

            return this as TVisualElement;
        }

        public TVisualElement Style(Style style)
        {
            this.BuilderActions.Add (visualElement => visualElement.Style = style);

            return this as TVisualElement;
        }

        public TVisualElement TranslationX(double translation)
        {
            this.BuilderActions.Add (visualElement => visualElement.TranslationX = translation);

            return this as TVisualElement;
        }

        public TVisualElement TranslationY(double translation)
        {
            this.BuilderActions.Add (visualElement => visualElement.TranslationY = translation);

            return this as TVisualElement;
        }

        public TVisualElement AddTrigger(TriggerBase trigger)
        {
            this.BuilderActions.Add (visualElement => visualElement.Triggers.Add(trigger));

            return this as TVisualElement;
        }

        public TVisualElement RemoveTrigger(TriggerBase trigger)
        {
            this.BuilderActions.Add (visualElement => visualElement.Triggers.Remove(trigger));

            return this as TVisualElement;
        }

        public TVisualElement WidthRequest(double width)
        {
            this.BuilderActions.Add (visualElement => visualElement.WidthRequest = width);

            return this as TVisualElement;
        }
    }
}