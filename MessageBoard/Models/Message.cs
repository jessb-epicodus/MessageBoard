using System.Collections.Generic;

namespace MessageBoard.Models {
  public class Message {
    public Message () {
      this.JoinEntities = new HashSet<RoomMessage>();
    }
    public int MessageId { get; set; }
    public int RoomId { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public virtual Room Room { get; set; }
    public virtual User User { get; set; }
    public virtual ICollection<RoomMessage> JoinEntities { get;}
  }
}