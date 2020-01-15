using System;
namespace ToDoz.Models
{

    /*
     Flow objects are connected to each other using Connections, which are of three types:

     - Sequence Flow: represented with a solid line and arrowhead, and shows in which order the activities are performed.
     - Message Flow: represented with a dashed line, an open circle at the start, and an open arrowhead at the end. It tells us what messages flow across organizational boundaries (i.e., between pools).
       A message flow can never be used to connect activities or events within the same pool.
     - Association: represented with a dotted line. It is used to associate an Artifact or text to a Flow Object
     more info: https://en.wikipedia.org/wiki/Business_Process_Model_and_Notation#Flow_objects_and_connecting_objects
     */
    public interface ConnectingObject
    {
       

        // Changes Type of a Connection between 2 Flow Object instances
        public void ChangeType();

        // removes a Connection between 2 Flow Object instances
        public void remove();

    }
}
