using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentStackLayout : FluentStackLayoutBase<FluentStackLayout, StackLayout>
    {
        public FluentStackLayout ()
            :base()
        {
        }

        public FluentStackLayout (StackLayout instance)
            :base(instance)
        {   
        }
    }
}