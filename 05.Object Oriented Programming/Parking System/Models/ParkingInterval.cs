using System;
using System.Collections.Generic;
using System.Text;

public class ParkingInterval
{

    public ParkingInterval(ParkingSpot parkingSpot, string registrationPlate, int hoursParked)
    {
        if (string.IsNullOrEmpty(registrationPlate))
        {
            throw new ArgumentException("Registration plate can’t be null or empty!", nameof(registrationPlate));
        }

        if (hoursParked <= 0)
        {
            throw new ArgumentException("Hours parked can’t be zero or negative!", nameof(hoursParked));
        }

        ParkingSpot = parkingSpot;
        RegistrationPlate = registrationPlate;
        HoursParked = hoursParked;
    }

    public ParkingSpot ParkingSpot { get; }

    public string RegistrationPlate { get; }

    public int HoursParked { get; }

    public double Revenue
    {
        get
        {
            if (ParkingSpot is SubscriptionParkingSpot)
            {
                return 0;
            }
            return this.ParkingSpot.Price * this.HoursParked;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb
            .AppendLine($"> Parking Spot #{this.ParkingSpot.Id}")
            .AppendLine($"> RegistrationPlate: {this.RegistrationPlate}")
            .AppendLine($"> HoursParked: {this.HoursParked}")
            .AppendLine($"> Revenue: {this.Revenue:F2} BGN");

        return sb.ToString().TrimEnd();
    }
}