using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Edsofta.Models.NoteModels;

namespace Edsofta.ViewModels.Note
{
    public class NoteVM : INotifyPropertyChanged
    {
        #region i notify property
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        public NoteVM(NoteModels noteModels)
        {
            Title = noteModels.Title;
            //Id = noteModels.Id;
            Body = noteModels.Body;

        }
        public string Title { get; set; }
        //public int Id { get; set; }
        public string Body { get; set; }
    }
}
