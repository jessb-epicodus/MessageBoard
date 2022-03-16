using System.Collections.Generic;

namespace MessageBoard.Models {
  public class User {
    public User () {
      this.JoinEntities = new HashSet<UserMessage>();
    }
    public int UserId {get; set;}
    public string UserName {get;set;}

    public virtual ICollection<UserMessage> JoinEntities {get;set;}
  }
}