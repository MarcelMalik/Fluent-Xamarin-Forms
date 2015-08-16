using System;
using Xamarin.Forms;
using System.Windows.Input;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentImageCellBase<TFluent, T> : FluentTextCellBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T : ImageCell, new()
    {
        public FluentImageCellBase ()
            : base ()
        {
        }

        public FluentImageCellBase (T instance)
            : base (instance)
        {
        }

        public TFluent Source (string source)
        {
            this.BuilderActions.Add (imageCell => {
                    imageCell.ImageSource = source;
                });

            return this as TFluent;
        }

        public TFluent FromFile (string fileName)
        {
            this.BuilderActions.Add (imageCell => {
                    imageCell.ImageSource = ImageSource.FromFile (fileName);
                });

            return this as TFluent;
        }

        public TFluent FromUri (Uri uri)
        {
            this.BuilderActions.Add (imageCell => {
                    imageCell.ImageSource = ImageSource.FromUri (uri);
                });

            return this as TFluent;
        }

        public TFluent FromResource (string resource)
        {
            this.BuilderActions.Add (imageCell => {
                    imageCell.ImageSource = ImageSource.FromResource (resource);
                });

            return this as TFluent;
        }

        public TFluent FromStream (Func<System.IO.Stream> stream)
        {
            this.BuilderActions.Add (imageCell => {
                    imageCell.ImageSource = ImageSource.FromStream (stream);
                });

            return this as TFluent;
        }

        public TFluent BindSource (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (imageCell => {
                imageCell.SetBinding (ImageCell.ImageSourceProperty, 
                    new Binding (path, mode, converter, stringFormat));
            });
            return this as TFluent;

        }

        public TFluent BindSource<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (imageCell => {
                imageCell.SetBinding<TSource> (ImageCell.ImageSourceProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }
    }
}