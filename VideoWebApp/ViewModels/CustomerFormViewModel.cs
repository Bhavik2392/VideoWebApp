using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoWebApp.Models;

namespace VideoWebApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}