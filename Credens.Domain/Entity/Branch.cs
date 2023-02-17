using Credens.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.Domain.Entity
{
    public class Branch
    {
        public BranchLocation Location { get; set; } 
        public List<User> Emploees { get; set; } 

        
        public Branch() 
        {
            Emploees = new List<User>();
        }
    }
}
