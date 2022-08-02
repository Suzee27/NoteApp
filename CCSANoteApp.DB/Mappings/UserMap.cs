using CCSANoteApp.Domain.Models;
using FluentNHibernate.Mapping;

namespace CCSANoteApp.DB.Mappings
{
    public class UserMap: ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");
            Id(user=>user.Id);
            Map(User => User.Username);
            Map(User => User.Password);
            Map(User => User.Email);
            HasMany(User => User.Notes);
        }
        
    }
}
