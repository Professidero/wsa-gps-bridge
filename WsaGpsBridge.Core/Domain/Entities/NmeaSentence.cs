namespace WsaGpsBridge.Core.Domain.Entities;

public readonly record struct NmeaSentence
{
    private string RawContent { get; init; }

    public bool IsValid { get; init; }

    public NmeaSentence(string? raw)
    {
        bool isViable = !string.IsNullOrWhiteSpace(raw) && raw.StartsWith("$");

        RawContent = isViable ? raw! : string.Empty;
        IsValid = isViable;
    }

    public override string ToString() => RawContent;
}