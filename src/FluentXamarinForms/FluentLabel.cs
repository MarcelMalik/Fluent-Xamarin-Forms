using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentLabel : FluentLabelBase<FluentLabel, Label>
    {
        public FluentLabel ()
            :base()
        {   
        }

        public FluentLabel (Label instance)
            : base (instance)
        {
        }
    }
}