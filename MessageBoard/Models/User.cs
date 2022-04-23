using System.Collections.Generic;

namespace MessageBoard.Models {
  public class User {
    public User () {
      this.Messages = new HashSet<Message>();
    }
    public int UserId {get; set;}
    public string UserName {get;set;}
    public virtual ICollection<Message> Messages { get; set; }
  }
}