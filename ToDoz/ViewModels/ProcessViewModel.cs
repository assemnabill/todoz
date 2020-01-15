using System;
using ToDoz.Models;

namespace ToDoz.ViewModels
{
    public class ProcessViewModel
    {

        FlowObject FirstObject { get; set; }
        FlowObject SeconedObject { get; set; }
        ConnectingObject Connection { get; set; }


        public ProcessViewModel()
        {
        }
    }
}
