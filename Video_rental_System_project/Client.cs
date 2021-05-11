using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_System_project
{
   public class Client
    {
        public int ID;
        public String Name;
        public String Mobile;
        public String address;

        public Client(int id,String nm,String Mob,String adr) {
            this.ID = id;
            this.Name = nm;
            this.Mobile = Mob;
            this.address = adr;
        }




    }
}
