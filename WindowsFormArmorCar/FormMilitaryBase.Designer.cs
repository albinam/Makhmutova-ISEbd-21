﻿namespace WindowsFormArmorCar
{
    partial class FormMilitaryBase
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
            this.buttonSetArmorCar = new System.Windows.Forms.Button();
            this.buttonSetArtilleryMount = new System.Windows.Forms.Button();
            this.buttonTake = new System.Windows.Forms.Button();
            this.pictureBoxMilitaryBase = new System.Windows.Forms.PictureBox();
            this.pictureBoxTakeArmorCar = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelTakeCar = new System.Windows.Forms.Label();
            this.buttonSetAll = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMilitaryBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeArmorCar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetArmorCar
            // 
            this.buttonSetArmorCar.Location = new System.Drawing.Point(657, 2);
            this.buttonSetArmorCar.Name = "buttonSetArmorCar";
            this.buttonSetArmorCar.Size = new System.Drawing.Size(123, 62);
            this.buttonSetArmorCar.TabIndex = 0;
            this.buttonSetArmorCar.Text = "Припарковать бронированную машину";
            this.buttonSetArmorCar.UseVisualStyleBackColor = true;
            this.buttonSetArmorCar.Click += new System.EventHandler(this.buttonSetArmorCar_Click);
            // 
            // buttonSetArtilleryMount
            // 
            this.buttonSetArtilleryMount.Location = new System.Drawing.Point(658, 70);
            this.buttonSetArtilleryMount.Name = "buttonSetArtilleryMount";
            this.buttonSetArtilleryMount.Size = new System.Drawing.Size(122, 75);
            this.buttonSetArtilleryMount.TabIndex = 1;
            this.buttonSetArtilleryMount.Text = "Припарковать самоходную артиллерейскую установку";
            this.buttonSetArtilleryMount.UseVisualStyleBackColor = true;
            this.buttonSetArtilleryMount.Click += new System.EventHandler(this.buttonSetArtilleryMount_Click);
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(657, 332);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(122, 27);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // pictureBoxMilitaryBase
            // 
            this.pictureBoxMilitaryBase.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxMilitaryBase.Name = "pictureBoxMilitaryBase";
            this.pictureBoxMilitaryBase.Size = new System.Drawing.Size(649, 446);
            this.pictureBoxMilitaryBase.TabIndex = 3;
            this.pictureBoxMilitaryBase.TabStop = false;
            // 
            // pictureBoxTakeArmorCar
            // 
            this.pictureBoxTakeArmorCar.Location = new System.Drawing.Point(659, 365);
            this.pictureBoxTakeArmorCar.Name = "pictureBoxTakeArmorCar";
            this.pictureBoxTakeArmorCar.Size = new System.Drawing.Size(130, 82);
            this.pictureBoxTakeArmorCar.TabIndex = 4;
            this.pictureBoxTakeArmorCar.TabStop = false;
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(736, 297);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBoxPlace.TabIndex = 5;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(676, 300);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(39, 13);
            this.labelPlace.TabIndex = 6;
            this.labelPlace.Text = "Место";
            // 
            // labelTakeCar
            // 
            this.labelTakeCar.AutoSize = true;
            this.labelTakeCar.Location = new System.Drawing.Point(676, 269);
            this.labelTakeCar.Name = "labelTakeCar";
            this.labelTakeCar.Size = new System.Drawing.Size(91, 13);
            this.labelTakeCar.TabIndex = 7;
            this.labelTakeCar.Text = "Забрать машину";
            // 
            // buttonSetAll
            // 
            this.buttonSetAll.Location = new System.Drawing.Point(657, 151);
            this.buttonSetAll.Name = "buttonSetAll";
            this.buttonSetAll.Size = new System.Drawing.Size(121, 38);
            this.buttonSetAll.TabIndex = 8;
            this.buttonSetAll.Text = "Заполнить всю парковку";
            this.buttonSetAll.UseVisualStyleBackColor = true;
            this.buttonSetAll.Click += new System.EventHandler(this.buttonSetAll_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(662, 199);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(115, 34);
            this.buttonRemoveAll.TabIndex = 9;
            this.buttonRemoveAll.Text = "Очистить парковку";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // FormMilitaryBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonSetAll);
            this.Controls.Add(this.labelTakeCar);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.maskedTextBoxPlace);
            this.Controls.Add(this.pictureBoxTakeArmorCar);
            this.Controls.Add(this.pictureBoxMilitaryBase);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.buttonSetArtilleryMount);
            this.Controls.Add(this.buttonSetArmorCar);
            this.Name = "FormMilitaryBase";
            this.Text = "FormMilitaryBase";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMilitaryBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeArmorCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetArmorCar;
        private System.Windows.Forms.Button buttonSetArtilleryMount;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.PictureBox pictureBoxMilitaryBase;
        private System.Windows.Forms.PictureBox pictureBoxTakeArmorCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelTakeCar;
        private System.Windows.Forms.Button buttonSetAll;
        private System.Windows.Forms.Button buttonRemoveAll;
    }
}