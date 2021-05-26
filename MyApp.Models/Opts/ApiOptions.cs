using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Opts
{
    public class ApiOptions
    {
       

        public string Url
        {
            get { return url; }
            set
            {
                url = value;
            }
        }
        private string url;
 
    }
}
