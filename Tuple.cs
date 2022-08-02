using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    //אוסף של משתנים שאפשר להעביר אותם בתור פרמטר אחד
    internal class Tuple
    {
        public void run()
        {
            int id;
            string name;
            (int id,string fname,string lname ) var1;
            var1 = (123,"Moshe","Cohen");
        }
    }
}
