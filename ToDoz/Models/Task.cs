using System;
using ToDoz.Controllers;
using ToDoz.Models;
using ToDoz.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;



namespace ToDoz.Models
{
    public class Task : FlowObject
    {
       
        public string Name { get; set; }
        public string Status { get; set; }
        public string Prio { get; set; }
        public string description { get; set; }
        public DateTime dateTime { get; set; }



        public void Add(FlowObject flowObject)
        {
            throw new NotImplementedException();
        }

        public void Connect(FlowObject flowObject1, FlowObject flowObject2, ConnectingObject connectionType)
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }

  
}
