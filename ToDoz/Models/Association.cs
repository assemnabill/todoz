using System;
namespace ToDoz.Models
{
    //Association is represented with a dotted line.
    // It is used to associate an Artifact or text to a Flow Object
    public class Association : ConnectingObject
    {

        public string ImageUrl { get; set; }

        public Association()
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
