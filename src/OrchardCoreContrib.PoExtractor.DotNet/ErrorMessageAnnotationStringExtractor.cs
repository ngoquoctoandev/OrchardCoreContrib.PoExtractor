using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OrchardCoreContrib.PoExtractor.Abstractions;

namespace OrchardCoreContrib.PoExtractor.DotNet;

/// <summary>
///     Extracts localizable string from data annotations error messages.
/// </summary>
public class ErrorMessageAnnotationStringExtractor : LocalizableStringExtractor<SyntaxNode>
{
    private const string ErrorMessageAttributeName = "ErrorMessage";

    /// <summary>
    ///     Creates a new instance of a <see cref="ErrorMessageAnnotationStringExtractor" />.
    /// </summary>
    /// <param name="metadataProvider">The <see cref="IMetadataProvider{TNode}" />.</param>
    public ErrorMessageAnnotationStringExtractor(IMetadataProvider<SyntaxNode> metadataProvider)
        : base(metadataProvider)
    {
    }

    /// <inheritdoc />
    public override bool TryExtract(SyntaxNode node, out LocalizableStringOccurence? result)
    {
        if (node is null) throw new ArgumentNullException(nameof(node));

        result = null;

        if (node is AttributeSyntax { ArgumentList: not null } accessor)
        {
            var argument = accessor.ArgumentList.Arguments.FirstOrDefault(a => a.Expression.Parent!.ToFullString().StartsWith(ErrorMessageAttributeName));

            if (argument is { Expression: LiteralExpressionSyntax literal } && literal.IsKind(SyntaxKind.StringLiteralExpression))
            {
                result = CreateLocalizedString(literal.Token.ValueText, null, node);

                return true;
            }
        }

        return false;
    }
}