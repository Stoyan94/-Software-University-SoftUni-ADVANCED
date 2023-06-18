using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> RegularGuestList  = new HashSet<string>();
            HashSet<string> VipGuestList = new HashSet<string>();

            string reservations;

            while ((reservations=Console.ReadLine())!="PARTY")
            {
                char[] guestReserve = reservations.ToCharArray();

                if (char.IsDigit(guestReserve[0]) && reservations.Length==8)
                {
                    VipGuestList.Add(reservations);
                }
                else if(reservations.Length==8)
                {
                    RegularGuestList.Add(reservations);
                }
            }

            string reservationEnd;

            while ((reservationEnd=Console.ReadLine())!="END")
            {
                char[] guestReserve = reservationEnd.ToCharArray();

                if (char.IsDigit(reservationEnd[0]) && reservationEnd.Length == 8)
                {
                    VipGuestList.Remove(reservationEnd);
                }
                else if (reservationEnd.Length == 8)
                {
                    RegularGuestList.Remove(reservationEnd);
                }
            }

            int notUsedReservations = VipGuestList.Count + RegularGuestList.Count;

            Console.WriteLine(notUsedReservations);

            if (VipGuestList.Count>0)
            {             
                foreach (var vipGuest in VipGuestList)
                {
                    Console.WriteLine(vipGuest);
                }                
            }

            if (RegularGuestList.Count > 0)
            {
                foreach (var regularGuest in RegularGuestList)
                {
                    Console.WriteLine(regularGuest);
                }
            }

        }
    }
}
