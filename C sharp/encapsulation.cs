using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    using System;


  

    //Encapsulation
    public class student
    {
        // data hiding 

        private int id;

        //abstraction

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }

}
