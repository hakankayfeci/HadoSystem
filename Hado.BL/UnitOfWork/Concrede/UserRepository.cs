using Hado.BL.UnitOfWork.Abstract;
using Hado.DL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hado.BL.UnitOfWork.Concrede
{
    public class UserRepository : IBaseRepository<User>
    {
        public User Get(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Users.Find(id);
            }
        }

        public List<User> GetAll()
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Users.ToList();
            }
        }

        public List<User> GetByFilter(Expression<Func<User, bool>> filter)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Users.Where(filter).ToList();
            }
        }

        public bool Insert(User model)
        {
            try
            {
                using (var db = new ExamSystemEntities())
                {
                    db.Set<User>().Add(model);
                    int result = db.SaveChanges();
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Remove(User model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Users.Remove(model);
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public bool Remove(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                var model = Get(id);
                db.Users.Attach(model);
                db.Entry(model).State = EntityState.Deleted;
                var result = db.SaveChanges();
                return result > 0 ? true : false;

            }
        }

        public bool Update(User model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Entry<User>(model).State = EntityState.Modified;
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }
    }
}
