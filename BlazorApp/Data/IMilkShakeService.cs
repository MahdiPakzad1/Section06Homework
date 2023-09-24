namespace BlazorApp.Data
{
    public interface IMilkShakeService
    {
        List<string> GetMilkshakeSizess();
        List<string> GetMilkshakeTypes();
    }
}