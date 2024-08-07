namespace DI_Service_Lifetime.Services;

public class TranscientGuidService: ITranscientGuidService
{
    private readonly Guid Id;

    public TranscientGuidService()
    {
        Id = Guid.NewGuid();
    }

    public string GetGuid()
    {
        return Id.ToString();
    }

}
