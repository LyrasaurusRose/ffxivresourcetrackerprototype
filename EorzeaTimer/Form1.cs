using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EorzeaTimer
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> resourceDictionary;

        public Form1()
        {
            InitializeComponent();

            ResourceDictionary();
            PopulateListBox();
        }

        private void eorzea_timer_tick(object sender, EventArgs e)
        {
            // Get the current Unix Epoch
            long epoch = currentEpoch();

            // Use the current Epoch to get the Eorzean Epoch
            long current_time = Eorzea_Time(epoch);

            // Convert the Epoch int to DateTime
            DateTimeOffset dtobj = DateTimeOffset.FromUnixTimeMilliseconds(current_time);

            // Update the text on the form
            eorzeaTime.Text = dtobj.ToString("hh:mm tt");

        }

        private void local_timer_tick(object sender, EventArgs e)
        {
            // Get the current Unix Epoch and convert it to DateTime
            long epoch = currentEpoch();
            DateTimeOffset dtobj = DateTimeOffset.FromUnixTimeMilliseconds(epoch);

            // Convert the time object into system time
            DateTimeOffset nowLocal = dtobj.ToLocalTime();

            // Update the text on the form
            localTime.Text = nowLocal.ToString("hh:mm tt");
        }

        private long Eorzea_Time(long localEpoch)
        {
            double eorzeaOffset = 20.571428571428573;

            long eorzeaEpoch = Convert.ToInt64(localEpoch * eorzeaOffset);

            return eorzeaEpoch;
        }

        private long currentEpoch()
        {
            DateTimeOffset nowUTC = DateTimeOffset.UtcNow;
            long localEpoch = nowUTC.ToUnixTimeMilliseconds();

            return localEpoch;
        }

        private void ResourceDictionary()
        {
            resourceDictionary = new Dictionary<string, string>();

            resourceDictionary.Add("Duskblooms", "4");
            resourceDictionary.Add("Etherial Cocoon", "8");
            resourceDictionary.Add("Raindrop Cotton Ball", "10");
            resourceDictionary.Add("Rarefied Kelp", "4");
            resourceDictionary.Add("Silver Beech Log", "6");

        }

        private void PopulateListBox()
        {

            foreach (KeyValuePair<string, string> kvp in resourceDictionary)
            {
                resourceList.Items.Add($"{kvp.Key}");
            }
            
        }

        private void resourceList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.resourceList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                SpawnTime();
                currentlyTrackingLabel.Text = $"Currently Tracking: {resourceList.Text}";
                //MessageBox.Show($"You selected {resourceList.Text}");
            }
        }

        private void SpawnTime()
        {
            string spawnTime = resourceDictionary[$"{resourceList.Text}"];

            long localEpoch = currentEpoch();
            long eorzeaDT = Eorzea_Time(localEpoch);

            DateTimeOffset dtobj = DateTimeOffset.FromUnixTimeMilliseconds(eorzeaDT);

            if (Int32.Parse(dtobj.ToString("HH")) < Int32.Parse(spawnTime))
            {
                spawnTimeLabel.Text = $"Next Spawn Time (Eorzea Time): {spawnTime} AM";
            }
            else if (Int32.Parse(dtobj.ToString("HH")) < Int32.Parse(spawnTime) + 12)
            {
                spawnTimeLabel.Text = $"Next Spawn Time (Eorzea Time): {spawnTime} PM";
            }
            else if (Int32.Parse(dtobj.ToString("HH")) > Int32.Parse(spawnTime) + 12)
            {
                spawnTimeLabel.Text = $"Next Spawn Time (Eorzea Time): {spawnTime} AM";
            }

        }



        private void resourceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
