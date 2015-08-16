using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentBoxView : FluentBoxViewBase<FluentBoxView, BoxView>
    {
        public FluentBoxView ()
            :base()
        {
        }

        public FluentBoxView (BoxView instance)
            :base(instance)
        {
        }
    }
}