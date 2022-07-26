//using Autofac;
//using WpfAppAutoWireViewModel.Infrastructure.Interfaces.Views.Base;

//namespace WpfAppAutoWireViewModel.Views.ViewLocator
//{
//    public static class ViewLocatorService
//    {
//        public static IContainer InjectContainer { get; set; }

//        public static T GetView<T>() where T : IView
//        {
//            return InjectContainer.Resolve<T>();
//        }

//        //public static T GetViewModel<T>(string paramName = null, object param = null) where T : IViewModel
//        //{
//        //    if (param != null) return InjectContainer.Get<T>(new ConstructorArgument(paramName, param));
//        //    return InjectContainer.Get<T>();
//        //}
//    }
//}