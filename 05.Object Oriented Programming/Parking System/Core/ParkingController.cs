using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class ParkingController
{
    private List<ParkingSpot> parkingSpots;

    public ParkingController()
    {
        parkingSpots = new List<ParkingSpot>();
    }

    public string CreateParkingSpot(List<string> args)
    {
        int id = int.Parse(args[0]);
        ParkingSpot existingParkingSpot = this.GetParkingSpotBy(id);

        bool ocupied = bool.Parse(args[1]);
        string type = args[2];
        double price = double.Parse(args[3]);

        if (type == "car")
        {
            CarParkingSpot carParkingSpot = new CarParkingSpot(id, ocupied, price);
        }
        else if (type == "bus")
        {
            BusParkingSpot busParkingSpot = new BusParkingSpot(id, ocupied, price);
        }
        else if (type == "subscription")
        {
            string registrationPlate = args[4];
            SubscriptionParkingSpot subscriptionParkingSpot =
                new SubscriptionParkingSpot(id, ocupied, price, registrationPlate);
        }


    }

    public string ParkVehicle(List<string> args)
    {
        //TODO: Implement me
        throw new NotImplementedException();
    }

    public string FreeParkingSpot(List<string> args)
    {
        //TODO: Implement me
        throw new NotImplementedException();
    }

    public string GetParkingSpotById(List<string> args)
    {
        //TODO: Implement me
        throw new NotImplementedException();
    }

    public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(List<string> args)
    {
        //TODO: Implement me
        throw new NotImplementedException();
    }

    public string CalculateTotal(List<string> args)
    {
        //TODO: Implement me
        throw new NotImplementedException();
    }

}

