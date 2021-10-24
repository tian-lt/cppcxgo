using System.Collections.Generic;

namespace Libcppcxgo2.Models.AST
{
    public struct TextPosition
    {
        public int Line;
        public int Column;
    }

    public interface INode
    {
        public enum NodeTypes
        {
            Null,
            TranslationUnit,
            Namespace,
            Class,
            Struct,
            RefClass,
            RefStruct,
            FuncDecl,
            FuncDef,
            Compound,
            Expression,
            Unknown,
        }

        public TextPosition Position { get; }
        public string Name { get; }
        public NodeTypes NodeType { get; }
        public IList<INode> Childrens { get; }
    }
}
