using Edsofta.Models;
using System.ComponentModel;
using System.Collections.Generic;
using Edsofta.Commands;
using Edsofta.Models.AppModels;

namespace Edsofta.ViewModels
{
    public class QuestionsViewModel :INotifyPropertyChanged
    {
        #region iNotify
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Constructor
        public QuestionsViewModel()
        {       
           pagePreviousQuestion = new NavigateQuestionCommand(PreviousPage);
           pageNextQuestion = new NavigateQuestionCommand(NextPage);
            LoadData();
           
          
        }
        #endregion
        #region the allQuestionProperty
        private List<QuestionViewModel> allQuestions;
        public List<QuestionViewModel> AllQuestions
        {
            get => allQuestions; 
            set { allQuestions = value; OnPropertyChanged("AllQuestions"); }
        }
        #endregion

        #region CurrentQuestionProp
        private List<QuestionViewModel> currentPageQuestions;
        public List<QuestionViewModel> CurrentPageQuestions
        {
            
            get { return currentPageQuestions; }
            set { currentPageQuestions = value; OnPropertyChanged("currentPageQuestions"); }
        }
        #endregion

        #region LoadData method
        public string SubjectKey { get; set; } = subjectkeyy.sk;
        public void LoadData()
        {
            IsValidated = AppService.GetAppStatus();
            AllQuestions = QuestionsModelService.GetAllQuestions(subjectkeyy.sk);
            LoadNextQuestions();

        }
        #endregion
        public bool IsValidated { get; set; }
        #region Counts of Questions
        public int QuestionCount
        {
            get => AllQuestions.Count;
        }
        public int CurrentPageQuestionCount 
        {
            get => CurrentPageQuestions.Count;
        }
        #endregion 


        #region NavigationProperties
        private NavigateQuestionCommand pageNextQuestion;
        public NavigateQuestionCommand PageNextQuestion
        {
            get { return pageNextQuestion; }

        }

        private NavigateQuestionCommand pagePreviousQuestion;
        public NavigateQuestionCommand PagePreviousQuestion
        {
            get { return pagePreviousQuestion; }
        }
        #endregion

        #region Navigation Commandssss
        int maxPageCount = 3;
        int currentQuestionIndex = 0;
        Stack<List<QuestionViewModel>> backwardStack = new Stack<List<QuestionViewModel>>();  
        public void LoadPrevQuestions()
        {
            if (backwardStack.Count == 0)
            {
                return;
            }
            else
            {
                currentQuestionIndex = currentQuestionIndex - CurrentPageQuestions.Count;
                var currentQuestions = backwardStack.Pop();
                CurrentPageQuestions = currentQuestions;
            }
         
        }

        public void PreviousPage()
        {
            LoadPrevQuestions();
        }

        public void NextPage()
        {
            LoadNextQuestions();
        }
        public void LoadNextQuestions()
        {
            backwardStack.Push(CurrentPageQuestions);
            var currentQuestions = new List<QuestionViewModel>();

            while (currentQuestions.Count < maxPageCount && currentQuestionIndex < AllQuestions.Count)
            {
                if (IsValidated && currentQuestions.Count < 3)
                {
                    currentQuestions.Add(AllQuestions[currentQuestionIndex]);
                    currentQuestionIndex++;
                }
                    
            }
            CurrentPageQuestions = currentQuestions;
        }
        #endregion

    }
    public abstract class subjectkeyy
    {
        public static string sk { get; set; } 
    }
}

























































//public  List<QuestionViewModel> LoadNextQuestions()
//{
//    //if (currentQuestions.Count > 0)
//    //{
//    //    backwardStack.Push(currentQuestions);
//    //}

//    currentQuestions = new List<QuestionViewModel>();

//    while (currentQuestions.Count < maxPageCount && currentQuestionIndex < AllQuestions.Count)
//    {

//        currentQuestions.Add(AllQuestions[currentQuestionIndex]); ;
//        currentQuestionIndex++;
//    }

//    AllQuestions = currentQuestions;
//    return currentQuestions;
//}
