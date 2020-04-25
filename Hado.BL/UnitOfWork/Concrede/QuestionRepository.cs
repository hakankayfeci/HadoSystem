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
    public class QuestionRepository : IBaseRepository<Question>
    {
        public Question Get(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Questions.Find(id);
            }
        }
        public Question GetFilter(int lessonid, string content, int qtypeid)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Questions.Where(x => x.LessonId == lessonid && x.Question1 == content && x.QuestionType == qtypeid).FirstOrDefault();
            }
        }

        public List<Question> GetAll()
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Questions.ToList();
            }
        }

        public List<Question> GetByFilter(Expression<Func<Question, bool>> filter)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Questions.Where(filter).ToList();
            }
        }

        public bool Insert(Question model)
        {
            try
            {
                using (var db = new ExamSystemEntities())
                {
                    db.Set<Question>().Add(model);
                    int result = db.SaveChanges();
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Remove(Question model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Questions.Remove(model);
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public bool Remove(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                var model = Get(id);
                db.Questions.Attach(model);
                db.Entry(model).State = EntityState.Deleted;
                var result = db.SaveChanges();
                return result > 0 ? true : false;

            }
        }

        public bool Update(Question model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Entry<Question>(model).State = EntityState.Modified;
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }
    }
}
