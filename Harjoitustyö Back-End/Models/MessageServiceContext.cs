using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;


namespace HarjoitusTyoBackEnd.Models
{
    public class MessageServiceContext : DbContext

    {
        public MessageServiceContext(DbContextOptions<MessageServiceContext> options)
            : base(options)
        {
        }
        public DbSet<Message> Messages { get; set; } = null!;
        public DbSet<HarjoitusTyoBackEnd.Models.User> Users { get; set; } = default!;

        
    }
    
    
}
