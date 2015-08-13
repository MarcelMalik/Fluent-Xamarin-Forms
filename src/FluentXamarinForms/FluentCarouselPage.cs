using System;
using Xamarin.Forms;
using FluentXamarinForms.FluentBase;

namespace FluentXamarinForms
{
    public class FluentCarouselPage : FluentCarouselPageBase<FluentCarouselPage, CarouselPage>
    {
        public FluentCarouselPage ()
            : base()
        {   
        }

        public FluentCarouselPage (CarouselPage instance)
            :base(instance)
        {
        }        
    }
}