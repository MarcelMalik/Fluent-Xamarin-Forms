using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentContentView : FluentContentViewBase<FluentContentView, ContentView>
    {
        public FluentContentView ()
            : base ()
        {
        }

        public FluentContentView (ContentView instance)
            : base (instance)
        {
        }
    }
}