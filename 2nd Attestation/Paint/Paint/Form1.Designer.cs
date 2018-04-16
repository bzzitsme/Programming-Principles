namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button_Open = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.DarkBlue = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.DarkViolet = new System.Windows.Forms.Button();
            this.Aquamarine = new System.Windows.Forms.Button();
            this.Aqua = new System.Windows.Forms.Button();
            this.Azure = new System.Windows.Forms.Button();
            this.Brown = new System.Windows.Forms.Button();
            this.IndianRed = new System.Windows.Forms.Button();
            this.GreenYellow = new System.Windows.Forms.Button();
            this.Gold = new System.Windows.Forms.Button();
            this.AliceBlue = new System.Windows.Forms.Button();
            this.DarkGreen = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Cyan = new System.Windows.Forms.Button();
            this.DarkRed = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Button_Erase = new System.Windows.Forms.Button();
            this.Button_Line = new System.Windows.Forms.Button();
            this.Button_Ellipse = new System.Windows.Forms.Button();
            this.Button_Fill = new System.Windows.Forms.Button();
            this.Button_Rectangle = new System.Windows.Forms.Button();
            this.Button_Pen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Open
            // 
            this.Button_Open.Location = new System.Drawing.Point(268, -2);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(55, 55);
            this.Button_Open.TabIndex = 5;
            this.Button_Open.Text = "Open";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(268, 47);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(55, 55);
            this.Button_Save.TabIndex = 10;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.Location = new System.Drawing.Point(377, 8);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(252, 45);
            this.TrackBar.TabIndex = 11;
            this.TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(464, 59);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(104, 43);
            this.Button_Clear.TabIndex = 36;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Paint.Properties.Resources.Coloroo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(778, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Green
            // 
            this.Green.Image = global::Paint.Properties.Resources.green;
            this.Green.Location = new System.Drawing.Point(887, 79);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(30, 30);
            this.Green.TabIndex = 35;
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Button_Colour);
            // 
            // DarkBlue
            // 
            this.DarkBlue.Image = global::Paint.Properties.Resources.darkblue;
            this.DarkBlue.Location = new System.Drawing.Point(959, 79);
            this.DarkBlue.Name = "DarkBlue";
            this.DarkBlue.Size = new System.Drawing.Size(30, 30);
            this.DarkBlue.TabIndex = 34;
            this.DarkBlue.UseVisualStyleBackColor = true;
            this.DarkBlue.Click += new System.EventHandler(this.Button_Colour);
            // 
            // Black
            // 
            this.Black.Image = global::Paint.Properties.Resources.black;
            this.Black.Location = new System.Drawing.Point(1031, 79);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(30, 30);
            this.Black.TabIndex = 33;
            this.Black.UseVisualStyleBackColor = true;
            this.Black.Click += new System.EventHandler(this.Button_Colour);
            // 
            // DarkViolet
            // 
            this.DarkViolet.Image = global::Paint.Properties.Resources.darkviolet;
            this.DarkViolet.Location = new System.Drawing.Point(1067, 10);
            this.DarkViolet.Name = "DarkViolet";
            this.DarkViolet.Size = new System.Drawing.Size(30, 30);
            this.DarkViolet.TabIndex = 32;
            this.DarkViolet.UseVisualStyleBackColor = true;
            this.DarkViolet.Click += new System.EventHandler(this.Button_Colour);
            // 
            // Aquamarine
            // 
            this.Aquamarine.Image = global::Paint.Properties.Resources.aquamarine;
            this.Aquamarine.Location = new System.Drawing.Point(995, 43);
            this.Aquamarine.Name = "Aquamarine";
            this.Aquamarine.Size = new System.Drawing.Size(30, 30);
            this.Aquamarine.TabIndex = 31;
            this.Aquamarine.UseVisualStyleBackColor = true;
            this.Aquamarine.Click += new System.EventHandler(this.Button_Colour);
            // 
            // Aqua
            // 
            this.Aqua.Image = global::Paint.Properties.Resources.aqua;
            this.Aqua.Location = new System.Drawing.Point(1031, 10);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(30, 30);
            this.Aqua.TabIndex = 30;
            this.Aqua.UseVisualStyleBackColor = true;
            this.Aqua.Click += new System.EventHandler(this.Button_Colour);
            // 
            // Azure
            // 
            this.Azure.Image = global::Paint.Properties.Resources.azure;
            this.Azure.Location = new System.Drawing.Point(1067, 79);
            this.Azure.Name = "Azure";
            this.Azure.Size = new System.Drawing.Size(30, 30);
            this.Azure.TabIndex = 29;
            this.Azure.UseVisualStyleBackColor = true;
            this.Azure.Click += new System.EventHandler(this.Button_Colour);
            // 
            // Brown
            // 
            this.Brown.Image = global::Paint.Properties.Resources.Brown;
            this.Brown.Location = new System.Drawing.Point(995, 79);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(30, 30);
            this.Brown.TabIndex = 28;
            this.Brown.UseVisualStyleBackColor = true;
            this.Brown.Click += new System.EventHandler(this.Button_Colour);
            // 
            // IndianRed
            // 
            this.IndianRed.Image = global::Paint.Properties.Resources.IndianRed;
            this.IndianRed.Location = new System.Drawing.Point(1031, 43);
            this.IndianRed.Name = "IndianRed";
            this.IndianRed.Size = new System.Drawing.Size(30, 30);
            this.IndianRed.TabIndex = 21;
            this.IndianRed.UseVisualStyleBackColor = true;
            this.IndianRed.Click += new System.EventHandler(this.Button_Colour);
            // 
            // GreenYellow
            // 
            this.GreenYellow.Image = global::Paint.Properties.Resources.greenyellow;
            this.GreenYellow.Location = new System.Drawing.Point(959, 12);
            this.GreenYellow.Name = "GreenYellow";
            this.GreenYellow.Size = new System.Drawing.Size(30, 30);
            this.GreenYellow.TabIndex = 20;
            this.GreenYellow.UseVisualStyleBackColor = true;
            this.GreenYellow.Click += new System.EventHandler(this.Button_Colour);
            // 
            // Gold
            // 
            this.Gold.Image = global::Paint.Properties.Resources.Gold;
            this.Gold.Location = new System.Drawing.Point(1067, 43);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(30, 30);
            this.Gold.TabIndex = 19;
            this.Gold.UseVisualStyleBackColor = true;
            this.Gold.Click += new System.EventHandler(this.Button_Colour);
            // 
            // AliceBlue
            // 
            this.AliceBlue.Image = global::Paint.Properties.Resources.Aliceblue;
            this.AliceBlue.Location = new System.Drawing.Point(995, 10);
            this.AliceBlue.Name = "AliceBlue";
            this.AliceBlue.Size = new System.Drawing.Size(30, 30);
            this.AliceBlue.TabIndex = 18;
            this.AliceBlue.UseVisualStyleBackColor = true;
            this.AliceBlue.Click += new System.EventHandler(this.Button_Colour);
            // 
            // DarkGreen
            // 
            this.DarkGreen.Image = global::Paint.Properties.Resources.darkgreen;
            this.DarkGreen.Location = new System.Drawing.Point(959, 43);
            this.DarkGreen.Name = "DarkGreen";
            this.DarkGreen.Size = new System.Drawing.Size(30, 30);
            this.DarkGreen.TabIndex = 17;
            this.DarkGreen.UseVisualStyleBackColor = true;
            this.DarkGreen.Click += new System.EventHandler(this.Button_Colour);
            // 
            // Red
            // 
            this.Red.Image = global::Paint.Properties.Resources.red;
            this.Red.Location = new System.Drawing.Point(923, 79);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(30, 30);
            this.Red.TabIndex = 16;
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Button_Colour);
            // 
            // Blue
            // 
            this.Blue.Image = global::Paint.Properties.Resources.blue;
            this.Blue.Location = new System.Drawing.Point(923, 43);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(30, 30);
            this.Blue.TabIndex = 15;
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.Click += new System.EventHandler(this.Button_Colour);
            // 
            // Cyan
            // 
            this.Cyan.Image = global::Paint.Properties.Resources.cyan;
            this.Cyan.Location = new System.Drawing.Point(923, 10);
            this.Cyan.Name = "Cyan";
            this.Cyan.Size = new System.Drawing.Size(30, 30);
            this.Cyan.TabIndex = 14;
            this.Cyan.UseVisualStyleBackColor = true;
            this.Cyan.Click += new System.EventHandler(this.Button_Colour);
            // 
            // DarkRed
            // 
            this.DarkRed.Image = global::Paint.Properties.Resources.darkred;
            this.DarkRed.Location = new System.Drawing.Point(887, 43);
            this.DarkRed.Name = "DarkRed";
            this.DarkRed.Size = new System.Drawing.Size(30, 30);
            this.DarkRed.TabIndex = 13;
            this.DarkRed.UseVisualStyleBackColor = true;
            this.DarkRed.Click += new System.EventHandler(this.Button_Colour);
            // 
            // White
            // 
            this.White.Image = global::Paint.Properties.Resources.white;
            this.White.Location = new System.Drawing.Point(887, 10);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(30, 30);
            this.White.TabIndex = 12;
            this.White.UseVisualStyleBackColor = true;
            this.White.Click += new System.EventHandler(this.Button_Colour);
            // 
            // Button_Erase
            // 
            this.Button_Erase.BackgroundImage = global::Paint.Properties.Resources.Erase;
            this.Button_Erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Erase.Location = new System.Drawing.Point(144, 47);
            this.Button_Erase.Name = "Button_Erase";
            this.Button_Erase.Size = new System.Drawing.Size(55, 55);
            this.Button_Erase.TabIndex = 8;
            this.Button_Erase.UseVisualStyleBackColor = true;
            this.Button_Erase.Click += new System.EventHandler(this.Button_Erase_Click);
            // 
            // Button_Line
            // 
            this.Button_Line.BackgroundImage = global::Paint.Properties.Resources.Line;
            this.Button_Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Line.Location = new System.Drawing.Point(83, 47);
            this.Button_Line.Name = "Button_Line";
            this.Button_Line.Size = new System.Drawing.Size(55, 55);
            this.Button_Line.TabIndex = 7;
            this.Button_Line.UseVisualStyleBackColor = true;
            this.Button_Line.Click += new System.EventHandler(this.Button_Line_Click);
            // 
            // Button_Ellipse
            // 
            this.Button_Ellipse.BackgroundImage = global::Paint.Properties.Resources.Ellipse;
            this.Button_Ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Ellipse.Location = new System.Drawing.Point(22, 47);
            this.Button_Ellipse.Name = "Button_Ellipse";
            this.Button_Ellipse.Size = new System.Drawing.Size(55, 55);
            this.Button_Ellipse.TabIndex = 6;
            this.Button_Ellipse.UseVisualStyleBackColor = true;
            this.Button_Ellipse.Click += new System.EventHandler(this.Button_Ellipse_Click);
            // 
            // Button_Fill
            // 
            this.Button_Fill.BackgroundImage = global::Paint.Properties.Resources.Fill;
            this.Button_Fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Fill.Location = new System.Drawing.Point(144, -2);
            this.Button_Fill.Name = "Button_Fill";
            this.Button_Fill.Size = new System.Drawing.Size(55, 55);
            this.Button_Fill.TabIndex = 3;
            this.Button_Fill.UseVisualStyleBackColor = true;
            this.Button_Fill.Click += new System.EventHandler(this.Button_Fill_Click);
            // 
            // Button_Rectangle
            // 
            this.Button_Rectangle.BackgroundImage = global::Paint.Properties.Resources.rectanglle;
            this.Button_Rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Rectangle.Location = new System.Drawing.Point(83, -2);
            this.Button_Rectangle.Name = "Button_Rectangle";
            this.Button_Rectangle.Size = new System.Drawing.Size(55, 55);
            this.Button_Rectangle.TabIndex = 2;
            this.Button_Rectangle.UseVisualStyleBackColor = true;
            this.Button_Rectangle.Click += new System.EventHandler(this.Button_Rectangle_Click);
            // 
            // Button_Pen
            // 
            this.Button_Pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Pen.BackgroundImage")));
            this.Button_Pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Pen.Location = new System.Drawing.Point(22, -2);
            this.Button_Pen.Name = "Button_Pen";
            this.Button_Pen.Size = new System.Drawing.Size(55, 55);
            this.Button_Pen.TabIndex = 1;
            this.Button_Pen.UseVisualStyleBackColor = true;
            this.Button_Pen.Click += new System.EventHandler(this.Button_Pen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1217, 488);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 67);
            this.button2.TabIndex = 38;
            this.button2.Text = "Triangle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paint.Properties.Resources.itachi_uchiha_theme_sz3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 609);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.DarkBlue);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.DarkViolet);
            this.Controls.Add(this.Aquamarine);
            this.Controls.Add(this.Aqua);
            this.Controls.Add(this.Azure);
            this.Controls.Add(this.Brown);
            this.Controls.Add(this.IndianRed);
            this.Controls.Add(this.GreenYellow);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.AliceBlue);
            this.Controls.Add(this.DarkGreen);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Cyan);
            this.Controls.Add(this.DarkRed);
            this.Controls.Add(this.White);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Erase);
            this.Controls.Add(this.Button_Line);
            this.Controls.Add(this.Button_Ellipse);
            this.Controls.Add(this.Button_Open);
            this.Controls.Add(this.Button_Fill);
            this.Controls.Add(this.Button_Rectangle);
            this.Controls.Add(this.Button_Pen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Pen;
        private System.Windows.Forms.Button Button_Rectangle;
        private System.Windows.Forms.Button Button_Fill;
        private System.Windows.Forms.Button Button_Open;
        private System.Windows.Forms.Button Button_Ellipse;
        private System.Windows.Forms.Button Button_Line;
        private System.Windows.Forms.Button Button_Erase;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button DarkRed;
        private System.Windows.Forms.Button Cyan;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Gold;
        private System.Windows.Forms.Button AliceBlue;
        private System.Windows.Forms.Button DarkGreen;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button IndianRed;
        private System.Windows.Forms.Button GreenYellow;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button DarkBlue;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button DarkViolet;
        private System.Windows.Forms.Button Aquamarine;
        private System.Windows.Forms.Button Aqua;
        private System.Windows.Forms.Button Azure;
        private System.Windows.Forms.Button Brown;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}

