using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentMasterDetailPage : FluentMasterDetailPageBase<FluentMasterDetailPage, MasterDetailPage>
    {
        public FluentMasterDetailPage ()
            :base()
        {
        }
        public FluentMasterDetailPage (MasterDetailPage instance)
            :base(instance)
        {
        }
    }
}