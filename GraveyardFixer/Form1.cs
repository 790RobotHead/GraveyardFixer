using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraveyardFixer
{
    public partial class Form1 : Form
    {
        const String npc_bishop_str = "npc_bishop";
        const String npc_astrologer_str = "npc_astrologer";
        const String npc_inquisitor_str = "npc_inquisitor";
        const String npc_actress_str = "npc_actress";
        const String npc_tavernOwner_str = "npc_tavern owner";
        const String npc_cultist_str = "npc_cultist";
        
        //    npc_blacksmith
        //    npc_farmer
        //    npc_merchant
        //    npc_carpenter
        //    npc_engineer

        const String position_str = "\"position\":";

        public Form1()
        {
            InitializeComponent();
        }

        String saveData;

        private void setPosOfNPC(String npcStr, String x, String y, String z)
        {
            npcStr = "\"obj_id\":\"" + npcStr + "\"";
            int obj_id_start_idx = saveData.IndexOf(npcStr) + npcStr.Length;
            String tempStr = saveData.Substring(obj_id_start_idx - 200, 200);
            int obj_id_end_idx = obj_id_start_idx + tempStr.IndexOf(",");

            int position_start_idx = obj_id_start_idx - 200 + tempStr.IndexOf(position_str) + position_str.Length;
            tempStr = saveData.Substring(position_start_idx, 200);
            int position_end_idx = position_start_idx + tempStr.IndexOf("}") + 1;

            //Console.WriteLine(saveData.Substring(position_start_idx, position_end_idx - position_start_idx));

            saveData = saveData.Substring(0, position_start_idx) + "{\"x\":" + x + ",\"y\":" + y + ",\"z\":" + z + "}" + saveData.Substring(position_end_idx);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader readStream = new StreamReader(textBoxInputFile.Text);
                saveData = readStream.ReadLine();
                readStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            MessageBox.Show("Loaded");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writeStream = new StreamWriter(textBoxOutputFile.Text);
                writeStream.Write(saveData);
                writeStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            MessageBox.Show("Saved");
        }

        private void buttonSetPriestPos_Click(object sender, EventArgs e)
        {
            setPosOfNPC(npc_bishop_str, textBoxPriestX.Text, textBoxPriestY.Text, textBoxPriestZ.Text);
            MessageBox.Show("Position set!");
        }

        private void buttonSetAstroPos_Click(object sender, EventArgs e)
        {
            setPosOfNPC(npc_astrologer_str, textBoxAstroX.Text, textBoxAstroY.Text, textBoxAstroZ.Text);
            MessageBox.Show("Position set!");
        }

        private void buttonSetInqPos_Click(object sender, EventArgs e)
        {
            setPosOfNPC(npc_inquisitor_str, textBoxInqX.Text, textBoxInqY.Text, textBoxInqZ.Text);
            MessageBox.Show("Position set!");
        }

        private void buttonSetActsPos_Click(object sender, EventArgs e)
        {
            setPosOfNPC(npc_actress_str, textBoxActsX.Text, textBoxActsY.Text, textBoxActsZ.Text);
            MessageBox.Show("Position set!");
        }

        private void buttonSetTavOwnPos_Click(object sender, EventArgs e)
        {
            setPosOfNPC(npc_tavernOwner_str, textBoxTavOwnX.Text, textBoxTavOwnY.Text, textBoxTavOwnZ.Text);
            MessageBox.Show("Position set!");
        }

        private void buttonSetCultPos_Click(object sender, EventArgs e)
        {
            setPosOfNPC(npc_cultist_str, textBoxCultX.Text, textBoxCultY.Text, textBoxCultZ.Text);
            MessageBox.Show("Position set!");
        }
    }
}
