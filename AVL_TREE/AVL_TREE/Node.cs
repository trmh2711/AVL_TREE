

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_TREE
{
    public class Node
    {
        // nút trong tree
        public int Kay;
        //truy cập nút con bên phải của nút hiện tại trong cây AVL.
        public Node RightChild;
        //truy cập nút con bên trái của nút hiện tại trong cây AVL.
        public Node LeftChild;
        //chiều cao của nút trong cây AVL.
        public int Height;
        //Phương thức khởi tạo của lớp Node nhận một tham số là key, biểu diễn giá trị khóa của nút.
        //Trong phương thức này, giá trị key được gán cho trường Kay, và Height được khởi tạo là 1.
        //Chiều cao của nút mới khởi tạo là 1 bởi vì nút mới được thêm vào cây và đây là nút lá, nút lá có chiều cao là 1.
        public Node(int key)
        {
            this.Kay = key;
            Height = 1;
        }
    }
}
