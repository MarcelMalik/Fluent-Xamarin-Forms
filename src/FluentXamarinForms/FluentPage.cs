using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentPage : FluentPageBase<FluentPage, Page>
    {
        public FluentPage ()
            :base()
        {
        }

        public FluentPage (Page instance)
            : base(instance)
        {
        }
    }
}