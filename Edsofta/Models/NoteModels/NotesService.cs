using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using Edsofta.ViewModels.Note;

namespace Edsofta.Models.NoteModels
{
    public abstract class NotesService
    {
        static string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string notesJson = File.ReadAllText(APPDATA_PATH + @"\Edsofta\Notes.json");
        private static string SaveToJsonFile(List<NoteVM> noteList, string jsonFileName)
        {
            string jsonString = JsonConvert.SerializeObject(noteList, Formatting.Indented);
            File.WriteAllText(jsonFileName, jsonString);
            return jsonString;
        }
        public static List<NoteVM> GetAllNotes()
        {
            
            List<NoteModels> NoteList = JsonConvert.DeserializeObject<List<NoteModels>>(notesJson);
            List<NoteVM> ConvertedNoteList = new List<NoteVM>();

            foreach (NoteModels note in NoteList)
            {
                ConvertedNoteList.Add(new NoteVM(note));
            }
            return ConvertedNoteList;
        }
        public static void CreateNotes(NoteVM currentNote)
        {
            List<NoteVM> notes = GetAllNotes();
            notes.Add(currentNote);
            SaveToJsonFile(notes, APPDATA_PATH + @"\Edsofta\Notes.json");


        }

    }
}
