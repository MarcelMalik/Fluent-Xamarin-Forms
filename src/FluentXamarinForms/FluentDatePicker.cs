using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentDatePicker : FluentDatePickerBase<FluentDatePicker, DatePicker>
    {
        public FluentDatePicker ()
            : base ()
        {
        }

        public FluentDatePicker (DatePicker instance)
            : base (instance)
        {
        }
    }
}