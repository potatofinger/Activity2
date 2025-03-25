namespace Activity2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bato = new PictureBox();
            papel = new PictureBox();
            gunting = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            batoo = new Button();
            papell = new Button();
            guntingg = new Button();
            player = new PictureBox();
            computer = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            result = new Label();
            pscore = new Label();
            sscore = new Label();
            ((System.ComponentModel.ISupportInitialize)bato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)papel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gunting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computer).BeginInit();
            SuspendLayout();
            // 
            // bato
            // 
            bato.Image = Properties.Resources.rock;
            bato.Location = new Point(683, 275);
            bato.Name = "bato";
            bato.Size = new Size(105, 91);
            bato.SizeMode = PictureBoxSizeMode.StretchImage;
            bato.TabIndex = 0;
            bato.TabStop = false;
            bato.Click += bato_Click;
            // 
            // papel
            // 
            papel.Image = (Image)resources.GetObject("papel.Image");
            papel.Location = new Point(683, 139);
            papel.Name = "papel";
            papel.Size = new Size(105, 91);
            papel.SizeMode = PictureBoxSizeMode.StretchImage;
            papel.TabIndex = 1;
            papel.TabStop = false;
            // 
            // gunting
            // 
            gunting.Image = (Image)resources.GetObject("gunting.Image");
            gunting.Location = new Point(683, 12);
            gunting.Name = "gunting";
            gunting.Size = new Size(105, 91);
            gunting.SizeMode = PictureBoxSizeMode.StretchImage;
            gunting.TabIndex = 2;
            gunting.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(674, 412);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 3;
            label1.Text = "PICK YOUR FIGHTER";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // batoo
            // 
            batoo.Location = new Point(699, 372);
            batoo.Name = "batoo";
            batoo.Size = new Size(75, 23);
            batoo.TabIndex = 4;
            batoo.Text = "ROCK";
            batoo.UseVisualStyleBackColor = true;
            batoo.Click += batoo_Click;
            // 
            // papell
            // 
            papell.Location = new Point(699, 236);
            papell.Name = "papell";
            papell.Size = new Size(75, 23);
            papell.TabIndex = 5;
            papell.Text = "PAPER";
            papell.UseVisualStyleBackColor = true;
            papell.Click += papell_Click;
            // 
            // guntingg
            // 
            guntingg.Location = new Point(699, 109);
            guntingg.Name = "guntingg";
            guntingg.Size = new Size(75, 23);
            guntingg.TabIndex = 6;
            guntingg.Text = "SCICCOR";
            guntingg.UseVisualStyleBackColor = true;
            guntingg.Click += guntingg_Click;
            // 
            // player
            // 
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(123, 153);
            player.Name = "player";
            player.Size = new Size(105, 91);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 7;
            player.TabStop = false;
            // 
            // computer
            // 
            computer.Image = (Image)resources.GetObject("computer.Image");
            computer.Location = new Point(411, 153);
            computer.Name = "computer";
            computer.Size = new Size(105, 91);
            computer.SizeMode = PictureBoxSizeMode.StretchImage;
            computer.TabIndex = 8;
            computer.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 194);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 9;
            label2.Text = "VS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 290);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 10;
            label3.Text = "Player";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 290);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 11;
            label4.Text = "Computer";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(303, 290);
            result.Name = "result";
            result.Size = new Size(45, 15);
            result.TabIndex = 12;
            result.Text = "RESULT";
            // 
            // pscore
            // 
            pscore.AutoSize = true;
            pscore.Location = new Point(123, 109);
            pscore.Name = "pscore";
            pscore.Size = new Size(86, 15);
            pscore.TabIndex = 13;
            pscore.Text = "PLAYER SCORE";
            // 
            // sscore
            // 
            sscore.AutoSize = true;
            sscore.Location = new Point(413, 109);
            sscore.Name = "sscore";
            sscore.Size = new Size(108, 15);
            sscore.TabIndex = 14;
            sscore.Text = "COMPUTER SCORE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(sscore);
            Controls.Add(pscore);
            Controls.Add(result);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(computer);
            Controls.Add(player);
            Controls.Add(guntingg);
            Controls.Add(papell);
            Controls.Add(batoo);
            Controls.Add(label1);
            Controls.Add(gunting);
            Controls.Add(papel);
            Controls.Add(bato);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bato).EndInit();
            ((System.ComponentModel.ISupportInitialize)papel).EndInit();
            ((System.ComponentModel.ISupportInitialize)gunting).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)computer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bato;
        private PictureBox papel;
        private PictureBox gunting;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button batoo;
        private Button papell;
        private Button guntingg;
        private PictureBox player;
        private PictureBox computer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label result;
        private Label pscore;
        private Label sscore;
    }
}
