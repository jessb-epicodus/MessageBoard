using System.Collections.Generic;

namespace MessageBoard.Models 
{
  public class Room 
  {
    public int RoomId {get; set;}
    public string Name {get; set;}
    public virtual ICollection<Message> Messages {get; set;}
  }
}