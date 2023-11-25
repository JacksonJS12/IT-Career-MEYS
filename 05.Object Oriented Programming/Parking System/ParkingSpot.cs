public abstract class ParkingSpot
{
    private int id;
    private bool occupied;
    private string type;
    private double price;
    protected List<ParkingInterval> parkingIntervals;

    public int Id
    {
        get
        {
            //TODO: implement me
            throw new NotImplementedException();
        }

        set
        {
            //TODO: implement me
            throw new NotImplementedException();
        }
    }

    public bool Occupied
    {
        get
        {
            //TODO: implement me
            throw new NotImplementedException();
        }

        set
        {
            //TODO: implement me
            throw new NotImplementedException();
        }
    }

    public string Type
    {
        get
        {
            //TODO: implement me
            throw new NotImplementedException();
        }

        set
        {
            //TODO: implement me
            throw new NotImplementedException();
        }

    }

    public double Price
    {
        get
        {
            //TODO: implement me
            throw new NotImplementedException();
        }

        set
        {
            //TODO: implement me
            throw new NotImplementedException();
        }
    }

    public ParkingSpot(int id, bool occupied, string type, double price)
    {
        //TODO: implement me
        throw new NotImplementedException();
    }

    public virtual bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        //TODO: implement me
        throw new NotImplementedException();
    }

    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
        //TODO: implement me
        throw new NotImplementedException();
    }

    public virtual double CalculateTotal()
    {
        //TODO: implement me
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        //TODO: implement me
        throw new NotImplementedException();
    }

}
