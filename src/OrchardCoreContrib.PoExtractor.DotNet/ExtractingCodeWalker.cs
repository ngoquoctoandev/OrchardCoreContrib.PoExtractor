﻿using Microsoft.CodeAnalysis;
using OrchardCoreContrib.PoExtractor.Core;
using OrchardCoreContrib.PoExtractor.Core.Contracts;
using System.Collections.Generic;

namespace OrchardCoreContrib.PoExtractor.DotNet
{
    /// <summary>
    /// Traverses C# & VB AST and extracts localizable strings using provided collection of <see cref="IStringExtractor{T}"/>
    /// </summary>
    public class ExtractingCodeWalker : SyntaxWalker
    {
        private readonly LocalizableStringCollection _strings;
        private readonly IEnumerable<IStringExtractor<SyntaxNode>> _extractors;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractingCodeWalker"/> class
        /// </summary>
        /// <param name="extractors">the collection of extractors to use</param>
        /// <param name="strings">the <see cref="LocalizableStringCollection"/> where the results are saved</param>
        public ExtractingCodeWalker(IEnumerable<IStringExtractor<SyntaxNode>> extractors, LocalizableStringCollection strings)
        {
            _extractors = extractors;
            _strings = strings;
        }

        public override void Visit(SyntaxNode node)
        {
            base.Visit(node);

            foreach (var extractor in _extractors)
            {
                if (extractor.TryExtract(node, out var result))
                {
                    this._strings.Add(result);
                }
            }
        }
    }
}
