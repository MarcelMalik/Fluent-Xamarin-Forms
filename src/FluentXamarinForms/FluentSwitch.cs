using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentSwitch  : FluentSwitchBase<FluentSwitch, Switch>
    {
        public FluentSwitch ()
            :base()
        {
        }

        public FluentSwitch (Switch instance)
            :base(instance)
        {
        }
    }
}