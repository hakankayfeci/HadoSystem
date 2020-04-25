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
    public class TeacherRepository : IBaseRepository<Teacher>
    {
        public Teacher Get(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Teachers.Find(id);
            }
        }

        public List<Teacher> GetAll()
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Teachers.ToList();
            }
        }

        public List<Teacher> GetByFilter(Expression<Func<Teacher, bool>> filter)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Teachers.Where(filter).ToList();
            }
        }

        public bool Insert(Teacher model)
        {
            try
            {
                using (var db = new ExamSystemEntities())
                {
                    db.Set<Teacher>().Add(model);
                    int result = db.SaveChanges();
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Remove(Teacher model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Teachers.Remove(model);
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public bool Remove(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                var model = Get(id);
                db.Teachers.Attach(model);
                db.Entry(model).State = EntityState.Deleted;
                var result = db.SaveChanges();
                return result > 0 ? true : false;

            }
        }

        public bool Update(Teacher model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Entry<Teacher>(model).State = EntityState.Modified;
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }
    }
}
