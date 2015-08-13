using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentContentPage : FluentContentPageBase<FluentContentPage, ContentPage>
    {
        public FluentContentPage ()
            :base()
        {
        }

        public FluentContentPage (ContentPage instance)
            : base(instance)
        {
        }
    }
}