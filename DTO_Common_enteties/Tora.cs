using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Common_enteties
{
    public class Tora : Navi
    {
        public string Parasha { get; set; }
        //public string Chumash { get; set; }
        public Tora() { }


        public override string ToString()
        {

           //return":"+ Book + "" +""+ Parasha  + Perek +"פסוק:"+Pasuk+":"+Text;
          return  Text  + Pasuk + ":" + Perek + Parasha  + "" + ":" + Book;
        }
    }
}
     