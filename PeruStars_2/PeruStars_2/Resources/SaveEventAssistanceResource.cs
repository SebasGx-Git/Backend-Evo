using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Resources
{
    public class SaveEventAssistanceResource
    {
        [Required]
        public DateTime AttendanceDay { get; set; }
    }
}
