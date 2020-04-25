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
    public class QuestionTypeRepository : IBaseRepository<QuestionType>
    {
        public QuestionType Get(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.QuestionTypes.Find(id);
            }
        }

        public List<QuestionType> GetAll()
        {
            using (var db = new ExamSystemEntities())
            {
                return db.QuestionTypes.ToList();
            }
        }

        public List<QuestionType> GetByFilter(Expression<Func<QuestionType, bool>> filter)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.QuestionTypes.Where(filter).ToList();
            }
        }

        public bool Insert(QuestionType model)
        {
            try
            {
                using (var db = new ExamSystemEntities())
                {
                    db.Set<QuestionType>().Add(model);
                    int result = db.SaveChanges();
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Remove(QuestionType model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.QuestionTypes.Remove(model);
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public bool Remove(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                var model = Get(id);
                db.QuestionTypes.Attach(model);
                db.Entry(model).State = EntityState.Deleted;
                var result = db.SaveChanges();
                return result > 0 ? true : false;

            }
        }

        public bool Update(QuestionType model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Entry<QuestionType>(model).State = EntityState.Modified;
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }
    }
}
