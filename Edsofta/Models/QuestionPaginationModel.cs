using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edsofta.Models
{
    class QuestionPaginationModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public QuestionPaginationModel()
        {
            currentPage = 1;
            totalPages = 1;
        }

        private int totalQuestions;
        public int Totalquestions
        {
            get => totalQuestions;
            set { totalQuestions = value;OnPropertyChanged("Totalquestions"); }
        }

        private  int questionsPerPage;
        public  int QuestionsPerPage 
        {
            get => questionsPerPage;
            set { questionsPerPage = value; OnPropertyChanged("QuestionsPerPage"); }
        }

        private int currentPage;
        public int CurrentPage
        {
            get => currentPage;
            set { currentPage = value; OnPropertyChanged("CurrentPage"); }
        }

        private int totalPages;
        public int TotalPages
        {
            get => totalPages;
            set { totalPages = value; OnPropertyChanged("TotalPages"); }
        }

    }
}
