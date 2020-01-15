using System;
namespace ToDoz.Models
{
    //Message Flow is represented with a dashed line, an open circle at the start, and an open arrowhead at the end. It tells us what messages flow across organizational boundaries (i.e., between pools).
    //A message flow can never be used to connect activities or events within the same pool.
    
    public class MessageFlow : ConnectingObject
    {

        public string ImageUrl { get; set; }

        public MessageFlow()
        {
        }

        public void ChangeType()
        {
            throw new NotImplementedException();
        }

        public void remove()
        {
            throw new NotImplementedException();
        }
    }
}
