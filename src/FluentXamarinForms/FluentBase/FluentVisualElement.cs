using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentVisualElement<TFluent, T> : FluentElement<TFluent, T>
        where TFluent: FluentBase<T>
        where T : VisualElement, new()
    {
        public FluentVisualElement ()
            : base ()
        {
        }

        public FluentVisualElement (T instance)
            : base (instance)
        {
        }

        public TFluent AnchorX (double value)
        {
            this.BuilderActions.Add (visualElement => visualElement.AnchorX = value);

            return this as TFluent;
        }

        public TFluent AnchorY (double value)
        {
            this.BuilderActions.Add (visualElement => visualElement.AnchorY = value);

            return this as TFluent;
        }

        public TFluent BackgroundColor (Color color)
        {
            this.BuilderActions.Add (visualElement => visualElement.BackgroundColor = color);

            return this as TFluent;
        }

        public TFluent AddBehavior (Behavior behavior)
        {
            this.BuilderActions.Add (visualElement => visualElement.Behaviors.Add (behavior));

            return this as TFluent;
        }

        public TFluent RemoveBehavior (Behavior behavior)
        {
            this.BuilderActions.Add (visualElement => visualElement.Behaviors.Remove (behavior));

            return this as TFluent;
        }

        public TFluent HeightRequest (double height)
        {
            this.BuilderActions.Add (visualElement => visualElement.HeightRequest = height);

            return this as TFluent;
        }

        public TFluent InputTransparent (bool transparent)
        {
            this.BuilderActions.Add (visualElement => visualElement.InputTransparent = transparent);

            return this as TFluent;
        }

        public TFluent IsEnabled (bool enabled)
        {
            this.BuilderActions.Add (visualElement => visualElement.IsEnabled = enabled);

            return this as TFluent;
        }

        public TFluent IsVisible (bool visible)
        {
            this.BuilderActions.Add (visualElement => visualElement.IsVisible = visible);

            return this as TFluent;
        }

        public TFluent IsVisibleBinding (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null,
                                        object converterParameter = null, string stringFormat = null, object source = null)
        {
            this.BuilderActions.Add (visualElement => {
                    visualElement.SetBinding (VisualElement.IsVisibleProperty,
                        new Binding (path, mode, converter, converterParameter, stringFormat, source));
                });

            return this as TFluent;
        }

        public TFluent MinimumHeightRequest (double minimumHeight)
        {
            this.BuilderActions.Add (visualElement => visualElement.MinimumHeightRequest = minimumHeight);

            return this as TFluent;
        }

        public TFluent MinimumWidthRequest (double minimumWidth)
        {
            this.BuilderActions.Add (visualElement => visualElement.MinimumWidthRequest = minimumWidth);

            return this as TFluent;
        }

        public TFluent Opacity (double opacity)
        {
            this.BuilderActions.Add (visualElement => visualElement.Opacity = opacity);

            return this as TFluent;
        }

        public TFluent Resources (ResourceDictionary resourceDictionary)
        {
            this.BuilderActions.Add (visualElement => visualElement.Resources = resourceDictionary);

            return this as TFluent;
        }

        public TFluent AddResource (Style implicitStyle)
        {
            this.BuilderActions.Add (visualElement => visualElement.Resources.Add (implicitStyle));

            return this as TFluent;
        }

        public TFluent RemoveResource (string implicitStyleName)
        {
            this.BuilderActions.Add (visualElement => visualElement.Resources.Remove (implicitStyleName));

            return this as TFluent;
        }

        public TFluent Rotation (double rotation)
        {
            this.BuilderActions.Add (visualElement => visualElement.Rotation = rotation);

            return this as TFluent;
        }

        public TFluent RotationX (double rotation)
        {
            this.BuilderActions.Add (visualElement => visualElement.RotationX = rotation);

            return this as TFluent;
        }

        public TFluent RotationY (double rotation)
        {
            this.BuilderActions.Add (visualElement => visualElement.RotationY = rotation);

            return this as TFluent;
        }

        public TFluent Scale (double scale)
        {
            this.BuilderActions.Add (visualElement => visualElement.Scale = scale);

            return this as TFluent;
        }

        public TFluent Style (Style style)
        {
            this.BuilderActions.Add (visualElement => visualElement.Style = style);

            return this as TFluent;
        }

        public TFluent TranslationX (double translation)
        {
            this.BuilderActions.Add (visualElement => visualElement.TranslationX = translation);

            return this as TFluent;
        }

        public TFluent TranslationY (double translation)
        {
            this.BuilderActions.Add (visualElement => visualElement.TranslationY = translation);

            return this as TFluent;
        }

        public TFluent AddTrigger (TriggerBase trigger)
        {
            this.BuilderActions.Add (visualElement => visualElement.Triggers.Add (trigger));

            return this as TFluent;
        }

        public TFluent RemoveTrigger (TriggerBase trigger)
        {
            this.BuilderActions.Add (visualElement => visualElement.Triggers.Remove (trigger));

            return this as TFluent;
        }

        public TFluent WidthRequest (double width)
        {
            this.BuilderActions.Add (visualElement => visualElement.WidthRequest = width);

            return this as TFluent;
        }
    }
}