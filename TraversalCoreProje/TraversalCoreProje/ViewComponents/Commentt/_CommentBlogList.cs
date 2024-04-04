using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Commentt
{
    public class _CommentBlogList : ViewComponent
    {
        CommenttManager commenttManager = new CommenttManager(new EfCommenttDal());
        
        Context context = new Context();

        public IViewComponentResult Invoke(int id)
        {
            //yorum sayısı
            ViewBag.CommentCount = context.Commentts.Where(x=>x.DestinationID==id).Count();

            var values = commenttManager.TGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
