using System;
namespace ToDoz.Models
{ 
    // Sequence Flow is represented with a solid line and arrowhead,
    // and shows in which order the activities are performed.
    public class SequenceFlow : ConnectingObject
    {
        public string ImageUrl { get; set; }

        public SequenceFlow()
        {
        }

        public void remove()
        {
            throw new NotImplementedException();
        }

        public void ChangeType()
        {
            throw new NotImplementedException();
        }
    }
}
