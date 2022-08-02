using CCSANoteApp.Domain.Models;

namespace CCSA_Web.Services
{
    public interface INoteService
    {
        //C-R-U-D
        void CreateNote(Note note);
        void CreateNote(User noteCreator, string title, string content, GroupName group);
        void UpdateNote(Guid id, Note note);
        void UpdateNote(Guid id, string content);
        void UpdateNoteTitle(Guid id, string title);
        void DeleteNote(Guid id);
        void DeleteNotes();
        List<Note> FetchNote();
        List<Note> FetchNoteByUser(Guid id);
        Note FetchNoteById(Guid id);
        List<Note> FetchNoteByGroup(Guid userId, GroupName group);
    }
}
