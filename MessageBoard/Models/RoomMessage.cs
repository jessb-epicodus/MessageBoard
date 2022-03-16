namespace MessageBoard.Models 
{
  public class RoomMessage 
  {       
    public int RoomMessageId {get; set;}
    public int RoomId {get; set;}
    public int MessageId {get; set;}
    public virtual Room Room {get; set;}
    public virtual Message Message {get; set;}
  }
}