using System;
namespace ToDoz.Models
{
    /*
     Flow objects are the main describing elements within BPMN, and consist of three core elements:
     
     - Event {throwing, catching}: An Event is represented with a circle and denotes something that happens.
     - Activity {Task, Sub-Process}: An activity is represented with a rounded-corner rectangle and describes the kind of work which must be done.
     - Gateway: is used to give the reader of the model/diagram an understandable impression.
     more info: https://en.wikipedia.org/wiki/Business_Process_Model_and_Notation#Flow_objects_and_connecting_objects
     */

    public interface FlowObject
    {
        // adds a new Flow Object instance
        public void Add(FlowObject flowObject);

        // removes Flow Object instance
        public void Remove();

        // returnes edit view to update FlowObjects properities
        public void Edit();

        // set object properities to current new values
        public void Save();

        // set object properities to current new values
        public void Connect(FlowObject flowObject1, FlowObject flowObject2, ConnectingObject connectionType);

        // renderes a Flow Object according to BPMN Model
        public void Render();



    }
}
