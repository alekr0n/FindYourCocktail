using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Domain
{
    public class Ingredients
    {
        public int id { get; set; }
        public List<string> alcohols { get; set; }
        public List<string>? softs { get; set; }
        public List<string>? fruits { get; set; }
    }
}
