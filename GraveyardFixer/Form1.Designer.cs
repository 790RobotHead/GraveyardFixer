namespace GraveyardFixer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelPriest = new System.Windows.Forms.Label();
            this.textBoxPriestX = new System.Windows.Forms.TextBox();
            this.textBoxPriestY = new System.Windows.Forms.TextBox();
            this.textBoxPriestZ = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.buttonSetPriestPos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAstroX = new System.Windows.Forms.TextBox();
            this.textBoxAstroY = new System.Windows.Forms.TextBox();
            this.textBoxAstroZ = new System.Windows.Forms.TextBox();
            this.buttonSetAstroPos = new System.Windows.Forms.Button();
            this.buttonSetInqPos = new System.Windows.Forms.Button();
            this.textBoxInqZ = new System.Windows.Forms.TextBox();
            this.textBoxInqY = new System.Windows.Forms.TextBox();
            this.textBoxInqX = new System.Windows.Forms.TextBox();
            this.labelInquisitor = new System.Windows.Forms.Label();
            this.buttonSetActsPos = new System.Windows.Forms.Button();
            this.textBoxActsZ = new System.Windows.Forms.TextBox();
            this.textBoxActsY = new System.Windows.Forms.TextBox();
            this.textBoxActsX = new System.Windows.Forms.TextBox();
            this.labelActress = new System.Windows.Forms.Label();
            this.buttonSetTavOwnPos = new System.Windows.Forms.Button();
            this.textBoxTavOwnZ = new System.Windows.Forms.TextBox();
            this.textBoxTavOwnY = new System.Windows.Forms.TextBox();
            this.textBoxTavOwnX = new System.Windows.Forms.TextBox();
            this.labelTavOwn = new System.Windows.Forms.Label();
            this.buttonSetCultPos = new System.Windows.Forms.Button();
            this.textBoxCultZ = new System.Windows.Forms.TextBox();
            this.textBoxCultY = new System.Windows.Forms.TextBox();
            this.textBoxCultX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Location = new System.Drawing.Point(115, 20);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.Size = new System.Drawing.Size(435, 20);
            this.textBoxInputFile.TabIndex = 0;
            this.textBoxInputFile.Text = "C:\\Users\\Garry\\AppData\\LocalLow\\Lazy Bear Games\\Graveyard Keeper\\1.dat";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(16, 23);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(83, 13);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "Path to savefile:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(556, 268);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(16, 273);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(74, 13);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Path to output";
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Location = new System.Drawing.Point(115, 270);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(435, 20);
            this.textBoxOutputFile.TabIndex = 5;
            this.textBoxOutputFile.Text = "C:\\Users\\Garry\\AppData\\LocalLow\\Lazy Bear Games\\Graveyard Keeper\\1.dat";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(556, 18);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(179, 55);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 7;
            this.labelX.Text = "X";
            // 
            // labelPriest
            // 
            this.labelPriest.AutoSize = true;
            this.labelPriest.Location = new System.Drawing.Point(16, 79);
            this.labelPriest.Name = "labelPriest";
            this.labelPriest.Size = new System.Drawing.Size(36, 13);
            this.labelPriest.TabIndex = 8;
            this.labelPriest.Text = "Priest:";
            // 
            // textBoxPriestX
            // 
            this.textBoxPriestX.Location = new System.Drawing.Point(115, 76);
            this.textBoxPriestX.Name = "textBoxPriestX";
            this.textBoxPriestX.Size = new System.Drawing.Size(141, 20);
            this.textBoxPriestX.TabIndex = 9;
            this.textBoxPriestX.Text = "3770.0054931640625";
            // 
            // textBoxPriestY
            // 
            this.textBoxPriestY.Location = new System.Drawing.Point(262, 76);
            this.textBoxPriestY.Name = "textBoxPriestY";
            this.textBoxPriestY.Size = new System.Drawing.Size(141, 20);
            this.textBoxPriestY.TabIndex = 10;
            this.textBoxPriestY.Text = "-200.9755859375";
            // 
            // textBoxPriestZ
            // 
            this.textBoxPriestZ.Location = new System.Drawing.Point(409, 76);
            this.textBoxPriestZ.Name = "textBoxPriestZ";
            this.textBoxPriestZ.Size = new System.Drawing.Size(141, 20);
            this.textBoxPriestZ.TabIndex = 11;
            this.textBoxPriestZ.Text = "-301.7032470703125";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(326, 55);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 12;
            this.labelY.Text = "Y";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(475, 55);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(14, 13);
            this.labelZ.TabIndex = 13;
            this.labelZ.Text = "Z";
            // 
            // buttonSetPriestPos
            // 
            this.buttonSetPriestPos.Location = new System.Drawing.Point(556, 74);
            this.buttonSetPriestPos.Name = "buttonSetPriestPos";
            this.buttonSetPriestPos.Size = new System.Drawing.Size(75, 23);
            this.buttonSetPriestPos.TabIndex = 14;
            this.buttonSetPriestPos.Text = "Set Position";
            this.buttonSetPriestPos.UseVisualStyleBackColor = true;
            this.buttonSetPriestPos.Click += new System.EventHandler(this.buttonSetPriestPos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Astrologer:";
            // 
            // textBoxAstroX
            // 
            this.textBoxAstroX.Location = new System.Drawing.Point(115, 105);
            this.textBoxAstroX.Name = "textBoxAstroX";
            this.textBoxAstroX.Size = new System.Drawing.Size(141, 20);
            this.textBoxAstroX.TabIndex = 16;
            this.textBoxAstroX.Text = "3820.0054931640625";
            // 
            // textBoxAstroY
            // 
            this.textBoxAstroY.Location = new System.Drawing.Point(262, 105);
            this.textBoxAstroY.Name = "textBoxAstroY";
            this.textBoxAstroY.Size = new System.Drawing.Size(141, 20);
            this.textBoxAstroY.TabIndex = 17;
            this.textBoxAstroY.Text = "-300.9755859375";
            // 
            // textBoxAstroZ
            // 
            this.textBoxAstroZ.Location = new System.Drawing.Point(409, 105);
            this.textBoxAstroZ.Name = "textBoxAstroZ";
            this.textBoxAstroZ.Size = new System.Drawing.Size(141, 20);
            this.textBoxAstroZ.TabIndex = 18;
            this.textBoxAstroZ.Text = "-301.7032470703125";
            // 
            // buttonSetAstroPos
            // 
            this.buttonSetAstroPos.Location = new System.Drawing.Point(556, 103);
            this.buttonSetAstroPos.Name = "buttonSetAstroPos";
            this.buttonSetAstroPos.Size = new System.Drawing.Size(75, 23);
            this.buttonSetAstroPos.TabIndex = 19;
            this.buttonSetAstroPos.Text = "Set Position";
            this.buttonSetAstroPos.UseVisualStyleBackColor = true;
            this.buttonSetAstroPos.Click += new System.EventHandler(this.buttonSetAstroPos_Click);
            // 
            // buttonSetInqPos
            // 
            this.buttonSetInqPos.Location = new System.Drawing.Point(556, 132);
            this.buttonSetInqPos.Name = "buttonSetInqPos";
            this.buttonSetInqPos.Size = new System.Drawing.Size(75, 23);
            this.buttonSetInqPos.TabIndex = 24;
            this.buttonSetInqPos.Text = "Set Position";
            this.buttonSetInqPos.UseVisualStyleBackColor = true;
            this.buttonSetInqPos.Click += new System.EventHandler(this.buttonSetInqPos_Click);
            // 
            // textBoxInqZ
            // 
            this.textBoxInqZ.Location = new System.Drawing.Point(409, 134);
            this.textBoxInqZ.Name = "textBoxInqZ";
            this.textBoxInqZ.Size = new System.Drawing.Size(141, 20);
            this.textBoxInqZ.TabIndex = 23;
            this.textBoxInqZ.Text = "-301.7032470703125";
            // 
            // textBoxInqY
            // 
            this.textBoxInqY.Location = new System.Drawing.Point(262, 134);
            this.textBoxInqY.Name = "textBoxInqY";
            this.textBoxInqY.Size = new System.Drawing.Size(141, 20);
            this.textBoxInqY.TabIndex = 22;
            this.textBoxInqY.Text = "-400.9755859375";
            // 
            // textBoxInqX
            // 
            this.textBoxInqX.Location = new System.Drawing.Point(115, 134);
            this.textBoxInqX.Name = "textBoxInqX";
            this.textBoxInqX.Size = new System.Drawing.Size(141, 20);
            this.textBoxInqX.TabIndex = 21;
            this.textBoxInqX.Text = "3870.0054931640625";
            // 
            // labelInquisitor
            // 
            this.labelInquisitor.AutoSize = true;
            this.labelInquisitor.Location = new System.Drawing.Point(16, 137);
            this.labelInquisitor.Name = "labelInquisitor";
            this.labelInquisitor.Size = new System.Drawing.Size(52, 13);
            this.labelInquisitor.TabIndex = 20;
            this.labelInquisitor.Text = "Inquisitor:";
            // 
            // buttonSetActsPos
            // 
            this.buttonSetActsPos.Location = new System.Drawing.Point(556, 161);
            this.buttonSetActsPos.Name = "buttonSetActsPos";
            this.buttonSetActsPos.Size = new System.Drawing.Size(75, 23);
            this.buttonSetActsPos.TabIndex = 29;
            this.buttonSetActsPos.Text = "Set Position";
            this.buttonSetActsPos.UseVisualStyleBackColor = true;
            this.buttonSetActsPos.Click += new System.EventHandler(this.buttonSetActsPos_Click);
            // 
            // textBoxActsZ
            // 
            this.textBoxActsZ.Location = new System.Drawing.Point(409, 163);
            this.textBoxActsZ.Name = "textBoxActsZ";
            this.textBoxActsZ.Size = new System.Drawing.Size(141, 20);
            this.textBoxActsZ.TabIndex = 28;
            this.textBoxActsZ.Text = "-301.7032470703125";
            // 
            // textBoxActsY
            // 
            this.textBoxActsY.Location = new System.Drawing.Point(262, 163);
            this.textBoxActsY.Name = "textBoxActsY";
            this.textBoxActsY.Size = new System.Drawing.Size(141, 20);
            this.textBoxActsY.TabIndex = 27;
            this.textBoxActsY.Text = "-500.9755859375";
            // 
            // textBoxActsX
            // 
            this.textBoxActsX.Location = new System.Drawing.Point(115, 163);
            this.textBoxActsX.Name = "textBoxActsX";
            this.textBoxActsX.Size = new System.Drawing.Size(141, 20);
            this.textBoxActsX.TabIndex = 26;
            this.textBoxActsX.Text = "3920.0054931640625";
            // 
            // labelActress
            // 
            this.labelActress.AutoSize = true;
            this.labelActress.Location = new System.Drawing.Point(16, 166);
            this.labelActress.Name = "labelActress";
            this.labelActress.Size = new System.Drawing.Size(45, 13);
            this.labelActress.TabIndex = 25;
            this.labelActress.Text = "Actress:";
            // 
            // buttonSetTavOwnPos
            // 
            this.buttonSetTavOwnPos.Location = new System.Drawing.Point(556, 190);
            this.buttonSetTavOwnPos.Name = "buttonSetTavOwnPos";
            this.buttonSetTavOwnPos.Size = new System.Drawing.Size(75, 23);
            this.buttonSetTavOwnPos.TabIndex = 34;
            this.buttonSetTavOwnPos.Text = "Set Position";
            this.buttonSetTavOwnPos.UseVisualStyleBackColor = true;
            this.buttonSetTavOwnPos.Click += new System.EventHandler(this.buttonSetTavOwnPos_Click);
            // 
            // textBoxTavOwnZ
            // 
            this.textBoxTavOwnZ.Location = new System.Drawing.Point(409, 192);
            this.textBoxTavOwnZ.Name = "textBoxTavOwnZ";
            this.textBoxTavOwnZ.Size = new System.Drawing.Size(141, 20);
            this.textBoxTavOwnZ.TabIndex = 33;
            this.textBoxTavOwnZ.Text = "-301.7032470703125";
            // 
            // textBoxTavOwnY
            // 
            this.textBoxTavOwnY.Location = new System.Drawing.Point(262, 192);
            this.textBoxTavOwnY.Name = "textBoxTavOwnY";
            this.textBoxTavOwnY.Size = new System.Drawing.Size(141, 20);
            this.textBoxTavOwnY.TabIndex = 32;
            this.textBoxTavOwnY.Text = "-600.9755859375";
            // 
            // textBoxTavOwnX
            // 
            this.textBoxTavOwnX.Location = new System.Drawing.Point(115, 192);
            this.textBoxTavOwnX.Name = "textBoxTavOwnX";
            this.textBoxTavOwnX.Size = new System.Drawing.Size(141, 20);
            this.textBoxTavOwnX.TabIndex = 31;
            this.textBoxTavOwnX.Text = "3970.0054931640625";
            // 
            // labelTavOwn
            // 
            this.labelTavOwn.AutoSize = true;
            this.labelTavOwn.Location = new System.Drawing.Point(16, 195);
            this.labelTavOwn.Name = "labelTavOwn";
            this.labelTavOwn.Size = new System.Drawing.Size(78, 13);
            this.labelTavOwn.TabIndex = 30;
            this.labelTavOwn.Text = "Tavern Owner:";
            // 
            // buttonSetCultPos
            // 
            this.buttonSetCultPos.Location = new System.Drawing.Point(556, 219);
            this.buttonSetCultPos.Name = "buttonSetCultPos";
            this.buttonSetCultPos.Size = new System.Drawing.Size(75, 23);
            this.buttonSetCultPos.TabIndex = 39;
            this.buttonSetCultPos.Text = "Set Position";
            this.buttonSetCultPos.UseVisualStyleBackColor = true;
            this.buttonSetCultPos.Click += new System.EventHandler(this.buttonSetCultPos_Click);
            // 
            // textBoxCultZ
            // 
            this.textBoxCultZ.Location = new System.Drawing.Point(409, 221);
            this.textBoxCultZ.Name = "textBoxCultZ";
            this.textBoxCultZ.Size = new System.Drawing.Size(141, 20);
            this.textBoxCultZ.TabIndex = 38;
            this.textBoxCultZ.Text = "-301.7032470703125";
            // 
            // textBoxCultY
            // 
            this.textBoxCultY.Location = new System.Drawing.Point(262, 221);
            this.textBoxCultY.Name = "textBoxCultY";
            this.textBoxCultY.Size = new System.Drawing.Size(141, 20);
            this.textBoxCultY.TabIndex = 37;
            this.textBoxCultY.Text = "-700.9755859375";
            // 
            // textBoxCultX
            // 
            this.textBoxCultX.Location = new System.Drawing.Point(115, 221);
            this.textBoxCultX.Name = "textBoxCultX";
            this.textBoxCultX.Size = new System.Drawing.Size(141, 20);
            this.textBoxCultX.TabIndex = 36;
            this.textBoxCultX.Text = "4020.0054931640625";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cultist:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 306);
            this.Controls.Add(this.buttonSetCultPos);
            this.Controls.Add(this.textBoxCultZ);
            this.Controls.Add(this.textBoxCultY);
            this.Controls.Add(this.textBoxCultX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSetTavOwnPos);
            this.Controls.Add(this.textBoxTavOwnZ);
            this.Controls.Add(this.textBoxTavOwnY);
            this.Controls.Add(this.textBoxTavOwnX);
            this.Controls.Add(this.labelTavOwn);
            this.Controls.Add(this.buttonSetActsPos);
            this.Controls.Add(this.textBoxActsZ);
            this.Controls.Add(this.textBoxActsY);
            this.Controls.Add(this.textBoxActsX);
            this.Controls.Add(this.labelActress);
            this.Controls.Add(this.buttonSetInqPos);
            this.Controls.Add(this.textBoxInqZ);
            this.Controls.Add(this.textBoxInqY);
            this.Controls.Add(this.textBoxInqX);
            this.Controls.Add(this.labelInquisitor);
            this.Controls.Add(this.buttonSetAstroPos);
            this.Controls.Add(this.textBoxAstroZ);
            this.Controls.Add(this.textBoxAstroY);
            this.Controls.Add(this.textBoxAstroX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetPriestPos);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxPriestZ);
            this.Controls.Add(this.textBoxPriestY);
            this.Controls.Add(this.textBoxPriestX);
            this.Controls.Add(this.labelPriest);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxOutputFile);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxInputFile);
            this.Name = "Form1";
            this.Text = "Let me fix this for you          -Garry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelPriest;
        private System.Windows.Forms.TextBox textBoxPriestX;
        private System.Windows.Forms.TextBox textBoxPriestY;
        private System.Windows.Forms.TextBox textBoxPriestZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Button buttonSetPriestPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAstroX;
        private System.Windows.Forms.TextBox textBoxAstroY;
        private System.Windows.Forms.TextBox textBoxAstroZ;
        private System.Windows.Forms.Button buttonSetAstroPos;
        private System.Windows.Forms.Button buttonSetInqPos;
        private System.Windows.Forms.TextBox textBoxInqZ;
        private System.Windows.Forms.TextBox textBoxInqY;
        private System.Windows.Forms.TextBox textBoxInqX;
        private System.Windows.Forms.Label labelInquisitor;
        private System.Windows.Forms.Button buttonSetActsPos;
        private System.Windows.Forms.TextBox textBoxActsZ;
        private System.Windows.Forms.TextBox textBoxActsY;
        private System.Windows.Forms.TextBox textBoxActsX;
        private System.Windows.Forms.Label labelActress;
        private System.Windows.Forms.Button buttonSetTavOwnPos;
        private System.Windows.Forms.TextBox textBoxTavOwnZ;
        private System.Windows.Forms.TextBox textBoxTavOwnY;
        private System.Windows.Forms.TextBox textBoxTavOwnX;
        private System.Windows.Forms.Label labelTavOwn;
        private System.Windows.Forms.Button buttonSetCultPos;
        private System.Windows.Forms.TextBox textBoxCultZ;
        private System.Windows.Forms.TextBox textBoxCultY;
        private System.Windows.Forms.TextBox textBoxCultX;
        private System.Windows.Forms.Label label2;
    }
}

