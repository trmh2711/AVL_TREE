using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;



namespace AVL_TREE
{
    public partial class AVL_TREE : Form
    {
        private object lockObject = new object(); // Đối tượng khóa để tránh xung đột giữa các luồng
        public Node root { get; set; }
        public Color mauNode;
        public Color mauLine;
        private int x, y, size, Height;

        private string messageLabelText = "";
        public IXuLy XuLy { get; set; }
        public int delay;

        public AVL_TREE()
        {

            //this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            //this.StartPosition = FormStartPosition.CenterScreen;
            mauNode = Color.Black;
            mauLine = Color.Blue;

            Height = 60;
            y = 20;        
            size = 22;
            XuLy = new XuLy();
            this.DoubleBuffered = true;
            InitializeComponent();
            Auto();       
        }
        private void Auto()
        {
            this.WindowState = FormWindowState.Maximized;


            // Đặt Anchor để Panel và Button tự động thay đổi kích thước khi Form thay đổi kích thước
            ShowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //button 
            btn_chonfile.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left ;
            btn_random.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            btn_them.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            btn_tim.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            btn_xoa.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            btn_xoa_tree.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            hScrollBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

            // Đặt Dock để Panel chiếm hết kích thước 
            ShowPanel.Dock = /*DockStyle.None |*/ DockStyle.Fill;
            panel2.Dock = DockStyle.Bottom;

            label1.Dock = DockStyle.Fill;
            label2.Dock = DockStyle.Fill;
            label3.Dock = DockStyle.Fill;
            label4.Dock = DockStyle.Fill;
            label5.Dock = DockStyle.Fill;

            cb_random.Dock = DockStyle.Fill;
            txt_chonFile.Dock = DockStyle.Fill;
            txt_them.Dock = DockStyle.Fill;
            txt_tim.Dock = DockStyle.Fill;
            txt_xoa.Dock = DockStyle.Fill;
            btn_chonfile.Dock = DockStyle.Left;
            label1.Dock = DockStyle.Fill;
            txt_chonFile.Dock = DockStyle.Fill;

            // Đặt AutoSize và AutoSizeMode cho Button
            btn_chonfile.AutoSize = true;
            btn_chonfile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_random.AutoSize = true;
            btn_random.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_them.AutoSize = true;
            btn_them.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_tim.AutoSize = true;
            btn_tim.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_xoa.AutoSize = true;
            btn_xoa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_xoa_tree.AutoSize = true;
            btn_xoa_tree.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hScrollBar1.AutoSize = true;

            //panel2.Controls.Add(btn_chonfile);
            panel2.Controls.Add(btn_random);
            panel2.Controls.Add(btn_them);
            panel2.Controls.Add(btn_tim);
            panel2.Controls.Add(btn_xoa);
            panel2.Controls.Add(btn_xoa_tree);
            panel2.Controls.Add(hScrollBar1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel2);
            
        }
        private void ClearText()
        { 
            txt_chonFile.Clear();
            txt_them.Clear();
            txt_tim.Clear();
            txt_xoa.Clear();
        }
        private void HoatAnhDeleteTree(Node current)
        {
            if (current != null)
            {
                // Sử dụng Timer để đặt khoảng thời gian giữa các bước xóa
                System.Windows.Forms.Timer deleteTimer = new System.Windows.Forms.Timer();
                deleteTimer.Interval = 50; // Đặt khoảng thời gian (miliseconds) giữa các bước xóa
                deleteTimer.Tick += (s, e) =>
                {
                    current = XuLy.Delete(root, current.Kay);
                    ShowPanel.Refresh();
                    root = null;
                    if (current == null)
                    {
                        deleteTimer.Stop();
                    }
                };

                deleteTimer.Start();
            }
        }
        private void btn_xoa_tree_Click(object sender, EventArgs e)
        {
            HoatAnhDeleteTree(root);
        }
        private async void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_them.Text == "")
                {
                    MessageBox.Show("Vui lòng không để trống  !!!");
                }
                else
                {
                    int ValueAdd = int.Parse(txt_them.Text);
                    if (root != null)
                    {

                        Node TimNode = await Tim(root, ValueAdd);
                        //await HoatAnhTimKiem(root, TimNode);
                        //root = XuLy.Insert(root, ValueAdd);
                        if (TimNode == null)
                        {
                            root = XuLy.Insert(root, ValueAdd);
                            //await Task.Delay(delay);
                            List<string> comparisons = XuLy.Insert_DSSS(root, ValueAdd);
                            await Tim(root, ValueAdd);
                            foreach (var comparison in comparisons)
                            {
                                UpdateMessageLabel(comparison);
                                await Task.Delay(delay);
                                //Thread.Sleep(delay);
                                label_dauvao.Text = $"Thêm giá trị: {ValueAdd}";
                            }              
                            ShowPanel.Refresh();
                        }
                        else {
                            label_dauvao.Text = $"Đã tồn tại node  {ValueAdd}";
                            ShowPanel.Refresh();
                        }
                    }
                    else
                    {
                        root = XuLy.MakeRoot(ValueAdd);
                        ShowPanel.Refresh();
                    } 
                    ClearText();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
        private  void UpdateMessageLabel(string message)
        {
            messageLabelText = message;
            label_dauvao.Text = messageLabelText;
            label_dauvao.Refresh();
        }

        private  void  Add(int value)
        {
           
            if (root != null )
            {
               
                root = XuLy.Insert(root, value);
                string a = txt_them.Text;
               
                // Thêm giá trị vào cây và lấy danh sách các bước so sánh
                List<string> comparisons = XuLy.Insert_DSSS(root, value);
                // Hiển thị từng bước so sánh trên Label
                foreach (var comparison in comparisons)
                {
                    UpdateMessageLabel(comparison);
                    Thread.Sleep(delay);
                    label_dauvao.Text = $"Thêm giá trị: {a}";
                }

            }
            else
            {
                root = XuLy.MakeRoot(value);
           
            }
        }
        private async Task AddNodeFile(string line)
        {
            string[] numbers = line.Split(' ');

            foreach (var numberStr in numbers)
            {
                if (int.TryParse(numberStr, out int value))
                {
                    if (root != null)
                    {
                        // Thêm giá trị vào cây
                        root = XuLy.Insert(root, value);
                    }
                    else
                    {
                        root = XuLy.MakeRoot(value);
                    }

                    // Hiển thị cây trên panel
                    ShowPanel.Refresh();

                    await Task.Delay(delay);
                }
            }
        }

        private void txt_them_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_them_Click(sender, e);

            }
        }

        private async void btn_random_Click(object sender, EventArgs e)
        {    
                int numberOfElements = Convert.ToInt32(cb_random.Value);
                Random random = new Random();

                for (int i = 0; i < numberOfElements; i++)
                {
                    int randomValue = random.Next(1, 100); // giá trị ngẫu nhiên từ 1 đến 100

                    // Sử dụng Invoke để cập nhật giao diện người dùng từ luồng UI chính
                    Invoke((MethodInvoker)delegate
                    {
                        Add(randomValue);
                        ShowPanel.Refresh();
                    });

                    // Chờ một khoảng thời gian trước khi thêm giá trị tiếp theo
                    int delay1;
                    lock (lockObject)
                    {
                        delay1 = delay;
                    }
                    await Task.Delay(delay1);
                }            
        }

        private async void btn_tim_Click(object sender, EventArgs e)
        { 
            try
            {
                if (txt_tim.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập node cần tìm  !!!");
                }
                else
                {
                    int keyToSearch = int.Parse(txt_tim.Text);
                    Node TimNode = await Tim(root, keyToSearch);
                    if (TimNode != null)
                    {
                        label_dauvao.Text = $"Tìm thấy node: {keyToSearch}";    
                        ShowPanel.Refresh();                        
                    }
                    else
                    {
                        label_dauvao.Text = $"Không tìm thấy node: {keyToSearch}";
                        ShowPanel.Refresh();
                    }
                   // ShowPanel.Refresh();
                }                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txt_tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_tim_Click(sender, e);            
            }
        }
        private async void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_xoa.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập node cần xóa !!!");
                }
                else
                {
                    int keyToDelete = int.Parse(txt_xoa.Text);
                    Node TimNode = await Tim(root, keyToDelete);
                    //Node deletedNode = XuLy.Tim(root, keyToDelete);
                    if (TimNode != null)
                    {
                        label_dauvao.Text = $"Xóa node : {keyToDelete}";
                        root = XuLy.Delete(root, keyToDelete);
                        //Thread.Sleep(delay);
                        ShowPanel.Refresh();
                    }
                    else
                    {
                        label_dauvao.Text = $"Node không tồn tại : {keyToDelete}";
                        MessageBox.Show($"Node  {keyToDelete} không tồn tại trong AVL tree.");
                        //Thread.Sleep(delay);
                        ShowPanel.Refresh();
                    }
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txt_xoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_xoa_Click(sender, e);
            }
        }
        private async void btn_chonfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "Files|*.txt*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                txt_chonFile.Text = selectedFileName;
              
                string line = File.ReadAllText(selectedFileName);
                // Tạo cây từ chuỗi            
                await AddNodeFile(line);
                ShowPanel.Refresh();
            }
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {           
            int scrollValue = hScrollBar1.Value;
            txt_chonFile.Text = scrollValue.ToString();
            delay = scrollValue;   
        }

        private void AVL_TREE_Load(object sender, EventArgs e)
        {
            delay = hScrollBar1.Value;
            ShowPanel.BackColor = Color.White;
            x =( ShowPanel.Size.Width / 2) - (size/2) ;  
            
        }
        private void AVL_TREE_SizeChanged(object sender, EventArgs e)
        {
            ShowPanel.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            ShowPanel.Invalidate();
            AVL_TREE_Load(sender, e);
        }
        private void ShowPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int distanceToEdge = Math.Min(x, this.Width - x); // Khoảng cách từ node cha đến cạnh biên
            int Factor = distanceToEdge / 2;         
            VeCay(x, y, root, g, Factor, root);
        }
        private void VeCay(int x, int y, Node node, Graphics g, int KhoangCach, Node targetNode)
        {
            Pen nodePen = new Pen(mauNode);
            Pen linePen = new Pen(mauLine);

            if (node == null)
                return;
            else
            {
                string value = node.Kay.ToString();
                Font font = new Font("Arial",10 , FontStyle.Bold);
                SolidBrush solidbrush = new SolidBrush(mauNode);
                // Kiểm tra xem nút hiện tại có nằm trên đường tìm kiếm không
                bool isOnSearchPath = NodeTrenDuongTimKiem(node, targetNode);
                int searchValue;
                bool txttim = int.TryParse(txt_tim.Text, out searchValue);
                bool txtthem = int.TryParse(txt_them.Text, out searchValue);
                bool txtxoa  = int.TryParse(txt_xoa.Text, out searchValue);
                if ((txttim || txtthem || txtxoa) && isOnSearchPath)
                {
                   
                    Brush b = new SolidBrush(Color.LightGreen);
                    g.FillEllipse(b, x, y, size, size);

                }
               
                if (node == targetNode && (txttim || txtthem || txtxoa))
                {
                    Pen outerCirclePen = new Pen(mauNode,1);  
                    Brush b = new SolidBrush(Color.Yellow);
                    g.FillEllipse(b, x, y, size, size);
                    g.DrawEllipse(outerCirclePen, x, y, size, size);

                }
                //ve node
                g.DrawEllipse(nodePen, x, y, size, size);

                float xText = x + (size - g.MeasureString(value, font).Width) / 2;
                float yText = y + (size - g.MeasureString(value, font).Height) / 2;

                //vẽ chữ
                g.DrawString(value, font, solidbrush, xText, yText);

                VeCay(x - KhoangCach, y + Height, node.LeftChild, g, KhoangCach / 2, targetNode);
                VeCay(x + KhoangCach, y + Height, node.RightChild, g, KhoangCach / 2, targetNode);


                if (node.LeftChild != null)
                    g.DrawLine(linePen, x + size / 2, y + size, x - KhoangCach + size / 2, y + Height);

                if (node.RightChild != null)
                    g.DrawLine(linePen, x + size / 2, y + size, x + KhoangCach + size / 2, y + Height);
             
            }
           
        }
        private bool NodeTrenDuongTimKiem(Node currentNode, Node targetNode)
        {
            while (currentNode != null)
            {
                if (currentNode == targetNode)
                    return true;
                if (targetNode.Kay < currentNode.Kay)
                    currentNode = currentNode.LeftChild;
                else
                    currentNode = currentNode.RightChild;
            }
            return false;
        }
        private async Task HoatAnhTimKiem(Node root, Node targetNode)
        {
            if (targetNode == null)
                return;
            // Lưu trữ đường đi từ node gốc đến node mục tiêu
            List<Node> path = new List<Node>();
            Node currentNode = root;
            while (currentNode != null && currentNode != targetNode)
            {
                path.Add(currentNode);
                if (targetNode.Kay < currentNode.Kay)
                    currentNode = currentNode.LeftChild;
                else
                    currentNode = currentNode.RightChild;
            }
            path.Add(targetNode);
            // Sử dụng Timer để vẽ vòng tròn đỏ 
            System.Windows.Forms.Timer searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 50;
            int currentIndex = 1;
            searchTimer.Tick += async (s, e) =>
            {
                if (currentIndex < path.Count)
                { 
                    // Lấy nút từ đường đi
                    Node currentNodeInPath = path[currentIndex];            
                    Graphics g = ShowPanel.CreateGraphics();
                    int distanceToEdge = Math.Min(x, this.Width - x); // Khoảng cách từ node cha đến cạnh biên
                    int calculatedFactor = distanceToEdge / 2;
                    VeCay(x, y, root, g, calculatedFactor, currentNodeInPath);
                    currentIndex++;
                }
                else
                {
                    // Dừng Timer sau khi đã vẽ xong đường đi
                    searchTimer.Stop();
                }
                // Chờ  giữa các bước
                await Task.Delay(delay);
            };
            searchTimer.Start();
            await Task.Delay(delay*3); // Chờ  để bắt đầu hiệu ứng
        }
        public async Task<Node> Tim(Node current, int key)
        {
            if (current == null || current.Kay == key)
            {
                await HoatAnhTimKiem(root, current);
                return current;
            }
            else if (key < current.Kay)
            {
                await HoatAnhTimKiem(root, current);
                return await Tim(current.LeftChild, key);
            }
            else
            {
                await HoatAnhTimKiem(root, current);
                return await Tim(current.RightChild, key);          
            }
        }      
    }
}
