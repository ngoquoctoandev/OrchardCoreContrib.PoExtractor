namespace OrchardCoreContrib.PoExtractor.Abstractions;

/// <summary>
///     Represents a localizable text with all it's occurrences in the project.
/// </summary>
public class LocalizableString
{
    /// <summary>
    ///     Creates a new instance of the <see cref="LocalizableString" />.
    /// </summary>
    public LocalizableString() => Locations = new List<LocalizableStringLocation?>();

    /// <summary>
    ///     Creates a new instance of the <see cref="LocalizableString" /> and properties with data from the source.
    /// </summary>
    /// <param name="source">the <see cref="LocalizableStringOccurence" /> with the data.</param>
    public LocalizableString(LocalizableStringOccurence? source)
    {
        if (source is null) throw new ArgumentNullException(nameof(source));

        Text       = source.Text;
        TextPlural = source.TextPlural;
        Context    = source.Context;

        Locations = new List<LocalizableStringLocation?>
        {
            source.Location
        };
    }

    /// <summary>
    ///     Gets or sets context of the.
    /// </summary>
    public string? Context { get; init; }

    /// <summary>
    ///     Gets or sets the localizable text.
    /// </summary>
    public string? Text { get; init; }

    /// <summary>
    ///     Gets or sets the localizable text for the plural.
    /// </summary>
    public string? TextPlural { get; init; }

    /// <summary>
    ///     Gets collection of all locations of the text in the project.
    /// </summary>
    public List<LocalizableStringLocation?> Locations { get; }
}