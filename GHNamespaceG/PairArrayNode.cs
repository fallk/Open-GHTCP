using GHNamespaceC;
using GHNamespaceF;

namespace GHNamespaceG
{
    public class PairArrayNode : ZzUnkNode289<FloatListNode>
    {
        public FloatListNode this[int int0]
        {
            get => (FloatListNode) Nodes[int0];
            set => Nodes[int0] = value;
        }

        public PairArrayNode()
        {
            vmethod_0();
        }

        public override int vmethod_1()
        {
            return 17;
        }

        public override byte vmethod_15()
        {
            return 5;
        }

        public override string GetNodeText()
        {
            return "Pair Array";
        }
    }
}