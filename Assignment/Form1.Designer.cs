
namespace Assignment
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculFlecheButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.momentTextBox = new System.Windows.Forms.TextBox();
            this.moduleTextBox = new System.Windows.Forms.TextBox();
            this.formeComboBox = new System.Windows.Forms.ComboBox();
            this.maximaleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.abaqueButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.associeeTextBox = new System.Windows.Forms.TextBox();
            this.ouvrirLogButton = new System.Windows.Forms.Button();
            this.longueurHScrollBar = new System.Windows.Forms.HScrollBar();
            this.chargeHScrollBar = new System.Windows.Forms.HScrollBar();
            this.chargeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.largeurLabel = new System.Windows.Forms.Label();
            this.hauteurLabel = new System.Windows.Forms.Label();
            this.largeurTextBox = new System.Windows.Forms.TextBox();
            this.hauteurTextBox = new System.Windows.Forms.TextBox();
            this.largeurHScrollBar = new System.Windows.Forms.HScrollBar();
            this.hauteurHScrollBar = new System.Windows.Forms.HScrollBar();
            this.rayonTextBox = new System.Windows.Forms.TextBox();
            this.rayonLabel = new System.Windows.Forms.Label();
            this.materiauxComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.longueurTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.momentHScrollBar = new System.Windows.Forms.HScrollBar();
            this.rayonHScrollBar = new System.Windows.Forms.HScrollBar();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resultatVertLabel = new System.Windows.Forms.Label();
            this.resultatRougeLabel = new System.Windows.Forms.Label();
            this.rectangulairePictureBox = new System.Windows.Forms.PictureBox();
            this.circulairePictureBox = new System.Windows.Forms.PictureBox();
            this.poutreBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectangulairePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulairePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poutreBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculFlecheButton
            // 
            this.calculFlecheButton.BackColor = System.Drawing.Color.PowderBlue;
            this.calculFlecheButton.Location = new System.Drawing.Point(630, 590);
            this.calculFlecheButton.Name = "calculFlecheButton";
            this.calculFlecheButton.Size = new System.Drawing.Size(152, 35);
            this.calculFlecheButton.TabIndex = 0;
            this.calculFlecheButton.Text = "Calculer la flèche";
            this.calculFlecheButton.UseVisualStyleBackColor = false;
            this.calculFlecheButton.Click += new System.EventHandler(this.calculFlecheButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Longueur (L)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forme de la section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moment quadratique (I en m4)  [0;1000]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Module d\'Young (E en GPa)";
            // 
            // momentTextBox
            // 
            this.momentTextBox.Location = new System.Drawing.Point(441, 180);
            this.momentTextBox.Name = "momentTextBox";
            this.momentTextBox.Size = new System.Drawing.Size(100, 22);
            this.momentTextBox.TabIndex = 7;
            this.momentTextBox.TextChanged += new System.EventHandler(this.momentTextBox_TextChanged);
            // 
            // moduleTextBox
            // 
            this.moduleTextBox.Location = new System.Drawing.Point(841, 213);
            this.moduleTextBox.Name = "moduleTextBox";
            this.moduleTextBox.ReadOnly = true;
            this.moduleTextBox.Size = new System.Drawing.Size(121, 22);
            this.moduleTextBox.TabIndex = 8;
            // 
            // formeComboBox
            // 
            this.formeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formeComboBox.FormattingEnabled = true;
            this.formeComboBox.Items.AddRange(new object[] {
            "Rectangulaire",
            "Circulaire"});
            this.formeComboBox.Location = new System.Drawing.Point(812, 35);
            this.formeComboBox.Name = "formeComboBox";
            this.formeComboBox.Size = new System.Drawing.Size(121, 24);
            this.formeComboBox.TabIndex = 10;
            this.formeComboBox.SelectedIndexChanged += new System.EventHandler(this.formeComboBox_SelectedIndexChanged);
            // 
            // maximaleTextBox
            // 
            this.maximaleTextBox.Location = new System.Drawing.Point(209, 140);
            this.maximaleTextBox.Name = "maximaleTextBox";
            this.maximaleTextBox.ReadOnly = true;
            this.maximaleTextBox.Size = new System.Drawing.Size(147, 22);
            this.maximaleTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Charge Appliquée en bout (en g)  [0;1000]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Flèche maximale admissible";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // abaqueButton
            // 
            this.abaqueButton.BackColor = System.Drawing.Color.PowderBlue;
            this.abaqueButton.Location = new System.Drawing.Point(14, 28);
            this.abaqueButton.Name = "abaqueButton";
            this.abaqueButton.Size = new System.Drawing.Size(124, 40);
            this.abaqueButton.TabIndex = 16;
            this.abaqueButton.Text = "Ouvrir Abaque";
            this.abaqueButton.UseVisualStyleBackColor = false;
            this.abaqueButton.Click += new System.EventHandler(this.abaqueButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Flèche associée";
            // 
            // associeeTextBox
            // 
            this.associeeTextBox.Location = new System.Drawing.Point(142, 83);
            this.associeeTextBox.Name = "associeeTextBox";
            this.associeeTextBox.ReadOnly = true;
            this.associeeTextBox.Size = new System.Drawing.Size(138, 22);
            this.associeeTextBox.TabIndex = 18;
            // 
            // ouvrirLogButton
            // 
            this.ouvrirLogButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ouvrirLogButton.Location = new System.Drawing.Point(24, 223);
            this.ouvrirLogButton.Name = "ouvrirLogButton";
            this.ouvrirLogButton.Size = new System.Drawing.Size(279, 30);
            this.ouvrirLogButton.TabIndex = 19;
            this.ouvrirLogButton.Text = "Enregister les calculs (log.txt)";
            this.ouvrirLogButton.UseVisualStyleBackColor = false;
            this.ouvrirLogButton.Click += new System.EventHandler(this.ouvrirLogButton_Click);
            // 
            // longueurHScrollBar
            // 
            this.longueurHScrollBar.Location = new System.Drawing.Point(300, 28);
            this.longueurHScrollBar.Maximum = 1000;
            this.longueurHScrollBar.Name = "longueurHScrollBar";
            this.longueurHScrollBar.Size = new System.Drawing.Size(120, 25);
            this.longueurHScrollBar.TabIndex = 26;
            this.longueurHScrollBar.ValueChanged += new System.EventHandler(this.longueurHScrollBar_ValueChanged);
            // 
            // chargeHScrollBar
            // 
            this.chargeHScrollBar.Location = new System.Drawing.Point(300, 221);
            this.chargeHScrollBar.Maximum = 1000;
            this.chargeHScrollBar.Name = "chargeHScrollBar";
            this.chargeHScrollBar.Size = new System.Drawing.Size(120, 23);
            this.chargeHScrollBar.TabIndex = 27;
            this.chargeHScrollBar.ValueChanged += new System.EventHandler(this.chargeHScrollBar_ValueChanged);
            // 
            // chargeTextBox
            // 
            this.chargeTextBox.Location = new System.Drawing.Point(441, 221);
            this.chargeTextBox.Name = "chargeTextBox";
            this.chargeTextBox.Size = new System.Drawing.Size(100, 22);
            this.chargeTextBox.TabIndex = 29;
            this.chargeTextBox.TextChanged += new System.EventHandler(this.chargeTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Faire un choix de matériaux :";
            // 
            // largeurLabel
            // 
            this.largeurLabel.AutoSize = true;
            this.largeurLabel.Enabled = false;
            this.largeurLabel.Location = new System.Drawing.Point(11, 102);
            this.largeurLabel.Name = "largeurLabel";
            this.largeurLabel.Size = new System.Drawing.Size(181, 17);
            this.largeurLabel.TabIndex = 33;
            this.largeurLabel.Text = "Largeur (l en mm)  [0;1000]";
            // 
            // hauteurLabel
            // 
            this.hauteurLabel.AutoSize = true;
            this.hauteurLabel.Enabled = false;
            this.hauteurLabel.Location = new System.Drawing.Point(617, 402);
            this.hauteurLabel.Name = "hauteurLabel";
            this.hauteurLabel.Size = new System.Drawing.Size(191, 17);
            this.hauteurLabel.TabIndex = 34;
            this.hauteurLabel.Text = "Hauteur (h en mm)  [0;1000] ";
            // 
            // largeurTextBox
            // 
            this.largeurTextBox.Enabled = false;
            this.largeurTextBox.Location = new System.Drawing.Point(1047, 360);
            this.largeurTextBox.Name = "largeurTextBox";
            this.largeurTextBox.Size = new System.Drawing.Size(100, 22);
            this.largeurTextBox.TabIndex = 35;
            this.largeurTextBox.TextChanged += new System.EventHandler(this.largeurTextBox_TextChanged);
            // 
            // hauteurTextBox
            // 
            this.hauteurTextBox.Enabled = false;
            this.hauteurTextBox.Location = new System.Drawing.Point(441, 141);
            this.hauteurTextBox.Name = "hauteurTextBox";
            this.hauteurTextBox.Size = new System.Drawing.Size(100, 22);
            this.hauteurTextBox.TabIndex = 36;
            this.hauteurTextBox.TextChanged += new System.EventHandler(this.hauteurTextBox_TextChanged);
            // 
            // largeurHScrollBar
            // 
            this.largeurHScrollBar.Enabled = false;
            this.largeurHScrollBar.Location = new System.Drawing.Point(299, 102);
            this.largeurHScrollBar.Maximum = 1000;
            this.largeurHScrollBar.Name = "largeurHScrollBar";
            this.largeurHScrollBar.Size = new System.Drawing.Size(121, 23);
            this.largeurHScrollBar.TabIndex = 37;
            this.largeurHScrollBar.ValueChanged += new System.EventHandler(this.largeurHScrollBar_ValueChanged);
            // 
            // hauteurHScrollBar
            // 
            this.hauteurHScrollBar.Enabled = false;
            this.hauteurHScrollBar.Location = new System.Drawing.Point(906, 401);
            this.hauteurHScrollBar.Maximum = 1000;
            this.hauteurHScrollBar.Name = "hauteurHScrollBar";
            this.hauteurHScrollBar.Size = new System.Drawing.Size(120, 22);
            this.hauteurHScrollBar.TabIndex = 38;
            this.hauteurHScrollBar.ValueChanged += new System.EventHandler(this.hauteurHScrollBar_ValueChanged);
            // 
            // rayonTextBox
            // 
            this.rayonTextBox.Enabled = false;
            this.rayonTextBox.Location = new System.Drawing.Point(441, 63);
            this.rayonTextBox.Name = "rayonTextBox";
            this.rayonTextBox.Size = new System.Drawing.Size(100, 22);
            this.rayonTextBox.TabIndex = 39;
            this.rayonTextBox.TextChanged += new System.EventHandler(this.rayonTextBox_TextChanged);
            // 
            // rayonLabel
            // 
            this.rayonLabel.AutoSize = true;
            this.rayonLabel.Enabled = false;
            this.rayonLabel.Location = new System.Drawing.Point(11, 65);
            this.rayonLabel.Name = "rayonLabel";
            this.rayonLabel.Size = new System.Drawing.Size(174, 17);
            this.rayonLabel.TabIndex = 40;
            this.rayonLabel.Text = "Rayon (r en mm)  [0;1000]";
            // 
            // materiauxComboBox
            // 
            this.materiauxComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materiauxComboBox.FormattingEnabled = true;
            this.materiauxComboBox.Location = new System.Drawing.Point(841, 166);
            this.materiauxComboBox.Name = "materiauxComboBox";
            this.materiauxComboBox.Size = new System.Drawing.Size(259, 24);
            this.materiauxComboBox.TabIndex = 43;
            this.materiauxComboBox.SelectedIndexChanged += new System.EventHandler(this.materiauxComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.abaqueButton);
            this.groupBox1.Location = new System.Drawing.Point(606, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 163);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matériaux";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(606, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 64);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Section";
            // 
            // longueurTextBox
            // 
            this.longueurTextBox.Location = new System.Drawing.Point(1047, 288);
            this.longueurTextBox.Name = "longueurTextBox";
            this.longueurTextBox.Size = new System.Drawing.Size(100, 22);
            this.longueurTextBox.TabIndex = 28;
            this.longueurTextBox.TextChanged += new System.EventHandler(this.longueurTextBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.momentHScrollBar);
            this.groupBox3.Controls.Add(this.rayonHScrollBar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.chargeHScrollBar);
            this.groupBox3.Controls.Add(this.chargeTextBox);
            this.groupBox3.Controls.Add(this.rayonTextBox);
            this.groupBox3.Controls.Add(this.largeurLabel);
            this.groupBox3.Controls.Add(this.rayonLabel);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.longueurHScrollBar);
            this.groupBox3.Controls.Add(this.hauteurTextBox);
            this.groupBox3.Controls.Add(this.largeurHScrollBar);
            this.groupBox3.Controls.Add(this.momentTextBox);
            this.groupBox3.Location = new System.Drawing.Point(606, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 282);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuration";
            // 
            // momentHScrollBar
            // 
            this.momentHScrollBar.Location = new System.Drawing.Point(300, 180);
            this.momentHScrollBar.Name = "momentHScrollBar";
            this.momentHScrollBar.Size = new System.Drawing.Size(122, 21);
            this.momentHScrollBar.TabIndex = 42;
            this.momentHScrollBar.ValueChanged += new System.EventHandler(this.momentHScrollBar_ValueChanged);
            // 
            // rayonHScrollBar
            // 
            this.rayonHScrollBar.Enabled = false;
            this.rayonHScrollBar.Location = new System.Drawing.Point(299, 63);
            this.rayonHScrollBar.Maximum = 1000;
            this.rayonHScrollBar.Name = "rayonHScrollBar";
            this.rayonHScrollBar.Size = new System.Drawing.Size(121, 24);
            this.rayonHScrollBar.TabIndex = 41;
            this.rayonHScrollBar.ValueChanged += new System.EventHandler(this.rayonHScrollBar_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(197, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Longueur (L en mm)  [0;1000]";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resultatVertLabel);
            this.groupBox4.Controls.Add(this.resultatRougeLabel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.associeeTextBox);
            this.groupBox4.Controls.Add(this.ouvrirLogButton);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.maximaleTextBox);
            this.groupBox4.Location = new System.Drawing.Point(606, 560);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(556, 266);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculs et conclusion";
            // 
            // resultatVertLabel
            // 
            this.resultatVertLabel.AutoSize = true;
            this.resultatVertLabel.ForeColor = System.Drawing.Color.Green;
            this.resultatVertLabel.Location = new System.Drawing.Point(21, 187);
            this.resultatVertLabel.Name = "resultatVertLabel";
            this.resultatVertLabel.Size = new System.Drawing.Size(353, 17);
            this.resultatVertLabel.TabIndex = 21;
            this.resultatVertLabel.Text = "La charge peut être supportée par la poutre encastrée";
            this.resultatVertLabel.Visible = false;
            // 
            // resultatRougeLabel
            // 
            this.resultatRougeLabel.AutoSize = true;
            this.resultatRougeLabel.ForeColor = System.Drawing.Color.Red;
            this.resultatRougeLabel.Location = new System.Drawing.Point(21, 187);
            this.resultatRougeLabel.Name = "resultatRougeLabel";
            this.resultatRougeLabel.Size = new System.Drawing.Size(400, 17);
            this.resultatRougeLabel.TabIndex = 20;
            this.resultatRougeLabel.Text = "La charge ne peut pas être supportée par la poutre encastrée";
            this.resultatRougeLabel.Visible = false;
            // 
            // rectangulairePictureBox
            // 
            this.rectangulairePictureBox.Image = global::Assignment.Properties.Resources.sectionrectangulaire;
            this.rectangulairePictureBox.Location = new System.Drawing.Point(12, 361);
            this.rectangulairePictureBox.Name = "rectangulairePictureBox";
            this.rectangulairePictureBox.Size = new System.Drawing.Size(553, 368);
            this.rectangulairePictureBox.TabIndex = 50;
            this.rectangulairePictureBox.TabStop = false;
            this.rectangulairePictureBox.Visible = false;
            // 
            // circulairePictureBox
            // 
            this.circulairePictureBox.Image = global::Assignment.Properties.Resources.sectioncylindrique;
            this.circulairePictureBox.Location = new System.Drawing.Point(12, 322);
            this.circulairePictureBox.Name = "circulairePictureBox";
            this.circulairePictureBox.Size = new System.Drawing.Size(553, 368);
            this.circulairePictureBox.TabIndex = 49;
            this.circulairePictureBox.TabStop = false;
            this.circulairePictureBox.Visible = false;
            // 
            // poutreBox1
            // 
            this.poutreBox1.Image = global::Assignment.Properties.Resources.poutre_encastree;
            this.poutreBox1.InitialImage = null;
            this.poutreBox1.Location = new System.Drawing.Point(12, 106);
            this.poutreBox1.Name = "poutreBox1";
            this.poutreBox1.Size = new System.Drawing.Size(553, 201);
            this.poutreBox1.TabIndex = 20;
            this.poutreBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Poutre encastrée  :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 847);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rectangulairePictureBox);
            this.Controls.Add(this.circulairePictureBox);
            this.Controls.Add(this.poutreBox1);
            this.Controls.Add(this.materiauxComboBox);
            this.Controls.Add(this.hauteurHScrollBar);
            this.Controls.Add(this.largeurTextBox);
            this.Controls.Add(this.hauteurLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.longueurTextBox);
            this.Controls.Add(this.formeComboBox);
            this.Controls.Add(this.moduleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculFlecheButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Calculateur de flèche ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectangulairePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulairePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poutreBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculFlecheButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox momentTextBox;
        private System.Windows.Forms.TextBox moduleTextBox;
        private System.Windows.Forms.ComboBox formeComboBox;
        private System.Windows.Forms.TextBox maximaleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button abaqueButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox associeeTextBox;
        private System.Windows.Forms.Button ouvrirLogButton;
        private System.Windows.Forms.PictureBox poutreBox1;
        private System.Windows.Forms.HScrollBar longueurHScrollBar;
        private System.Windows.Forms.HScrollBar chargeHScrollBar;
        private System.Windows.Forms.TextBox chargeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label largeurLabel;
        private System.Windows.Forms.Label hauteurLabel;
        private System.Windows.Forms.TextBox largeurTextBox;
        private System.Windows.Forms.TextBox hauteurTextBox;
        private System.Windows.Forms.HScrollBar largeurHScrollBar;
        private System.Windows.Forms.HScrollBar hauteurHScrollBar;
        private System.Windows.Forms.TextBox rayonTextBox;
        private System.Windows.Forms.Label rayonLabel;
        private System.Windows.Forms.ComboBox materiauxComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox longueurTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.HScrollBar rayonHScrollBar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox circulairePictureBox;
        private System.Windows.Forms.PictureBox rectangulairePictureBox;
        private System.Windows.Forms.Label resultatRougeLabel;
        private System.Windows.Forms.Label resultatVertLabel;
        private System.Windows.Forms.HScrollBar momentHScrollBar;
        private System.Windows.Forms.Label label8;
    }
}

