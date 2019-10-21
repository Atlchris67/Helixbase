
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;
//using Helixbase.Feature.Navigation.Mediators;
//using Helixbase.Foundation.Core.Exceptions;

namespace Helixbase.Feature.Navigation.Controllers
{
    public class NavigationController : SitecoreController
    {
        //private readonly INavigationMediator _NavigationMediator;

        //public NavigationController(INavigationMediator NavigationMediator)
        //{
        //    _NavigationMediator = NavigationMediator;
        //}

        public ActionResult Navigation()
        {
            
               string navDataSourceId = RenderingContext.Current.Rendering.DataSource;
            return View("");

            //var mediatorResponse = _NavigationMediator.RequestNavigationViewModel();

            //switch (mediatorResponse.Code)
            //{
            //    case MediatorCodes.NavigationResponse.DataSourceError:
            //    case MediatorCodes.NavigationResponse.ViewModelError:
            //        return View("~/views/Navigation/Error.cshtml");
            //    case MediatorCodes.NavigationResponse.Ok:
            //        return View(mediatorResponse.ViewModel);
            //    default:
            //        throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            //}
        }
    }
}