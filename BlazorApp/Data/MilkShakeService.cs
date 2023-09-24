namespace BlazorApp.Data;

public class MilkShakeService : IMilkShakeService
{

    public List<string> GetMilkshakeTypes()
    {
        return new List<string>()
        {
            "Chocolate",
            "Vanilla",
            "Peanut Butter",
            "Strawberry"
        };
    }
    public List<string> GetMilkshakeSizess()
    {
        return new List<string>()
        {
            "Small",
            "Medium",
            "Large",
            "Extra Large"
        };
    }
}
