using System;
using System.Collections.Generic;
using System.Text;
using Exercico3.Entities.Exceptions;

namespace Exercico3.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }
        public Reservation(int roomnumber, DateTime checkin, DateTime checkout)
        {
            if(checkout <= checkin)
            {
                throw new DomainException("Check out must be after check in ");
            }
            RoomNumber = roomnumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if(checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for uopdates must be future dates");
            }
            if(checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after checkin date");
            }
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return $"Room Number:{RoomNumber} - CheckOut:{CheckOut} - CheckIn:{CheckIn} - Duration in days:{Duration()} ";
        }
    }
}
