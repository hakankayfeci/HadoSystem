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
    public class QuestionAnswerRepository : IBaseRepository<QuestionAnswer>
    {
        public QuestionAnswer Get(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.QuestionAnswers.Find(id);
            }
        }

        public List<QuestionAnswer> GetAll()
        {
            using (var db = new ExamSystemEntities())
            {
                return db.QuestionAnswers.ToList();
            }
        }

        public List<QuestionAnswer> GetByFilter(Expression<Func<QuestionAnswer, bool>> filter)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.QuestionAnswers.Where(filter).ToList();
            }
        }

        public bool Insert(QuestionAnswer model)
        {
            try
            {
                using (var db = new ExamSystemEntities())
                {
                    db.Set<QuestionAnswer>().Add(model);
                    int result = db.SaveChanges();
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Remove(QuestionAnswer model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.QuestionAnswers.Remove(model);
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public bool Remove(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                var model = db.QuestionAnswers.Where(x=>x.QuestionId==id).FirstOrDefault();
                db.QuestionAnswers.Attach(model);
                db.Entry(model).State = EntityState.Deleted;
                var result = db.SaveChanges();
                return result > 0 ? true : false;

            }
        }

        public bool Update(QuestionAnswer model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Entry<QuestionAnswer>(model).State = EntityState.Modified;
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }
    }
}
