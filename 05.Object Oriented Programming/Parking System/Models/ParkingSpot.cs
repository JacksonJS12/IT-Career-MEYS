using System.Text;

public abstract class ParkingSpot
{
    protected List<ParkingInterval> parkingIntervals;

    protected ParkingSpot(int id, bool occupied, string type, double price)
    {
        if (price <= 0)
        {
            throw new ArgumentException("Parking price cannot be less or equal to 0!", nameof(price));
        }

        parkingIntervals = new List<ParkingInterval>();

        this.Id = id;
        this.Occupied = occupied;
        this.Type = type;
        this.Price = price;
    }

    public int Id { get; }
    public bool Occupied { get; set; }
    public string Type { get; }
    public double Price { get; }



    public virtual bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if (!this.Occupied || this.Type != type)
        {
            return false;
        }

        ParkingInterval parkingInterval = new ParkingInterval(this, registrationPlate, hoursParked);

        this.parkingIntervals.Add(parkingInterval);

        this.Occupied = true;

        return true;
    }

    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
       return this.parkingIntervals.Where(pi => pi.RegistrationPlate == registrationPlate).ToList();
    }

    public virtual double CalculateTotal()
        => this.parkingIntervals.Sum(pi => pi.Revenue);

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb
            .AppendLine($"> Parking Spot #{this.Id}")
            .AppendLine($"> Occupied: {this.Occupied}")
            .AppendLine($"> Type: {this.Type}")
            .AppendLine($"> Price per hour: {this.Price:f2} BGN");

        return sb.ToString().TrimEnd();
    }

}
