using System;
using Xamarin.Forms;
using System.Linq.Expressions;

namespace FluentXamarinForms.FluentBase
{
    public class FluentMasterDetailPageBase<TFluent, T> : FluentPageBase<TFluent, T>
        where TFluent: FluentBase<T>
        where T: MasterDetailPage, new()
    {
        public FluentMasterDetailPageBase ()
            : base ()
        {
        }

        public FluentMasterDetailPageBase (T instance)
            : base (instance)
        {
        }

        public TFluent Detail (Page page)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.Detail = page;
                });

            return this as TFluent;
        }

        public TFluent IsGestureEnabled (bool enabled)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.IsGestureEnabled = enabled;
                });

            return this as TFluent;
        }

        public TFluent BindIsGestureEnabled (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.SetBinding (MasterDetailPage.IsGestureEnabledProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindIsGestureEnabled<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                                      BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.SetBinding<TSource> (MasterDetailPage.IsGestureEnabledProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent IsPresented (bool enabled)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.IsPresented = enabled;
                });

            return this as TFluent;
        }

        public TFluent BindIsPresented (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.SetBinding (MasterDetailPage.IsPresentedProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindIsPresented<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                                 BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.SetBinding<TSource> (MasterDetailPage.IsPresentedProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent Master (Page page)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.Master = page;
                });

            return this as TFluent;
        }

        public TFluent MasterBehavior (MasterBehavior behavior)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.MasterBehavior = behavior;
                });

            return this as TFluent;
        }

        public TFluent BindMasterBehavior (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.SetBinding (MasterDetailPage.MasterBehaviorProperty, path, mode, converter, stringFormat);
                });

            return this as TFluent;
        }

        public TFluent BindMasterBehavior<TSource> (Expression<Func<TSource, object>> sourceProperty, 
                                                    BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
        {
            this.BuilderActions.Add (masterDetailPage => {
                    masterDetailPage.SetBinding<TSource> (MasterDetailPage.MasterBehaviorProperty, sourceProperty, mode, converter, stringFormat);
                });

            return this as TFluent;
        }
    }
}