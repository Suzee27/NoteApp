using CCSANoteApp.Domain.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSANoteApp.DB.Mappings
{
    public class NoteMap: ClassMap<Note>
    {
        public NoteMap()
        {
            Table("Notes");
            Id(Note => Note.Id);
            Map(Note => Note.NoteCreator);
            Map(Note => Note.Content);
            Map(Note => Note.Title);
            Map(Note => Note.Group);
            Map(Note => Note.CreatedDate);
            Map(Note => Note.UpdatedDate);
        }
        
    }
}
