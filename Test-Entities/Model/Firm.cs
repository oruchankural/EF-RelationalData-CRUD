using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class Firm : IEntity
    {
        [Key]
        public int FirmId { get; set; }
        public string FirmCode { get; set; }
    }
}
