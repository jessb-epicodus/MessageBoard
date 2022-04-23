using System.Collections.Generic;

namespace MessageBoard.Models {
  public class Message {
    public Message () {
      this.JoinEntities = new HashSet<RoomMessage>();
    }
    public int MessageId { get; set; }
    public int RoomId { get; set; }   //????? Do we need?
    public int UserId { get; set; }  // used for one to many
    public string Title { get; set; }
    public string Content { get; set; }
    public virtual Room Room { get; set; }    ///????? Do we need?
    public virtual User User { get; set; }  // used for one to many
    public virtual ICollection<RoomMessage> JoinEntities { get;} //  used for many to many
  }
}