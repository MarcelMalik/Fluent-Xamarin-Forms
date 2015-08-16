using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentActivityIndicator : FluentActivityIndicatorBase<FluentActivityIndicator, ActivityIndicator>
    {
        public FluentActivityIndicator ()
            :base()
        {
        }

        public FluentActivityIndicator (ActivityIndicator instance)
            :base(instance)
        {  
        } 
    }
}