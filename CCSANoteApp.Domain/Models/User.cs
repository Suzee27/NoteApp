namespace CCSANoteApp.Domain.Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }
        public virtual Guid Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual List<Note> Notes { get; set; } = new();
    }
}