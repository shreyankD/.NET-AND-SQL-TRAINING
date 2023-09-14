using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR NAME:");
            Console.ReadLine();
            Console.WriteLine("ENTER YOUR AGE: ");
            Console.ReadLine();
            TicketBooking ticketBooking = new TicketBooking();
            try
            {
                ticketBooking.Ticket_Booking();
            }
            catch (ticketException tE)
            {
                Console.WriteLine(tE.Message);
            }
            Console.ReadLine();
        }
    }


    class ticketException : Exception
    {
        public ticketException(string message) : base(message)
        {
        }
    }
    class TicketBooking
    {
        public void Ticket_Booking()
        {
            Console.WriteLine("ENTER THE TOTAL NUMBER OF TICKETS : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 2)
            {
                throw (new ticketException("CANNOT BOOK MORE THAN 2 TICKETS "));
            }
            else
            {
                Console.WriteLine("BOOKED SUCCESSFULLY");
            }
        }
    }
}