using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edsofta.Models.NoteModels;
using System.ComponentModel;
using Edsofta.Commands;

namespace Edsofta.ViewModels.Note
{
    public class NotesVM : INotifyPropertyChanged
    {
        #region iNotify
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        
        public NotesVM()
        {

            addNewNote = new ActivationCommand(AddNotes);
            LoadNotes();
        }
        private List<NoteVM> currentNotes;
        public List<NoteVM> CurrentNotes
        {

            get { return currentNotes; }
            set { currentNotes = value; OnPropertyChanged("currentNotes"); }
        }

        private string title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        private string body;

        public String Body
        {
            get { return body; }
            set { body = value; }
        }
        
        public void LoadNotes()
        {
            currentNotes =NotesService.GetAllNotes();
        }

        
        
        public void AddNotes()
        {
    
         
           //NotesService.CreateNotes();
        }


        private ActivationCommand addNewNote;
        public ActivationCommand AddNewNote
        {
            get { return addNewNote; }
        }
     
    }
}
