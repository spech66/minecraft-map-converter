namespace MinecraftMapConverter
{
    public partial class Form1 : Form
    {
        string? MinecraftFolder { get; set; }

        public Form1()
        {
            InitializeComponent();

            LocateMinecraft();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                LocateMinecraftConfig(folderBrowserDialog1.SelectedPath);
            }
        }

        private void LocateMinecraft()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dotMinecraftPath = Path.Combine(appData, ".minecraft");
            LocateMinecraftConfig(dotMinecraftPath);
        }

        private void LocateMinecraftConfig(string path)
        {
            var minecraftConfig = Path.Combine(path, "launcher_profiles.json");

            if (File.Exists(minecraftConfig))
            {
                this.MinecraftFolder = Path.GetDirectoryName(minecraftConfig);
                this.linkLabelMinecraftPath.Text = this.MinecraftFolder;
            }
            else
            {
                MessageBox.Show(string.Format("Invalid Minecraft path {0}", minecraftConfig));
                this.linkLabelMinecraftPath.Text = "Select Minecraft Folder";
                this.MinecraftFolder = null;
            }
        }
    }
}