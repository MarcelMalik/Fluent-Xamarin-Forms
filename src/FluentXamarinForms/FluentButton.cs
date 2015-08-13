using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentButton : FluentButtonBase<FluentButton, Button>
    {
        public FluentButton ()
        {   
        }

        public FluentButton (Button instance)
            : base(instance)
        {
        }
    }
}