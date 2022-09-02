using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class User : IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }

        public virtual Firm Firm { get; set; }


    }
}
