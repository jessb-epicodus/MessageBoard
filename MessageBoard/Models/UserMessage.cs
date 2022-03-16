namespace MessageBoard.Models 
{
  public class UserMessage 
  {       
    public int UserMessageId {get; set;}
    public int UserId {get; set;}
    public int MessageId {get; set;}
    public virtual User User {get; set;}
    public virtual Message Message {get; set;}
  }
}