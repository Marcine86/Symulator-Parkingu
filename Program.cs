namespace Parking 
{
    class Program 
    {
        static void Main() {
            
        }
    }

    class ParkingLot {
        private double ParkingSpots { get; set; }
    }

    class ParkingSpot {
        private bool IsOccupied { get; set; }   
    }

    class Vehicle {
        private string Marka {get; set;}
        private double numer_rejestrcyjny {get; set;}
    }
}