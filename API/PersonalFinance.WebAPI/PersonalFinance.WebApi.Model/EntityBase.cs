using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalFinance.WebApi.Model
{
    
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
