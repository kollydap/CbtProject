using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Edsofta.ViewModels;

namespace Edsofta.Models
{
    public abstract class QuestionsModelService
    {
        #region setJson info to string
       
        //private static readonly string questionJson = File.ReadAllText(@"C:\users\HP\source\repos\Edsofta\Edsofta\Resources\Student.json");
        #endregion
        #region List of Question From QuestionListModel
        public static List<QuestionViewModel> GetAllQuestions(string subjectKey)
        {
            string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string questionJson = File.ReadAllText( APPDATA_PATH+@"\Edsofta\"+subjectKey+".json");

            //dto Question Model
            List<QuestionsModel> QuestionList = JsonConvert.DeserializeObject<List<QuestionsModel>>(questionJson);
            List<QuestionViewModel> ConvertedQuestionList = new List<QuestionViewModel >();

            foreach (QuestionsModel question in QuestionList)
            {
                ConvertedQuestionList.Add(new QuestionViewModel(question));
            }
            return ConvertedQuestionList;
        }
        #endregion
    }

    //GetAllQuestion(Accepts the Subject Key as A parameter and passes it to the Question Comparison by string concactenation)
}
