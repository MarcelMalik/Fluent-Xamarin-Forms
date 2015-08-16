//using System;
//using Xamarin.Forms;
//using System.Linq.Expressions;
//
//namespace FluentXamarinForms.FluentBase
//{
//    public abstract class FluentNavigationPageBase<TFluent, T> : FluentPageBase<TFluent, T>
//        where TFluent: FluentBase<T>
//        where T: NavigationPage, new()
//    {
//        private Page root;
//
//        public FluentNavigationPageBase ()
//            : base ()
//        {
//        }
//
//        public FluentNavigationPageBase (T instance)
//            : base (instance)
//        {
//        }
//
//        public FluentNavigationPageBase (Page root)
//            : base ()
//        {
//            this.root = root;
//        }
//
//        public override T Build ()
//        {
//            if (root != null)
//            {
//                Instance = new NavigationPage (root);
//            }
//
//            return base.Build ();
//        }
//
//        public TFluent BarBackgroundColor (Color color)
//        {
//            this.BuilderActions.Add (navigationPage => {
//                    navigationPage.BarBackgroundColor = color;
//                });
//
//            return this as TFluent;
//        }
//
//        public TFluent BindBarBackgroundColor (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
//        {
//            this.BuilderActions.Add (navigationPage => {
//                    navigationPage.SetBinding (NavigationPage.BarBackgroundColorProperty, path, mode, converter, stringFormat);
//                });
//
//            return this as TFluent;
//        }
//
//        public TFluent BindBarBackgroundColor<TSource> (Expression<Func<TSource, object>> sourceProperty, 
//                                                        BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
//        {
//            this.BuilderActions.Add (navigationPage => {
//                    navigationPage.SetBinding<TSource> (NavigationPage.BarBackgroundColorProperty, sourceProperty, mode, converter, stringFormat);
//                });
//
//            return this as TFluent;
//        }
//
//        public TFluent BarTextColor (Color color)
//        {
//            this.BuilderActions.Add (navigationPage => {
//                    navigationPage.BarTextColor = color;
//                });
//
//            return this as TFluent;
//        }
//
//        public TFluent BindBarTextColor (string path, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
//        {
//            this.BuilderActions.Add (navigationPage => {
//                    navigationPage.SetBinding (NavigationPage.BarTextColorProperty, path, mode, converter, stringFormat);
//                });
//
//            return this as TFluent;
//        }
//
//        public TFluent BindBarTextColor<TSource> (Expression<Func<TSource, object>> sourceProperty, 
//                                                  BindingMode mode = BindingMode.Default, IValueConverter converter = null, string stringFormat = null)
//        {
//            this.BuilderActions.Add (navigationPage => {
//                    navigationPage.SetBinding<TSource> (NavigationPage.BarTextColorProperty, sourceProperty, mode, converter, stringFormat);
//                });
//
//            return this as TFluent;
//        }
//    }
//}