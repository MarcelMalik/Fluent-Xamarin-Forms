using System;
using Xamarin.Forms;

namespace FluentXamarinForms.FluentBase
{
    public abstract class FluentCarouselPageBase<TFluent, T> : FluentMultiPageBase<TFluent, T, ContentPage>
        where TFluent: FluentBase<T>
        where T: CarouselPage, new()
    {
        public FluentCarouselPageBase ()
            : base()
        {   
        }

        public FluentCarouselPageBase (T instance)
            :base(instance)
        {
        }
    }
}