using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_Domain_Model.BL
{
    class Taxi
    {
        string taxi_model;
        string number_Plate;
        public static List<Passenger> passenger;


        public static bool pickup_passenger()
        {
            return false;
        }

        public static bool notify_Arrival()
        {
            return false;
        }

        public static bool dropped_destination()
        {
            return false;
        }
        public static bool notify_Destination()
        {
            return false;
        }
    }
    class Taxi_Company
    {
        List<Taxi> taxis;


        public static bool recieve_Call()
        {
            return false;
        }

        public static bool schecdule_Vehical()
        {
            return false;
        }

    }

    public class Passenger
    {
        public string Psgr_Name;
        public string Psgr_Contact_No;
        public string Psgr_Pickup_Location;

        public static bool  call_Taxi_Company()
        {
            return false;
        }
    }
}
