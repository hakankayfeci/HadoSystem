using Hado.DL;
using Hado.DL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Hado.SL
{
   
    [ServiceContract]
    public interface IHadoUIService
    {
        [OperationContract]
        Teacher TeacherGet(int id);
        [OperationContract]
        bool TeacherAdd(Teacher teacherModel,string username, int roleid, string password);
        [OperationContract]
        bool TeacherRemove(int teacherid, int userid);
        [OperationContract]
        bool TeacherEdit(Teacher model, string username, string password);
        [OperationContract]
        List<Teacher> TeacherList();
        //User
        [OperationContract]
        User UserGet(int id);
        [OperationContract]
        User Login(string username,string password);
        //Userr
        [OperationContract]
        Lesson LessonGet(int id);
        [OperationContract]
        bool LessonAdd(Lesson lessonModel);
        [OperationContract]
        bool LessonRemove(int id);
        [OperationContract]
        bool LessonEdit(Lesson lessonModel);
        [OperationContract]
        List<Lesson> LessonList(int teacherid);
        //QuestionType
        [OperationContract]
        List<QuestionType> QuestionTypeList();

        //Question
        [OperationContract]
        Question QuestionGet(int lessonid, string content, int qtypeid);
        [OperationContract]
        bool QuestionAdd(Question question);
        [OperationContract]
        bool QuestionRemove(int QuestionId);
        [OperationContract]
        bool QuestionEdit(Question question);
        [OperationContract]
        List<Question> QuestionList();
        [OperationContract]
        List<Question> QuestionListByParameter(int lessonId, string question);

        //QuestionAnswers
        [OperationContract]
        QuestionAnswer QuestionAnswerGet(int id);
        [OperationContract]
        bool QuestionAnswerAdd(QuestionAnswer question);
        [OperationContract]
        bool QuestionAnswerRemove(int questionId);
        [OperationContract]
        bool QuestionAnswerEdit(QuestionAnswer question);
        [OperationContract]
        QuestionAnswer QuestionAnswerListByQuestion(int questionId);
        [OperationContract]
        List<QuestionAnswer> QuestionAnswerList();
        [OperationContract]
        List<QuestionViewModel> QuestionVM(int lessonid, int questiontypeid, int sorusayisi);
        [OperationContract]
        List<QuestionViewModel> QuestionVMRandom(int lessonid, int questiontypeid, int sorusayisi);

        [OperationContract]
        School GetSchool(int teacherid);


    }



}
