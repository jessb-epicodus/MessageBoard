using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models {
  public class MessageBoardContext : DbContext {
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<RoomMessage> RoomMessages { get;set;}
    public MessageBoardContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}