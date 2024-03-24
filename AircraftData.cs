namespace Euroscope;

public class AircraftData 
{
    public string Company { get; set; }
    public int CallsginNumber { get; set; }
    public string CallsignLetter { get; set; }
    public string Departure { get; set; }
    public string Arrival { get; set; }
    public string DepartureRoute { get; set; }
    public string DepartureRunway { get; set; }
    public int AltitudeInitial { get; set; }
    public int AssignedSqawk { get; set; }
    public string AircraftType { get; set; }
    public EwtcType EwtcTypeE { get; set; }
    public int RequestedFlightLevel { get; set; }
    public bool FlightPlanIsValid { get; set; }
    public string Gate { get; set; }
    public EAricraftStatus EAricraftStatusE { get; set; }

}