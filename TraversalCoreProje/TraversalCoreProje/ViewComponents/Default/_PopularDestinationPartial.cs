using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopularDestinationPartial : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal()); 
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetPopular8RoteList();
            return View(values);
        }
    }
}
