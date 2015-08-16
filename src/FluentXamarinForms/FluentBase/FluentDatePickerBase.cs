using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentDatePickerBase<TFluent, T> : FluentView<TFluent, T>
        where TFluent: FluentBase<T>
        where T: DatePicker, new()
    {
        public FluentDatePickerBase ()
            : base ()
        {
        }

        public FluentDatePickerBase (T instance)
            : base (instance)
        {
        }

        public TFluent Date (DateTime date)
        {
            this.BuilderActions.Add (datePicker => {
                    datePicker.Date = date;
                });

            return this as TFluent;
        }

        public TFluent Format (string format)
        {
            this.BuilderActions.Add (datePicker => {
                    datePicker.Format = format;
                });

            return this as TFluent;
        }

        public TFluent MaximumDate (DateTime maximumDate)
        {
            this.BuilderActions.Add (datePicker => {
                    datePicker.MaximumDate = maximumDate;
                });

            return this as TFluent;
        }

        public TFluent MinimumDate (DateTime minimumDate)
        {
            this.BuilderActions.Add (datePicker => {
                    datePicker.MinimumDate = minimumDate;
                });

            return this as TFluent;
        }
    }
}