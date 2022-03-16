using System.Collections.Generic;

namespace MessageBoard.Models 
{
  public class Room 
  {
    public Room () 
    {
      this.JoinEntities = new HashSet<RoomMessage>();
    }
    public int RoomId {get; set;}
    public string Name {get; set;}
    public virtual ICollection<RoomMessage> JoinEntities {get; set;}
  }
}