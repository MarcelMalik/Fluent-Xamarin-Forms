using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentGrid : FluentGridBase<FluentGrid, Grid>
    {
        public FluentGrid ()
            : base ()
        {
        }

        public FluentGrid (Grid instance)
            : base (instance)
        {
        }
    }
}