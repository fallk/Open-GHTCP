using GHNamespaceC;
using GHNamespaceF;

namespace GHNamespaceG
{
    public class StructureArrayNode : ZzUnkNode289<StructureHeaderNode>
    {
        public StructureHeaderNode this[int int0]
        {
            get => (StructureHeaderNode) Nodes[int0];
            set => Nodes[int0] = value;
        }

        public StructureArrayNode()
        {
            vmethod_0();
        }

        public override int vmethod_1()
        {
            return 15;
        }

        public override byte vmethod_15()
        {
            return 10;
        }

        public override string GetNodeText()
        {
            return "Structure Array";
        }
    }
}