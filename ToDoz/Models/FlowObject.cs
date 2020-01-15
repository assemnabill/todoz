using System;
namespace ToDoz.Models
{
    /*
     * Artifacts allow developers to bring some more information into the model/diagram.
     * There are three pre-defined Artefacts and they are:
     
     - Data objects: show the reader which data is required or produced in an activity.
     - Group: is represented with a rounded-corner rectangle and dashed lines.
       The group is used to group different activities but does not affect the flow in the diagram.
     - Annotation: is used to give the reader of the model/diagram an understandable impression. 
     */

    public interface Artifects
    {
        
        public void addArtifect();

        public void removeArtifect();

        public void editArtifect();


    }
}
