namespace OrchardCoreContrib.PoExtractor.DotNet;

/// <summary>
///     Represents a class that contains a set of localizer identifier accessors.
/// </summary>
public static class LocalizerAccessors
{
    /// <summary>
    ///     Gets the localizer identifier for IStringLocalizer or IHtmlStringLocalizer in views.
    /// </summary>
    private const string DefaultLocalizerIdentifier = "T";

    private const string FieldDefaultLocalizerIdentifier = "_t";

    /// <summary>
    ///     Gets the localizer identifier for IStringLocalizer.
    /// </summary>
    private const string StringLocalizerIdentifier = "S";

    private const string FieldStringLocalizerIdentifier     = "_s";
    private const string ParameterStringLocalizerIdentifier = "s";

    /// <summary>
    ///     Gets the localizer identifier for IHtmlStringLocalizer.
    /// </summary>
    private const string HtmlLocalizerIdentifier = "H";

    /// <summary>
    ///     Gets the localizer identifiers.
    /// </summary>
    public static readonly string[] LocalizerIdentifiers =
    {
        DefaultLocalizerIdentifier,
        StringLocalizerIdentifier,
        HtmlLocalizerIdentifier,
        FieldDefaultLocalizerIdentifier,
        FieldStringLocalizerIdentifier,
        ParameterStringLocalizerIdentifier
    };
}