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
    public class RecordedExamRepository : IBaseRepository<RecordedExam>
    {
        public RecordedExam Get(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.RecordedExams.Find(id);
            }
        }

        public List<RecordedExam> GetAll()
        {
            using (var db = new ExamSystemEntities())
            {
                return db.RecordedExams.ToList();
            }
        }

        public List<RecordedExam> GetByFilter(Expression<Func<RecordedExam, bool>> filter)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.RecordedExams.Where(filter).ToList();
            }
        }

        public bool Insert(RecordedExam model)
        {
            try
            {
                using (var db = new ExamSystemEntities())
                {
                    db.Set<RecordedExam>().Add(model);
                    int result = db.SaveChanges();
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Remove(RecordedExam model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.RecordedExams.Remove(model);
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public bool Remove(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                var model = Get(id);
                db.RecordedExams.Attach(model);
                db.Entry(model).State = EntityState.Deleted;
                var result = db.SaveChanges();
                return result > 0 ? true : false;

            }
        }

        public bool Update(RecordedExam model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Entry<RecordedExam>(model).State = EntityState.Modified;
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }
    }
}
