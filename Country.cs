using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class Country
    {
        
        public String Name
        {
            get;
        }
        public String Code
        {
            get;
        }
        public String Region
        {
            get;
        }
        public int Population
        {
            get;
        }
        public Country(String Name, string Code,String Region,int Population)
        {
            this.Name = Name;
            this.Code = Code;
            this.Region = Region;
            this.Population = Population;
        }
      
    }
}
