using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentAbsoluteLayout : FluentAbsoluteLayoutBase<FluentAbsoluteLayout, AbsoluteLayout, View>
    {
        public FluentAbsoluteLayout ()
            : base ()
        {
        }

        public FluentAbsoluteLayout (AbsoluteLayout instance)
            : base (instance)
        {
        }
    }
}