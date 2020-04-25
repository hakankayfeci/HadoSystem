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
    public class SchoolRepository :IBaseRepository<School>
    {
        public School Get(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Schools.Find(id);
            }
        }

        public List<School> GetAll()
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Schools.ToList();
            }
        }

        public List<School> GetByFilter(Expression<Func<School, bool>> filter)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Schools.Where(filter).ToList();
            }
        }

        public bool Insert(School model)
        {
            try
            {
                using (var db = new ExamSystemEntities())
                {
                    db.Set<School>().Add(model);
                    int result = db.SaveChanges();
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Remove(School model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Schools.Remove(model);
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public bool Remove(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                var model = Get(id);
                db.Schools.Attach(model);
                db.Entry(model).State = EntityState.Deleted;
                var result = db.SaveChanges();
                return result > 0 ? true : false;

            }
        }

        public bool Update(School model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Entry<School>(model).State = EntityState.Modified;
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }
    }
}
