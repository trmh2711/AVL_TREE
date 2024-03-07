using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_TREE
{
    public interface IXuLy
    {
        //tạo một node gốc mới
        Node MakeRoot(int key);
        //Phương thức này nhận vào hai giá trị a và b và trả về giá trị lớn nhất trong hai giá trị đó.
        int TimMax(int a, int b);
        //chiều cao của node đó trong cây AVL.
        int GetHeight(Node current);
        //giá trị cân bằng tại node  đó.
        int GetBalance(Node current);
        //thực hiện phép xoay trái tại node current
        Node XoayTrai(Node current);
        //thực hiện phép xoay phải tại node current
        Node XoayPhai(Node current);
        Node Insert(Node current, int key);
        Node Tim (Node current, int key);
        Node Delete(Node current, int key);

        List<string> Insert_DSSS(Node root, int key);


    }
}
