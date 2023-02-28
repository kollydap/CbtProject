using System.ComponentModel;
using Edsofta.Models;
using System.Collections.Generic;

namespace Edsofta.ViewModels
{
    public class QuestionViewModel : INotifyPropertyChanged
    {
        #region i notify property
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    

        #region Constructor setting the properties
        public QuestionViewModel(QuestionsModel questionsModel)
        {

            id = questionsModel.Id;
            question = questionsModel.Question;
            OptionA = questionsModel.OptionA;
            OptionB = questionsModel.OptionB;
            OptionC = questionsModel.OptionC;
            OptionD = questionsModel.OptionD;
            OptionE = questionsModel.OptionE;
            correctAnswer = questionsModel.CorrectAnswer;
        }

        //public QuestionViewModel()
        //{
        //}
        #endregion

        #region Properties
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string question;
        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        private string a;
        public string OptionA
        {
            get { return a; }
            set { a = value; }
        }

        private string b;
        public string OptionB
        {
            get { return b; }
            set { b = value; }
        }

        private string c;
        public string OptionC
        {
            get { return c; }
            set { c = value; }
        }
        private string d;
        public string OptionD
        {
            get { return d; }
            set { d = value; }
        }

        private string e;
        public string OptionE
        {
            get { return e; }
            set { e = value; }
        }

        private string correctAnswer;
        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        private string  selectedAnswer;
        public string  SelectedAnswer
        {
            get { return selectedAnswer == null ? "" : selectedAnswer; }
            set { selectedAnswer = value; }
        }
        private List<string> pickedAnswers;

        public List<string> PickedAnswer
        {
            get { return pickedAnswers; }
            set { pickedAnswers = value; }
        }





    }
    #endregion



}

