using CCSA_Web.DTOs;
using CCSA_Web.Services;
using CCSANoteApp.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CCSA_Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        public INoteService NoteService { get; }
        public NoteController(INoteService noteService)
        {
            NoteService = noteService;
        }
        [HttpPost("byNote")]
        public IActionResult CreateNote([FromBody] NoteDto note)
        {
            NoteService.CreateNote(note.NoteCreator, note.Title, note.Content, note.Group);
            return Ok("Created Successfully");
        }

        [HttpPost]
        public IActionResult CreateNote(User noteCreator, string title, string content, GroupName group)
        {
            NoteService.CreateNote(noteCreator, title, content, group);
            return Ok("Created Successfully");
        }
        [HttpDelete]
        public IActionResult DeleteNote(Guid id)
        {
            NoteService.DeleteNote(id);
            return Ok("Deleted Successfully");
        }

        [HttpDelete("multiple")]
        public IActionResult DeleteNote()
        {
            NoteService.DeleteNotes();
            return Ok("Deleted Successfully");
        }
        [HttpGet("note")]
        public IActionResult FetchNote()
        {
            return Ok(NoteService.FetchNote());
        }
        [HttpGet("notegroup")]
        public IActionResult FetchNoteByGroup(Guid userId, GroupName group)
        {
            return Ok(NoteService.FetchNoteByGroup(userId,group));
        }

        [HttpGet("byId/{id}")]
        public IActionResult FetchNoteById(Guid id)
        {
            return Ok(NoteService.FetchNoteById(id));
        }

        [HttpGet("byUser/{id}")]
        public IActionResult FetchNoteByUser(Guid id)
        {
            return Ok(NoteService.FetchNoteByUser(id));
        }
        [HttpPut]
        public IActionResult UpdateNote(Guid id, [FromBody] Note note)
        {
            NoteService.UpdateNote(id, note);
            return Ok("Updated Successfully");
        }

        [HttpPut("updatecontent")]
        public IActionResult UpdateNote(Guid id, string content)
        {
            NoteService.UpdateNote(id, content);
            return Ok("Updated Successfully");
        }

        [HttpPut("updatetitle")]
        public IActionResult UpdateNoteTitle(Guid id, string title)
        {
            NoteService.UpdateNoteTitle(id, title);
            return Ok("Updated Successfully");
        }
    }
}
