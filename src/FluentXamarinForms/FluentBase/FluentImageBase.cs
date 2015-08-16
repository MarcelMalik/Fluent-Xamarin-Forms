using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentImageBase<TFluent, T> : FluentView<TFluent, T>
        where TFluent : FluentBase<T>
        where T: Image, new()
    {
        public FluentImageBase ()
            : base ()
        {
        }

        public FluentImageBase (T instance)
            : base (instance)
        {
        }

        public TFluent AspectFill ()
        {
            this.BuilderActions.Add (image => {
                    image.Aspect = Aspect.AspectFill;
                });

            return this as TFluent;
        }

        public TFluent AspectFit ()
        {
            this.BuilderActions.Add (image => {
                    image.Aspect = Aspect.AspectFit;
                });

            return this as TFluent;
        }

        public TFluent Fill ()
        {
            this.BuilderActions.Add (image => {
                    image.Aspect = Aspect.Fill;
                });

            return this as TFluent;
        }

        public TFluent IsOpaque (bool opaque)
        {
            this.BuilderActions.Add (image => {
                    image.IsOpaque = opaque;
                });

            return this as TFluent;
        }

        public TFluent Source (string source)
        {
            this.BuilderActions.Add (image => {
                    image.Source = source;
                });

            return this as TFluent;
        }

        public TFluent FromFile (string fileName)
        {
            this.BuilderActions.Add (image => {
                    image.Source = ImageSource.FromFile (fileName);
                });

            return this as TFluent;
        }

        public TFluent FromUri (Uri uri)
        {
            this.BuilderActions.Add (image => {
                    image.Source = ImageSource.FromUri (uri);
                });

            return this as TFluent;
        }

        public TFluent FromResource (string resource)
        {
            this.BuilderActions.Add (image => {
                    image.Source = ImageSource.FromResource (resource);
                });

            return this as TFluent;
        }

        public TFluent FromStream (Func<System.IO.Stream> stream)
        {
            this.BuilderActions.Add (image => {
                    image.Source = ImageSource.FromStream (stream);
                });

            return this as TFluent;
        }
    }
}