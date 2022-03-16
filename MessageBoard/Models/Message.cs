using System.Collections.Generic;

namespace MessageBoard.Models {
  public class Message {
    public Message () {
      this.JoinEntities = new HashSet<UserMessage>();
    }
    public int MessageId { get; set; }
    public int RoomId { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public virtual Room Room { get; set; }
    public virtual ICollection<UserMessage> JoinEntities { get;}
  }
}