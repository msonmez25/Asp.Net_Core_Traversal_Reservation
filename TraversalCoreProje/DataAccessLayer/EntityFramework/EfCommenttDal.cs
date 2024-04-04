using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommenttDal : GenericRepository<Commentt>, ICommenttDal
    {
        public List<Commentt> GetListCommentWithDestination()
        {
            using(var c= new Context()) 
            {
                return c.Commentts.Include(x => x.Destination).ToList();
            }
        }

        public List<Commentt> GetListCommentWithDestination(int id)
        {
            using (var c = new Context())
            {
                return c.Commentts.Where(x => x.CommentID == id).Include(x => x.Destination).ToList();
            }
        }

        public List<Commentt> GetListCommentWithDestinationAndUser(int id)
        {
            using (var c = new Context())
            {
                return c.Commentts.Where(x=>x.DestinationID==id).Include(x => x.AppUser).ToList();
            }
        }

        public List<Commentt> GetListCommentWithUser(int id)
        {
            using (var c = new Context())
            {
                return c.Commentts.Where(x => x.AppUserID==id).Include(x => x.Destination).ToList();
            }
        }

        public List<Commentt> GetListCommentWithUser()
        {
            using (var c = new Context())
            {
                return c.Commentts.Include(y=>y.Destination).Include(x => x.AppUser).ToList();
            }
        }
    }
}
