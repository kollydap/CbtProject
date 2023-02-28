using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Edsofta.ViewModels;
using Edsofta.UtilityClasses;
using Edsofta.Views.Modals;
using Edsofta.Models;



namespace Edsofta.Views
{
    public partial class EdsoftaDesktop9 : Page
    {
        QuestionsViewModel QuestionsVModel;
        public EdsoftaDesktop9()
        {
            InitializeComponent();
            QuestionsVModel = (QuestionsViewModel)this.DataContext;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton == null)
                return;
            var radioButtonContent = radioButton.Content.ToString();
            var question = radioButton.GetParentOfType<StackPanel>().DataContext as QuestionViewModel;
            question.SelectedAnswer = radioButtonContent;
        }

        private void Submit_Exam(object sender, RoutedEventArgs e)
        {
            int CorrectAnswerNo = 0;
            List<QuestionViewModel> WrongQuestions = new List<QuestionViewModel>();

            foreach (QuestionViewModel question in QuestionsVModel.AllQuestions)
            {
                if (question.CorrectAnswer == question.SelectedAnswer)
                {
                    CorrectAnswerNo++;
                }
                else
                {
                    WrongQuestions.Add(question);
                }
            }
            MessageBox.Show($"{CorrectAnswerNo}/{QuestionsVModel.AllQuestions.Count}");
            MessageBox.Show($"You got {WrongQuestions.Count} Questions Wrong");
            foreach (QuestionViewModel wrongQuestions in WrongQuestions)
            {
                MessageBox.Show($"{wrongQuestions.Id} {wrongQuestions.Question} answer is {wrongQuestions.CorrectAnswer}");
            }

            
           
        }

        private void OpenHomePage(object sender, RoutedEventArgs e)
        {
            EdsoftaDesktop edsoftaDesktop = new EdsoftaDesktop();
            edsoftaDesktop.Show();
           

        }

      

        private void OpenNotesPage(object sender, RoutedEventArgs e)
        {
            NotesPage notesPage = new NotesPage();
            notesPage.Show();
        }
    }  
}
