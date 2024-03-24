namespace Euroscope;

public interface IAircraftData
{
    string GenerateRandomCompany(string company);
    int GenerateRandomCallsignNumber(int number);
    string GenerateRandomCallsignLetter(string letter);
    string GenerateRandomArrival(string arrival); 
    string GenerateRandomDepartureRunway(string deparutre);
    
    void GenerateRandomAircraftType();
    void GenerateRandomWTCType();

    void GenerateRandomFlightLevel();
    void GenerateRandomGateNumber();
    void GenerateRandomStatus();
    
    void ShowAllTaxiTags();
    void ShowAllStartUpTags();
    void ShowAllTakeOffTags();
    
    
    
}