using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Domain
{
    public class Cocktail
    {
        public int id { get; set; }
        public string name { get; set; }
        public Ingredients ingredients { get; set; }
        public List<string> recipe { get; set; }
        public bool isCustom { get; set; }
        public DateTime? time { get; set; }
        public Estimate? estimate { get; set; }
    }
}
