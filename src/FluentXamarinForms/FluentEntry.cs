using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentEntry : FluentEntryBase<FluentEntry, Entry>
    {
        public FluentEntry ()
            : base ()
        {
        }

        public FluentEntry (Entry instance)
            : base (instance)
        {
        }
    }
}