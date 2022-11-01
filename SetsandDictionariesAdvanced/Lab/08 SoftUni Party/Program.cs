using System;
using System.Collections.Generic;

namespace _08_SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guestReservation = Console.ReadLine();

            var membersOfParty = new HashSet<string>();
            var vipMembers = new HashSet<string>();
            var normalGuest = new HashSet<string>();

            while (guestReservation != "PARTY")
            {
                membersOfParty.Add(guestReservation);

                if (char.IsDigit(guestReservation[0]))
                {
                    vipMembers.Add(guestReservation);
                }
                else
                {
                    normalGuest.Add(guestReservation);
                }

                guestReservation = Console.ReadLine();
            }

            string guestWhoCome = Console.ReadLine();

            while (guestWhoCome != "END")
            {
                membersOfParty.Remove(guestWhoCome);

                if (char.IsDigit(guestWhoCome[0]))
                {
                    vipMembers.Remove(guestWhoCome);
                }
                else
                {
                    normalGuest.Remove(guestWhoCome);
                }

                guestWhoCome = Console.ReadLine();
            }

            Console.WriteLine(membersOfParty.Count);
            foreach (var vip in vipMembers)
                Console.WriteLine(vip);

            foreach (var guest in normalGuest)
                Console.WriteLine(guest);
        }
    }
}
