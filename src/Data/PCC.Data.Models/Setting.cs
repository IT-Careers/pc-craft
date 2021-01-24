using System;
using System.Collections.Generic;
using System.Text;

namespace PCC.Data.Models
{
        
    public class Setting : BaseEntity
    {
        public string Name { get; set; }

        public bool IsGame { get; set; }
    }
}
