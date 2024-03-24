using System.Net;

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
        throw new NotImplementedException();
    }

   

    public EwtcType GenerateRandomWTCType(EwtcType ewtcType)
    {
        Random r = new Random();
        int amount = r.Next(1, 3);
        switch (amount)
        {
            case 1: return EwtcType.H;
            break;
            case 2: return EwtcType.L;
            break;
            case 3: return EwtcType.M;
            break;
        }
        return ewtcType;
    }

    public int GenerateRandomFlightLevel(int level)
    {
        Random r = new Random();
        int[] levels = new[]
        {
            20000, 21000, 22000, 23000, 24000, 
            25000, 26000, 27000, 28000, 29000, 
            30000, 31000, 32000, 33000, 34000,
            35000, 36000, 37000, 38000, 39000
        };
        for (int i = 0; i < levels.Length; i++)
        {
            int randomLevel = levels[r.Next(levels.Length)];
        }
        return level;
    }

    public void GenerateRandomGateNumber()
    {
        throw new NotImplementedException();
    }

    public void GenerateRandomStatus()
    {
        throw new NotImplementedException();
    }


    /*public void GenerateRandomAircraftType()
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

    }*/

    public EAricraftStatus GenerateRandomStatus(EAricraftStatus eAricraftStatus)
    {
        Random r = new Random();
        int number = r.Next(1, 5); // Adjusted to match the number of cases

        switch (number)
        {
            case 1:
                return EAricraftStatus.ONFREQ;
            case 2:
                return EAricraftStatus.TAKEOFF;
            case 3:
                return EAricraftStatus.LINEUP;
            case 4:
                return EAricraftStatus.STARTUP;
            default:
                return EAricraftStatus.NONE;
        }
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
            $"{GenerateRandomCompany(Company)}{GenerateRandomCallsignNumber(CallsginNumber)}{GenerateRandomCallsignLetter(CallsignLetter)}  {Departure = "LOWW"} {GenerateRandomArrival(Arrival)} {DepartureRoute = "SidTest"} {GenerateRandomDepartureRunway(DepartureRunway)} {AltitudeInitial = 5000} {AssignedSqawk = 1000} {AircraftType = "TypeTest"} {GenerateRandomWTCType(EwtcTypeE)} {GenerateRandomFlightLevel(RequestedFlightLevel)} {FlightPlanIsValid = true} {Gate = "GateTest"} {GenerateRandomStatus(EAricraftStatusE)}";
    }
}