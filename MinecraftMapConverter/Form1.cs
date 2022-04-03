using MinecraftTools.MapMods;

namespace MinecraftMapConverter
{
    public partial class Form1 : Form
    {
        private string? MinecraftFolder { get; set; }

        private IMapMod? InputMod { get; set; } = null;

        private IMapMod? OutputMod { get; set; } = null;

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

            GetInputWorlds();
            GetOutputWorlds();
            CheckFields();
        }

        private void GetInputWorlds()
        {
            if (this.MinecraftFolder == null)
            {
                return;
            }

            this.InputMod = new VoxelMap(this.MinecraftFolder);
            comboBoxInput.Items.Clear();
            comboBoxInput.Items.AddRange(this.InputMod.Worlds.ToArray());

            if(comboBoxInput.Items.Count > 0)
            {
                comboBoxInput.SelectedIndex = 0;
            }
        }

        private void GetOutputWorlds()
        {
            if (this.MinecraftFolder == null)
            {
                return;
            }

            this.OutputMod = new XaeroWaypoints(this.MinecraftFolder);
            comboBoxOutput.Items.Clear();
            comboBoxOutput.Items.AddRange(this.OutputMod.Worlds.ToArray());

            if (comboBoxOutput.Items.Count > 0)
            {
                comboBoxOutput.SelectedIndex = 0;
            }
        }

        private void CheckFields()
        {
            buttonConvert.Enabled = false;

            if (!string.IsNullOrWhiteSpace(this.MinecraftFolder) && comboBoxInput.SelectedItem != null && comboBoxOutput.SelectedItem != null)
            {
                buttonConvert.Enabled = true;
            }
        }

        private void comboBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void comboBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if(InputMod == null || comboBoxInput.SelectedItem == null || OutputMod == null || comboBoxOutput.SelectedItem == null)
            {
                return;
            }

            var waypoints = InputMod.ExtractWaypoints(comboBoxInput.SelectedItem as string);
            OutputMod.SaveWaypoints(comboBoxOutput.SelectedItem as string, waypoints);

            MessageBox.Show("Writing waypoints completed!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
