namespace _11_TreeViewListView
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load Directories
            dirTree.Nodes.Clear();
            LoadImageList();
            LoadDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), dirTree.Nodes);
            fileList.View = View.Tile;
            fileList.Columns.Add("Name").Width = 300;
            fileList.Columns.Add("Extencion", 300);
            fileList.Columns.Add("Create Time", 300);
        }
        void LoadImageList()
        {
            ImageList imageList = new ImageList();
            imageList.Images.Add(new Bitmap(@"C:\Users\helen\source\repos\WinFormsPD211\11_TreeViewListView\img\folder.png"));
            imageList.Images.Add(new Bitmap(@"C:\Users\helen\source\repos\WinFormsPD211\11_TreeViewListView\img\\openFolder.png"));
            imageList.Images.Add(new Bitmap(@"C:\Users\helen\source\repos\WinFormsPD211\11_TreeViewListView\img\\select.png"));

            dirTree.ImageList = imageList;
            dirTree.ImageList.ImageSize = new Size(50, 50);
        }
        void LoadDirectories(string dirPath, TreeNodeCollection nodes)
        {
             
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);

            foreach (var subDir in dirInfo.GetDirectories())
            {
                TreeNode newNode = new TreeNode(subDir.Name, 0,2);
                newNode.Tag = subDir.FullName;
                nodes.Add(newNode);
               // dirTree.Nodes.Add(subDir.Name);
                if (subDir.GetDirectories().Length > 0)
                    LoadDirectories(subDir.FullName, newNode.Nodes);                
            }
          

            
        }

        private void dirTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void dirTree_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void dirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            fileList.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(e.Node.Tag.ToString());
            foreach (var file in directory.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Extension);   
                item.SubItems.Add(file.CreationTime.ToString());   
                fileList.Items.Add(item);
            }
           
            //fileList.Items.Add();
        }
    }
}