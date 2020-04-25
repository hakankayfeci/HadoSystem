using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Hado.BL.Facade;
using Hado.BL.UnitOfWork.Concrede;
using Hado.DL;
using Hado.DL.ViewModel;

namespace Hado.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HadoUIService : IHadoUIService
    {
        TeacherRepository teacherRepository = new TeacherRepository();
        UserRepository userRepository = new UserRepository();
        LessonRepository lessonRepository = new LessonRepository();
        QuestionTypeRepository questionTypeRepository = new QuestionTypeRepository();
        QuestionAnswerRepository questionAnswerRepository = new QuestionAnswerRepository();
        QuestionRepository questionRepository = new QuestionRepository();
        SchoolRepository schoolRepository = new SchoolRepository();
        Facade facade = new Facade(); 

        #region Teacher
        public bool TeacherAdd(Teacher teacherModel,string username, int roleid,string password)
        {
            var userresult = userRepository.Insert(new User {Username = username.ToLower(), RoleId = roleid ,Password=password });
            var usermodel = userRepository.GetByFilter(x => x.Username == username).FirstOrDefault();
            teacherModel.UserId = usermodel.UserId;
            var teacherresult = teacherRepository.Insert(teacherModel);
            return teacherresult;
        }

        public bool TeacherEdit(Teacher model,string username,string password)
        {
            var usermodel = userRepository.GetByFilter(x => x.UserId == model.UserId).FirstOrDefault();
            userRepository.Update(new User {UserId=usermodel.UserId,RoleId=usermodel.RoleId,Username=username,Password=password });
            var result = teacherRepository.Update(model);
            return result;
        }

        public Teacher TeacherGet(int id)
        {
            return teacherRepository.Get(id);
        }
        
        public List<Teacher> TeacherList()
        {
            return teacherRepository.GetAll();
        }

        public bool TeacherRemove(int teacherid,int userid)
        {
            var result = teacherRepository.Remove(teacherid);
            var userresult = userRepository.Remove(userid);
            return  result==true && userresult==true ? true : false;
        }
        #endregion

        #region User

        public User UserGet(int id)
        {
            return userRepository.GetByFilter(x=>x.UserId==id).FirstOrDefault();
        }

        public User Login(string username, string password)
        {
            return facade.Check(username,password);
        }

        #endregion

        #region Lesson

        public Lesson LessonGet(int id)
        {
            return lessonRepository.Get(id);
        }

        public bool LessonAdd(Lesson lessonModel)
        {
            return lessonRepository.Insert(lessonModel);
        }

        public bool LessonRemove(int id)
        {
            return lessonRepository.Remove(id);
        }

        public bool LessonEdit(Lesson lessonModel)
        {
            return lessonRepository.Update(lessonModel);
        }

        public List<Lesson> LessonList(int teacherid)
        {
            return lessonRepository.GetByFilter(x=>x.TeacherId==teacherid);
        }
        #endregion

        #region QuestionType
        public List<QuestionType> QuestionTypeList()
        {
            return questionTypeRepository.GetAll();
        }
        #endregion
        #region QuestionFunction
        public Question QuestionGet(int lessonid,string content,int qtypeid)
        {
            return questionRepository.GetFilter(lessonid,content,qtypeid);
        }

        public bool QuestionAdd(Question question)
        {
            var qresult = questionRepository.Insert(question);
            return qresult;
        }

        public bool QuestionRemove(int QuestionId)
        {
            return questionRepository.Remove(QuestionId);
        }

        public bool QuestionEdit(Question question)
        {
            return questionRepository.Update(question);
        }

        public List<Question> QuestionList()
        {
            return questionRepository.GetAll();
        }

        public List<Question> QuestionListByParameter(int lessonId,string question)
        {
            return questionRepository.GetByFilter(x => x.LessonId == lessonId || x.Question1 == question);
        }
        #endregion
        #region QuestionAnswer

        public QuestionAnswer QuestionAnswerGet(int id)
        {
            return questionAnswerRepository.Get(id);
        }

        public bool QuestionAnswerAdd(QuestionAnswer question)
        {
            return questionAnswerRepository.Insert(question);
        }

        public bool QuestionAnswerRemove(int questionId)
        {
            return questionAnswerRepository.Remove(questionId);
        }

        public bool QuestionAnswerEdit(QuestionAnswer question)
        {
            return questionAnswerRepository.Update(question);
        }

        public QuestionAnswer QuestionAnswerListByQuestion(int questionId)
        {
            return questionAnswerRepository.GetByFilter(x => x.QuestionId == questionId).FirstOrDefault();
        }

        public List<QuestionAnswer> QuestionAnswerList()
        {
            return questionAnswerRepository.GetAll();
        }
        #endregion

        #region QuestionViewFuncs
        public List<QuestionViewModel> QuestionVM(int lessonid, int questiontypeid, int sorusayisi)
        {
            List<QuestionViewModel> viewmodel = new List<QuestionViewModel>();
            List<Question> questions = new List<Question>();
            var quest = questionRepository.GetByFilter(x=>x.LessonId==lessonid && x.QuestionType==questiontypeid);
            for (int i = 0; i < sorusayisi; i++)
            {
                questions.Add(quest[i]);
            }
            foreach (var item in questions)
            {
                var answer = questionAnswerRepository.GetByFilter(x => x.QuestionId == item.QuestionId).FirstOrDefault();
                viewmodel.Add(new QuestionViewModel
                {
                    LessonId = lessonid,
                    QuestionType = item.QuestionType,
                    QuestionAnswers = answer.QuestionAnswers,
                    QAId = answer.QAId,
                    Question1 = item.Question1,
                    QuestionId = item.QuestionId
                });
            }
            return viewmodel;
        }

        public List<QuestionViewModel> QuestionVMRandom(int lessonid, int questiontypeid, int sorusayisi)
        {
            List<QuestionViewModel> viewmodel = new List<QuestionViewModel>();
            List<Question> questions = new List<Question>();
            Random rnd = new Random();

            var quest = questionRepository.GetByFilter(x => x.LessonId == lessonid && x.QuestionType == questiontypeid);
            int[] sayilar = new int[30];

            for (int i = 0; i < sorusayisi; i++)
            {
                int randomyeni = rnd.Next(0, quest.Count());
                if (sayilar.Contains(randomyeni))
                {
                    i--;
                }
                else
                {
                    sayilar[i] = randomyeni;
                }
            }

            for (int i = 0; i < sorusayisi; i++)
            {
                questions.Add(quest[sayilar[i]]);
            }

            foreach (var item in questions)
            {
                var answer = questionAnswerRepository.GetByFilter(x => x.QuestionId == item.QuestionId).FirstOrDefault();
                viewmodel.Add(new QuestionViewModel
                {
                    LessonId = lessonid,
                    QuestionType = item.QuestionType,
                    QuestionAnswers = answer.QuestionAnswers,
                    QAId = answer.QAId,
                    Question1 = item.Question1,
                    QuestionId = item.QuestionId
                });
            }
            return viewmodel;
        }


        #endregion
        #region School
        public School GetSchool(int teacherid)
        {
            var teacher = teacherRepository.Get(teacherid);
            return schoolRepository.Get(teacher.SchoolId);
        }
        #endregion
    }
}
