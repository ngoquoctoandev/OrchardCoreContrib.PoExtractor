namespace OrchardCoreContrib.PoExtractor;

public class IgnoredProject
{
    private const string Docs      = "src\\dos";
    private const string Cms       = "src\\OrchardCore.Cms.Web";
    private const string Mvc       = "src\\OrchardCore.Mvc.Web";
    private const string Templates = "src\\Templates";
    private const string Test      = "test";

    public static IEnumerable<string> ToList()
    {
        yield return Docs;
        yield return Cms;
        yield return Mvc;
        yield return Templates;
        yield return Test;
    }
}