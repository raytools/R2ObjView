using System.Windows.Forms;
using Ray2Mod.Components.Types;
using Ray2Mod.Game.Structs.SPO;

namespace R2ObjView
{
    public class ObjectNode
    {
        public Pointer<SuperObject> SuperObject { get; set; }
        public TreeNode Node { get; set; }
        public TreeNode ParentNode { get; set; }
        public bool Invalidated { get; set; }

        public ObjectNode(Pointer<SuperObject> spo, TreeNode node, TreeNode parent)
        {
            SuperObject = spo;
            Node = node;
            ParentNode = parent;
            Invalidated = false;
        }
    }
}