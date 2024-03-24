namespace Euroscope;

public class Aircraft : AircraftData , IAircraftData
{
    public string GenerateRandomCompany(string company)
    {
        string[] Companys = { "DLH", "AUA", "EWG", "SWR", "RYR", "AMC", "THY", "EZY", "BAW" };
        Random r = new Random();
        for (int i = 0; i < Companys.Length; i++)
        {
            company = Companys[r.Next(Companys.Length)];
        }
        return company;
    }

    public int GenerateRandomCallsignNumber(int number)
    {
        Random r = new Random();
        number = r.Next(1, 999);
        return number;
    }

    public string GenerateRandomCallsignLetter(string letter)
    {
        string[] Letters =
        {
            "A", "B", "C", "D", "E", "F", "G",
            "H", "I", "J", "K", "L", "M", "N", 
            "O", "P", "Q", "R", "S", "T", "U",
            "V", "W", "X", "Y", "Z"
        };
        
        Random r = new Random();
        for (int i = 0; i < Letters.Length; i++)
        {
            letter = Letters[r.Next(Letters.Length)];
        }
        return letter;
    }

    public string GenerateRandomArrival(string arrival)
    {
        string[] Arrival = { "LOWI", "LOWS", "EDDM", "EDDF", "EGLL", "LEPA", "EGCC", "LDSP", "EGLC" };
        Random r = new Random();
        for (int i = 0; i < Arrival.Length; i++)
        {
            arrival = Arrival[r.Next(Arrival.Length)];
        }
        return arrival;
    }

    public string GenerateRandomDepartureRunway(string departure)
    {
        Random r = new Random();
        int windDirection = r.Next(1, 360);
        int wind = r.Next(1, 40);
        
        if(windDirection >= 0 &&  windDirection <= 230)
        {
            departure = "11";
        }

        if (windDirection > 230 && windDirection <= 360)
        {
            departure = "29";
        }

        if (wind == 0 || wind == 1)
        {
            departure = "All possible";
        }
        return departure;
    }
    
    public void GenerateRandomAircraftType()
    {
        
    }

    public void GenerateRandomWTCType()
    {
        
    }
    
    public void GenerateRandomFlightLevel()
    {
        
    }

    public void GenerateRandomGateNumber()
    {

    }

    public void GenerateRandomStatus()
    {
    
    }

    public void ShowAllTaxiTags()
    {
       
    }

    public void ShowAllStartUpTags()
    {
    
    }

    public void ShowAllTakeOffTags()
    {
       
    }

    public override string ToString()
    {
        return
            $"{GenerateRandomCompany(Company)}{GenerateRandomCallsignNumber(CallsginNumber)}{GenerateRandomCallsignLetter(CallsignLetter)}  {Departure = "LOWW"} {GenerateRandomArrival(Arrival)} {DepartureRoute = "SidTest"} {GenerateRandomDepartureRunway(DepartureRunway)} {AltitudeInitial = 5000} {AssignedSqawk = 1000} {AircraftType = "TypeTest"} {EwtcTypeE = EwtcType.M} {RequestedFlightLevel = 34000} {FlightPlanIsValid = true} {Gate = "GateTest"} {EAricraftStatusE = EAricraftStatus.NONE}";
    }
}