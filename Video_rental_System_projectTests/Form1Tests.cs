using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_rental_System_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_System_project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Booking booking = new Booking(0, 1, 1, "05/11/2021", "book");
            if (booking.ClientID > 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
            
        }
    }
}