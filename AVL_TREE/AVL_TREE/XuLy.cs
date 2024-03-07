using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AVL_TREE
{
    public class XuLy : IXuLy
    {
        public static List<string> InsertComparisons { get; private set; } = new List<string>();

        public List<string> Insert_DSSS(Node root, int key)
        {
            InsertComparisons.Clear(); // Xóa danh sách so sánh cũ
            Insert(root, key);
        
            return InsertComparisons;
        }
        public Node MakeRoot(int key)
        {
            return new Node(key);
        }
        public int TimMax(int a, int b)
        {
            return a > b ? a : b;
        }
        public int GetHeight(Node current)
        {
            return current == null ? 0 : current.Height;
        }
        public int GetBalance(Node current)
        {
            return current == null ? 0 : (GetHeight(current.LeftChild) - GetHeight(current.RightChild));
        }

        public Node XoayTrai(Node current)
        {
            var y = current.RightChild;
            var T2 = y.LeftChild;
            y.LeftChild = current;
            current.RightChild = T2;
            current.Height = TimMax(GetHeight(current.LeftChild), GetHeight(current.RightChild)) + 1;
            y.Height = TimMax(GetHeight(y.LeftChild), GetHeight(y.RightChild)) + 1;
            return y;
        }
        
        public Node XoayPhai(Node current)
        {
            var x = current.LeftChild;
            var T2 = x.RightChild;
            x.RightChild = current;
            current.LeftChild = T2;
            current.Height = TimMax(GetHeight(current.LeftChild), GetHeight(current.RightChild)) + 1;
            x.Height = TimMax(GetHeight(x.LeftChild), GetHeight(x.RightChild)) + 1;
            return x;
        }
        public Node Insert(Node current, int key)
        {
            if (current == null)
            { 
                return MakeRoot(key);
            }

            if (key == current.Kay)
            {

                InsertComparisons.Add($" {key} = {current.Kay}");
                return current;

            }
            if (key < current.Kay)
            {
                InsertComparisons.Add($" {key} < {current.Kay}");
                current.LeftChild = Insert(current.LeftChild, key);
            }
            else
            {
                InsertComparisons.Add($" {key} > {current.Kay}");
                current.RightChild = Insert(current.RightChild, key);
            }
            current.Height = TimMax(GetHeight(current.LeftChild), GetHeight(current.RightChild)) + 1;
            int balacne = GetBalance(current);
            //left left
            if (balacne > 1 && key < current.LeftChild.Kay)
            {
                return XoayPhai(current);
            }
            //right right
            if (balacne < -1 && key > current.RightChild.Kay)
            {
                return XoayTrai(current);
            }
            //left right
            if (balacne > 1 && key > current.LeftChild.Kay)
            {
                current.LeftChild = XoayTrai(current.LeftChild);
               
                return XoayPhai(current);

            }
            //right left
            if (balacne < -1 && key < current.RightChild.Kay)
            {
                current.RightChild = XoayPhai(current.RightChild);
                return XoayTrai(current);
            }
            return current;
        }
        public Node Tim(Node current, int key)
        {
            if (current == null || current.Kay == key)
            {
                return current;
            }

            if (key < current.Kay)
            {
                return Tim(current.LeftChild, key);
            }

            return Tim(current.RightChild, key);
        }
        

        public Node Delete(Node current, int key)
        {
            if (current == null)
                return current;

            if (key < current.Kay)
                current.LeftChild = Delete(current.LeftChild, key);
            else if (key > current.Kay)
                current.RightChild = Delete(current.RightChild, key);
            else
            {
                if (current.LeftChild == null && current.RightChild == null)
                {
                    // Node là lá, xóa nó
                    current = null;
                }
                else if (current.LeftChild == null)
                {
                    // Node có một con phải, thay thế bằng con phải
                    current = current.RightChild;
                }
                else if (current.RightChild == null)
                {
                    // Node có một con trái, thay thế bằng con trái
                    current = current.LeftChild;
                }
                else
                {
                    // Node có cả hai con
                    Node temp = TimMin(current.RightChild);
                    current.Kay = temp.Kay;
                    current.RightChild = Delete(current.RightChild, temp.Kay);
                }
            }

            if (current == null)
                return current;

            current.Height = TimMax(GetHeight(current.LeftChild), GetHeight(current.RightChild)) + 1;
            int balance = GetBalance(current);

            // Thực hiện cân bằng cây
            // Left Left
            if (balance > 1 && GetBalance(current.LeftChild) >= 0)
                return XoayPhai(current);

            // Left Right
            if (balance > 1 && GetBalance(current.LeftChild) < 0)
            {
                current.LeftChild = XoayTrai(current.LeftChild);
                return XoayPhai(current);
            }

            // Right Right
            if (balance < -1 && GetBalance(current.RightChild) <= 0)
                return XoayTrai(current);

            // Right Left
            if (balance < -1 && GetBalance(current.RightChild) > 0)
            {
                current.RightChild = XoayPhai(current.RightChild);
                return XoayTrai(current);
            }

            return current;
        }

        private Node TimMin(Node node)
        {
            Node current = node;

            while (current.LeftChild != null)
                current = current.LeftChild;

            return current;
        }

    }
}
