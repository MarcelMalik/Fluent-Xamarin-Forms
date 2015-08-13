using System;
using FluentXamarinForms.FluentBase;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public class FluentEditor : FluentEditorBase<FluentEditor, Editor>
    {
        public FluentEditor ()
            : base ()
        {
        }

        public FluentEditor (Editor instance)
            : base (instance)
        {
        }
    }
}