using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //Sorun: İç içe geçmesi ve birlikte çalışması gereken bir bileşeniniz varsa, çözüm Composite Pattern'dir.

    public class Category
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class CompositeComponent<T> where T : new()
    {

        public T Node { get; set; } = new T();

        public List<CompositeComponent<T>> Children { get; set; } = new List<CompositeComponent<T>>();

        public CompositeComponent<T> Add(T child)
        {
            var component = new CompositeComponent<T> { Node = child };
            Children.Add(component);
            return component;


        }

        public static void Show(CompositeComponent<T> component, TreeView treeView)
        {
            TreeNode node = new TreeNode();
            var chilNodes = addItemToNode(component, node);
            treeView.Nodes.Add(chilNodes);
        }

        private static TreeNode addItemToNode(CompositeComponent<T> component, TreeNode node)
        {
            var child = node.Nodes.Add(component.Node.ToString());
            foreach (var item in component.Children)
            {
                addItemToNode(item, child);
            }

            return child;


        }
    }

}
