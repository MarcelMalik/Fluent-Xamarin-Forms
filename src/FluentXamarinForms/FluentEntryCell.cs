using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentEntryCell : FluentEntryCellBase<FluentEntryCell, EntryCell>
    {
        public FluentEntryCell ()
            : base ()
        {
        }

        public FluentEntryCell (EntryCell instance)
            : base (instance)
        {
        }
    }
}