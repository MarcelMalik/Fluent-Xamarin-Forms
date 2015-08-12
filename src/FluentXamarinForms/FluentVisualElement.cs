using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public abstract class FluentVisualElement<TVisualElement> : FluentElement<TVisualElement>
        where TVisualElement : VisualElement, new()
    {
        public FluentVisualElement<TVisualElement> AnchorX(double value)
        {
            this.BuilderActions.Add (visualElement => visualElement.AnchorX = value);

            return this;
        }

        public FluentVisualElement<TVisualElement> AnchorY(double value)
        {
            this.BuilderActions.Add (visualElement => visualElement.AnchorY = value);

            return this;
        }

        public FluentVisualElement<TVisualElement> BackgroundColor(Color color)
        {
            this.BuilderActions.Add (visualElement => visualElement.BackgroundColor = color);

            return this;
        }

        public FluentVisualElement<TVisualElement> AddBehavior(Behavior behavior)
        {
            this.BuilderActions.Add (visualElement => visualElement.Behaviors.Add (behavior));

            return this;
        }

        public FluentVisualElement<TVisualElement> RemoveBehavior(Behavior behavior)
        {
            this.BuilderActions.Add (visualElement => visualElement.Behaviors.Remove (behavior));

            return this;
        }

        public FluentVisualElement<TVisualElement> HeightRequest(double height)
        {
            this.BuilderActions.Add (visualElement => visualElement.HeightRequest = height);

            return this;
        }

        public FluentVisualElement<TVisualElement> InputTransparent(bool transparent)
        {
            this.BuilderActions.Add (visualElement => visualElement.InputTransparent = transparent);

            return this;
        }
    
        public FluentVisualElement<TVisualElement> IsEnabled(bool enabled)
        {
            this.BuilderActions.Add (visualElement => visualElement.IsEnabled = enabled);

            return this;
        }

        public FluentVisualElement<TVisualElement> IsVisible(bool visible)
        {
            this.BuilderActions.Add (visualElement => visualElement.IsVisible = visible);

            return this;
        }

        public FluentVisualElement<TVisualElement> MinimumHeightRequest(double minimumHeight)
        {
            this.BuilderActions.Add (visualElement => visualElement.MinimumHeightRequest = minimumHeight);

            return this;
        }

        public FluentVisualElement<TVisualElement> MinimumWidthRequest(double minimumWidth)
        {
            this.BuilderActions.Add (visualElement => visualElement.MinimumWidthRequest = minimumWidth);

            return this;
        }

        public FluentVisualElement<TVisualElement> Opacity(double opacity)
        {
            this.BuilderActions.Add (visualElement => visualElement.Opacity = opacity);

            return this;
        }

        public FluentVisualElement<TVisualElement> Resources(ResourceDictionary resourceDictionary)
        {
            this.BuilderActions.Add (visualElement => visualElement.Resources = resourceDictionary);

            return this;
        }

        public FluentVisualElement<TVisualElement> AddResource(Style implicitStyle)
        {
            this.BuilderActions.Add (visualElement => visualElement.Resources.Add(implicitStyle));

            return this;
        }

        public FluentVisualElement<TVisualElement> RemoveResource(string implicitStyleName)
        {
            this.BuilderActions.Add (visualElement => visualElement.Resources.Remove(implicitStyleName));

            return this;
        }
    
        public FluentVisualElement<TVisualElement> Rotation(double rotation)
        {
            this.BuilderActions.Add (visualElement => visualElement.Rotation = rotation);

            return this;
        }

        public FluentVisualElement<TVisualElement> RotationX(double rotation)
        {
            this.BuilderActions.Add (visualElement => visualElement.RotationX = rotation);

            return this;
        }

        public FluentVisualElement<TVisualElement> RotationY(double rotation)
        {
            this.BuilderActions.Add (visualElement => visualElement.RotationY = rotation);

            return this;
        }

        public FluentVisualElement<TVisualElement> Scale(double scale)
        {
            this.BuilderActions.Add (visualElement => visualElement.Scale = scale);

            return this;
        }

        public FluentVisualElement<TVisualElement> Style(Style style)
        {
            this.BuilderActions.Add (visualElement => visualElement.Style = style);

            return this;
        }

        public FluentVisualElement<TVisualElement> TranslationX(double translation)
        {
            this.BuilderActions.Add (visualElement => visualElement.TranslationX = translation);

            return this;
        }

        public FluentVisualElement<TVisualElement> TranslationY(double translation)
        {
            this.BuilderActions.Add (visualElement => visualElement.TranslationY = translation);

            return this;
        }

        public FluentVisualElement<TVisualElement> AddTrigger(TriggerBase trigger)
        {
            this.BuilderActions.Add (visualElement => visualElement.Triggers.Add(trigger));

            return this;
        }

        public FluentVisualElement<TVisualElement> RemoveTrigger(TriggerBase trigger)
        {
            this.BuilderActions.Add (visualElement => visualElement.Triggers.Remove(trigger));

            return this;
        }

        public FluentVisualElement<TVisualElement> WidthRequest(double width)
        {
            this.BuilderActions.Add (visualElement => visualElement.WidthRequest = width);

            return this;
        }
    }
}