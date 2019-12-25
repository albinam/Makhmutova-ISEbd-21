namespace WindowsFormArmorCar
{
    partial class FormArmorCarConfig
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
            this.pictureBoxArmorCar = new System.Windows.Forms.PictureBox();
            this.labelArmorCar = new System.Windows.Forms.Label();
            this.labelArtilleryMount = new System.Windows.Forms.Label();
            this.groupBoxTypeOfCar = new System.Windows.Forms.GroupBox();
            this.panelArmorCar = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGrey = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.GroupBoxGunType = new System.Windows.Forms.GroupBox();
            this.labelGunsWithAngle = new System.Windows.Forms.Label();
            this.labelGunsWithPattern = new System.Windows.Forms.Label();
            this.labelSimpleGuns = new System.Windows.Forms.Label();
            this.labelGunsType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmorCar)).BeginInit();
            this.groupBoxTypeOfCar.SuspendLayout();
            this.panelArmorCar.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.GroupBoxGunType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxArmorCar
            // 
            this.pictureBoxArmorCar.Location = new System.Drawing.Point(19, 27);
            this.pictureBoxArmorCar.Name = "pictureBoxArmorCar";
            this.pictureBoxArmorCar.Size = new System.Drawing.Size(155, 102);
            this.pictureBoxArmorCar.TabIndex = 0;
            this.pictureBoxArmorCar.TabStop = false;
            // 
            // labelArmorCar
            // 
            this.labelArmorCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelArmorCar.Location = new System.Drawing.Point(24, 29);
            this.labelArmorCar.Name = "labelArmorCar";
            this.labelArmorCar.Size = new System.Drawing.Size(136, 27);
            this.labelArmorCar.TabIndex = 1;
            this.labelArmorCar.Text = "Бронированная машина";
            this.labelArmorCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelArmorCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelArmorCar_DragDrop);
            this.labelArmorCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelArmorCar_DragEnter);
            this.labelArmorCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelArmorCar_MouseDown);
            // 
            // labelArtilleryMount
            // 
            this.labelArtilleryMount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelArtilleryMount.Location = new System.Drawing.Point(24, 75);
            this.labelArtilleryMount.Name = "labelArtilleryMount";
            this.labelArtilleryMount.Size = new System.Drawing.Size(136, 43);
            this.labelArtilleryMount.TabIndex = 2;
            this.labelArtilleryMount.Text = "Самоходная артиллерейская установка";
            this.labelArtilleryMount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelArtilleryMount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelArtilleryMount_MouseDown);
            // 
            // groupBoxTypeOfCar
            // 
            this.groupBoxTypeOfCar.Controls.Add(this.labelArmorCar);
            this.groupBoxTypeOfCar.Controls.Add(this.labelArtilleryMount);
            this.groupBoxTypeOfCar.Location = new System.Drawing.Point(26, 28);
            this.groupBoxTypeOfCar.Name = "groupBoxTypeOfCar";
            this.groupBoxTypeOfCar.Size = new System.Drawing.Size(200, 145);
            this.groupBoxTypeOfCar.TabIndex = 3;
            this.groupBoxTypeOfCar.TabStop = false;
            this.groupBoxTypeOfCar.Text = "Тип кузова";
            // 
            // panelArmorCar
            // 
            this.panelArmorCar.AllowDrop = true;
            this.panelArmorCar.Controls.Add(this.labelDopColor);
            this.panelArmorCar.Controls.Add(this.labelBaseColor);
            this.panelArmorCar.Controls.Add(this.pictureBoxArmorCar);
            this.panelArmorCar.Location = new System.Drawing.Point(232, 19);
            this.panelArmorCar.Name = "panelArmorCar";
            this.panelArmorCar.Size = new System.Drawing.Size(193, 218);
            this.panelArmorCar.TabIndex = 4;
            this.panelArmorCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelArmorCar_DragDrop);
            this.panelArmorCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelArmorCar_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BackColor = System.Drawing.SystemColors.Control;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(48, 174);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(100, 34);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BackColor = System.Drawing.SystemColors.Control;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(48, 142);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(100, 23);
            this.labelBaseColor.TabIndex = 0;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelBlack
            // 
            this.panelBlack.AllowDrop = true;
            this.panelBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBlack.Location = new System.Drawing.Point(15, 13);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(42, 42);
            this.panelBlack.TabIndex = 5;
            // 
            // panelGreen
            // 
            this.panelGreen.AllowDrop = true;
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelGreen.Location = new System.Drawing.Point(15, 61);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(42, 42);
            this.panelGreen.TabIndex = 6;
            // 
            // panelRed
            // 
            this.panelRed.AllowDrop = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(15, 109);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(42, 42);
            this.panelRed.TabIndex = 6;
            // 
            // panelGrey
            // 
            this.panelGrey.AllowDrop = true;
            this.panelGrey.BackColor = System.Drawing.Color.Silver;
            this.panelGrey.Location = new System.Drawing.Point(15, 157);
            this.panelGrey.Name = "panelGrey";
            this.panelGrey.Size = new System.Drawing.Size(42, 42);
            this.panelGrey.TabIndex = 6;
            // 
            // panelWhite
            // 
            this.panelWhite.AllowDrop = true;
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(96, 13);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(42, 42);
            this.panelWhite.TabIndex = 6;
            // 
            // panelBlue
            // 
            this.panelBlue.AllowDrop = true;
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(96, 61);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(42, 42);
            this.panelBlue.TabIndex = 6;
            // 
            // panelYellow
            // 
            this.panelYellow.AllowDrop = true;
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(96, 109);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(42, 42);
            this.panelYellow.TabIndex = 6;
            // 
            // panelPink
            // 
            this.panelPink.AllowDrop = true;
            this.panelPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelPink.Location = new System.Drawing.Point(96, 157);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(42, 42);
            this.panelPink.TabIndex = 6;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelGrey);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Location = new System.Drawing.Point(443, 15);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(156, 210);
            this.groupBoxColors.TabIndex = 7;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(74, 179);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(74, 208);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // GroupBoxGunType
            // 
            this.GroupBoxGunType.Controls.Add(this.labelGunsWithAngle);
            this.GroupBoxGunType.Controls.Add(this.labelGunsWithPattern);
            this.GroupBoxGunType.Controls.Add(this.labelSimpleGuns);
            this.GroupBoxGunType.Location = new System.Drawing.Point(619, 19);
            this.GroupBoxGunType.Name = "GroupBoxGunType";
            this.GroupBoxGunType.Size = new System.Drawing.Size(172, 140);
            this.GroupBoxGunType.TabIndex = 9;
            this.GroupBoxGunType.TabStop = false;
            this.GroupBoxGunType.Text = "Тип орудия";
            // 
            // labelGunsWithAngle
            // 
            this.labelGunsWithAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGunsWithAngle.Location = new System.Drawing.Point(13, 91);
            this.labelGunsWithAngle.Name = "labelGunsWithAngle";
            this.labelGunsWithAngle.Size = new System.Drawing.Size(146, 29);
            this.labelGunsWithAngle.TabIndex = 2;
            this.labelGunsWithAngle.Text = "Орудие под углом";
            this.labelGunsWithAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGunsWithAngle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelGunsWithAngle_MouseDown);
            // 
            // labelGunsWithPattern
            // 
            this.labelGunsWithPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGunsWithPattern.Location = new System.Drawing.Point(13, 56);
            this.labelGunsWithPattern.Name = "labelGunsWithPattern";
            this.labelGunsWithPattern.Size = new System.Drawing.Size(146, 29);
            this.labelGunsWithPattern.TabIndex = 1;
            this.labelGunsWithPattern.Text = "Орудие с рисунком";
            this.labelGunsWithPattern.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGunsWithPattern.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelGunsWithPattern_MouseDown);
            // 
            // labelSimpleGuns
            // 
            this.labelSimpleGuns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSimpleGuns.Location = new System.Drawing.Point(13, 16);
            this.labelSimpleGuns.Name = "labelSimpleGuns";
            this.labelSimpleGuns.Size = new System.Drawing.Size(146, 29);
            this.labelSimpleGuns.TabIndex = 0;
            this.labelSimpleGuns.Text = "Простое орудие";
            this.labelSimpleGuns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSimpleGuns.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSimpleGuns_MouseDown);
            // 
            // labelGunsType
            // 
            this.labelGunsType.AllowDrop = true;
            this.labelGunsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGunsType.Location = new System.Drawing.Point(626, 169);
            this.labelGunsType.Name = "labelGunsType";
            this.labelGunsType.Size = new System.Drawing.Size(165, 66);
            this.labelGunsType.TabIndex = 10;
            this.labelGunsType.Text = "Тип орудия";
            this.labelGunsType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGunsType.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelGunsType_DragDrop);
            this.labelGunsType.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelGunsType_DragEnter);
            // 
            // FormArmorCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 294);
            this.Controls.Add(this.labelGunsType);
            this.Controls.Add(this.GroupBoxGunType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.groupBoxTypeOfCar);
            this.Controls.Add(this.panelArmorCar);
            this.Name = "FormArmorCarConfig";
            this.Text = "FormArmorCarConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmorCar)).EndInit();
            this.groupBoxTypeOfCar.ResumeLayout(false);
            this.panelArmorCar.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.GroupBoxGunType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArmorCar;
        private System.Windows.Forms.Label labelArmorCar;
        private System.Windows.Forms.Label labelArtilleryMount;
        private System.Windows.Forms.GroupBox groupBoxTypeOfCar;
        private System.Windows.Forms.Panel panelArmorCar;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.GroupBox GroupBoxGunType;
        private System.Windows.Forms.Label labelGunsWithAngle;
        private System.Windows.Forms.Label labelGunsWithPattern;
        private System.Windows.Forms.Label labelSimpleGuns;
        private System.Windows.Forms.Label labelGunsType;
    }
}