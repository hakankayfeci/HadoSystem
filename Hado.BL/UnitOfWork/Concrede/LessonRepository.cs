﻿using Hado.BL.UnitOfWork.Abstract;
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
    public class LessonRepository : IBaseRepository<Lesson>
    {
        public Lesson Get(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Lessons.Find(id);
            }
        }

        public List<Lesson> GetAll()
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Lessons.ToList();
            }
        }

        public List<Lesson> GetByFilter(Expression<Func<Lesson, bool>> filter)
        {
            using (var db = new ExamSystemEntities())
            {
                return db.Lessons.Where(filter).ToList();
            }
        }

        public bool Insert(Lesson model)
        {
            try
            {
                using (var db = new ExamSystemEntities())
                {
                    db.Set<Lesson>().Add(model);
                    int result = db.SaveChanges();
                    return result > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Remove(Lesson model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Lessons.Remove(model);
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }

        public bool Remove(int id)
        {
            using (var db = new ExamSystemEntities())
            {
                var model = Get(id);
                db.Lessons.Attach(model);
                db.Entry(model).State = EntityState.Deleted;
                var result = db.SaveChanges();
                return result > 0 ? true : false;

            }
        }

        public bool Update(Lesson model)
        {
            using (var db = new ExamSystemEntities())
            {
                db.Entry<Lesson>(model).State = EntityState.Modified;
                int result = db.SaveChanges();
                return result > 0 ? true : false;
            }
        }
    }
}
