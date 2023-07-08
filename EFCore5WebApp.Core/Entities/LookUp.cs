using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore5WebApp.Core.Entities
{

    public enum LookUpType
    {
        State = 0,
        Country = 1
    }

    [Table("LookUp", Schema = "dbo")]
    public class LookUp
    {
        [Key]
        public string Code { get; set; }
        public string Description { get; set; }
        public LookUpType LookUpType { get; set; }
    }

}
