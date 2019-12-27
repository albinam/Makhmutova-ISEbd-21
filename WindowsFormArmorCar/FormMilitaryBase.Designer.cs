namespace WindowsFormArmorCar
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
            this.buttonTake = new System.Windows.Forms.Button();
            this.pictureBoxMilitaryBase = new System.Windows.Forms.PictureBox();
            this.pictureBoxTakeArmorCar = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelTakeCar = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.labelLevels = new System.Windows.Forms.Label();
            this.buttonSetArmorCar = new System.Windows.Forms.Button();
            this.menuStripMilitaryBase = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogMilitaryBase = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMilitaryBase = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMilitaryBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeArmorCar)).BeginInit();
            this.menuStripMilitaryBase.SuspendLayout();
            this.SuspendLayout();
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
            this.pictureBoxMilitaryBase.Location = new System.Drawing.Point(2, 27);
            this.pictureBoxMilitaryBase.Name = "pictureBoxMilitaryBase";
            this.pictureBoxMilitaryBase.Size = new System.Drawing.Size(649, 421);
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
            this.labelTakeCar.Location = new System.Drawing.Point(676, 281);
            this.labelTakeCar.Name = "labelTakeCar";
            this.labelTakeCar.Size = new System.Drawing.Size(91, 13);
            this.labelTakeCar.TabIndex = 7;
            this.labelTakeCar.Text = "Забрать машину";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(662, 34);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 95);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // labelLevels
            // 
            this.labelLevels.AutoSize = true;
            this.labelLevels.Location = new System.Drawing.Point(697, 11);
            this.labelLevels.Name = "labelLevels";
            this.labelLevels.Size = new System.Drawing.Size(45, 13);
            this.labelLevels.TabIndex = 9;
            this.labelLevels.Text = "Уровни";
            // 
            // buttonSetArmorCar
            // 
            this.buttonSetArmorCar.Location = new System.Drawing.Point(669, 153);
            this.buttonSetArmorCar.Name = "buttonSetArmorCar";
            this.buttonSetArmorCar.Size = new System.Drawing.Size(108, 50);
            this.buttonSetArmorCar.TabIndex = 10;
            this.buttonSetArmorCar.Text = "Заказать бронированную машину";
            this.buttonSetArmorCar.UseVisualStyleBackColor = true;
            this.buttonSetArmorCar.Click += new System.EventHandler(this.buttonSetArmorCar_Click);
            // 
            // menuStripMilitaryBase
            // 
            this.menuStripMilitaryBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile});
            this.menuStripMilitaryBase.Location = new System.Drawing.Point(0, 0);
            this.menuStripMilitaryBase.Name = "menuStripMilitaryBase";
            this.menuStripMilitaryBase.Size = new System.Drawing.Size(800, 24);
            this.menuStripMilitaryBase.TabIndex = 11;
            this.menuStripMilitaryBase.Text = "menuStripMilitaryBase";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialogMilitaryBase
            // 
            this.openFileDialogMilitaryBase.FileName = "openFileDialogMilitaryBase";
            this.openFileDialogMilitaryBase.Filter = "txt file | *.txt";
            // 
            // saveFileDialogMilitaryBase
            // 
            this.saveFileDialogMilitaryBase.Filter = "txt file | *.txt";
            // 
            // FormMilitaryBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLevels);
            this.Controls.Add(this.menuStripMilitaryBase);
            this.Controls.Add(this.buttonSetArmorCar);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.labelTakeCar);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.maskedTextBoxPlace);
            this.Controls.Add(this.pictureBoxTakeArmorCar);
            this.Controls.Add(this.pictureBoxMilitaryBase);
            this.Controls.Add(this.buttonTake);
            this.MainMenuStrip = this.menuStripMilitaryBase;
            this.Name = "FormMilitaryBase";
            this.Text = "FormMilitaryBase";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMilitaryBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeArmorCar)).EndInit();
            this.menuStripMilitaryBase.ResumeLayout(false);
            this.menuStripMilitaryBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.PictureBox pictureBoxMilitaryBase;
        private System.Windows.Forms.PictureBox pictureBoxTakeArmorCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelTakeCar;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Label labelLevels;
        private System.Windows.Forms.Button buttonSetArmorCar;
        private System.Windows.Forms.MenuStrip menuStripMilitaryBase;
        private System.Windows.Forms.OpenFileDialog openFileDialogMilitaryBase;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMilitaryBase;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
    }
}