using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WSAD_Chp4_Ex1
{
    class NotesCollection
    {
        public static ObservableCollection<Note> Notes = new ObservableCollection<Note>();
    }
    class Note
    {
        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public Note(string Title, string Content)
        {
            title = Title;
            content = Content;
        }
        public override string ToString()
        {
            return Title +": "+ Content;
        }
    }
}
