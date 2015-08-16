using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentEntryCellBase<TFluent, T> : FluentCellBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T : EntryCell, new()
    {
        public FluentEntryCellBase ()
            : base ()
        {
        }

        public FluentEntryCellBase (T instance)
            : base (instance)
        {
        }

        public TFluent Keyboard (Keyboard keyboard)
        {
            this.BuilderActions.Add (entryCell => {
                    entryCell.Keyboard = keyboard;
                });

            return this as TFluent;
        }

        public TFluent Label (string label)
        {
            this.BuilderActions.Add (entryCell => {
                    entryCell.Label = label;
                });

            return this as TFluent;
        }

        public TFluent BindLabel (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (entryCell => {
                    entryCell.SetBinding (EntryCell.LabelProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindLabel<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                           BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (entryCell => {
                    entryCell.SetBinding<TSource> (EntryCell.LabelProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent LabelColor (Color color)
        {
            this.BuilderActions.Add (entryCell => {
                    entryCell.LabelColor = color;
                });

            return this as TFluent;
        }

        public TFluent Placeholder (string placeholder)
        {
            this.BuilderActions.Add (entryCell => {
                entryCell.Placeholder = placeholder;
            });

            return this as TFluent;
        }

        public TFluent BindPlaceholder (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (entryCell => {
                entryCell.SetBinding (EntryCell.PlaceholderProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindPlaceholder<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (entryCell => {
                entryCell.SetBinding<TSource> (EntryCell.PlaceholderProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent Text (string text)
        {
            this.BuilderActions.Add (entryCell => {
                entryCell.Text = text;
            });

            return this as TFluent;
        }

        public TFluent BindText (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (entryCell => {
                entryCell.SetBinding (EntryCell.TextProperty, path, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent BindText<TSource> (Expression<Func<TSource, object>> sourceProperty, 
            BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (entryCell => {
                entryCell.SetBinding<TSource> (EntryCell.TextProperty, sourceProperty, mode, converter, stringFormat);
            });

            return this as TFluent;
        }

        public TFluent XAlign (TextAlignment alignment)
        {
            this.BuilderActions.Add (entryCell => {
                entryCell.XAlign = alignment;
            });

            return this as TFluent;
        }
    }
}