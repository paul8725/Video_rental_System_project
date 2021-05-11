using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_System_project
{
   public class Booking
    {
        public int BookID;
        public int ClientID;
        public int MovieID;
        public String BookingDt;
        public String ReturnDt;

        public Booking(int ID,int Cid,int Mid,String bookingDt, String retrnDt) {
            this.BookID = ID;
            this.ClientID = Cid;
            this.MovieID = Mid;
            this.BookingDt = bookingDt;
            this.ReturnDt = retrnDt;

        }

    }
}
