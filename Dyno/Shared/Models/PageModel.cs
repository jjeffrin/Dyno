using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyno.Shared.Models
{
    public class PageModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<InputControlModel> InputControls { get; set; }
    }
}
