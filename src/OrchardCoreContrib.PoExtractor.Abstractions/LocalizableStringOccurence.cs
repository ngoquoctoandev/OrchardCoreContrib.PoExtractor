namespace OrchardCoreContrib.PoExtractor.Abstractions;

/// <summary>
///     Represents the specific occurrence of the localizable string in the project.
/// </summary>
public class LocalizableStringOccurence
{
    /// <summary>
    ///     Gets or sets the context for the localizable string.
    /// </summary>
    public string? Context { get; init; }

    /// <summary>
    ///     Gets or sets the localizable text.
    /// </summary>
    public string? Text { get; init; }

    /// <summary>
    ///     Gets or sets the localizable pluralization text.
    /// </summary>
    public string? TextPlural { get; init; }

    /// <summary>
    ///     Gets or sets the location for the localizable string.
    /// </summary>
    public LocalizableStringLocation? Location { get; init; }
}