using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.UnitTestFramework;

namespace Machine.Specifications.ReSharperProvider.Explorers.ElementHandlers
{
    internal interface IElementHandler
    {
        bool Accepts(ITreeNode element);

        IEnumerable<UnitTestElementDisposition> AcceptElement(string assemblyPath, IFile file, ITreeNode element);
    }
}