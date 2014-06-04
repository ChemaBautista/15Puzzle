namespace Puzzle
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heuristicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manhattanDistanceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.misplacedTilesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.gamePanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePanel.BackColor = System.Drawing.Color.White;
            this.gamePanel.Controls.Add(this.button15);
            this.gamePanel.Controls.Add(this.button14);
            this.gamePanel.Controls.Add(this.button13);
            this.gamePanel.Controls.Add(this.button12);
            this.gamePanel.Controls.Add(this.button11);
            this.gamePanel.Controls.Add(this.button10);
            this.gamePanel.Controls.Add(this.button9);
            this.gamePanel.Controls.Add(this.button16);
            this.gamePanel.Controls.Add(this.button7);
            this.gamePanel.Controls.Add(this.button8);
            this.gamePanel.Controls.Add(this.button6);
            this.gamePanel.Controls.Add(this.button5);
            this.gamePanel.Controls.Add(this.button3);
            this.gamePanel.Controls.Add(this.button2);
            this.gamePanel.Controls.Add(this.button1);
            this.gamePanel.Controls.Add(this.button4);
            this.gamePanel.Location = new System.Drawing.Point(0, 25);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(360, 370);
            this.gamePanel.TabIndex = 0;
            // 
            // button16
            // 
            this.button16.AllowDrop = true;
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button16.Location = new System.Drawing.Point(276, 285);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(70, 70);
            this.button16.TabIndex = 8;
            this.button16.Tag = "8";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button16.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button7
            // 
            this.button7.AllowDrop = true;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(191, 104);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 7;
            this.button7.Tag = "6";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button7.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button8
            // 
            this.button8.AllowDrop = true;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(276, 104);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 6;
            this.button8.Tag = "7";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button8.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button6
            // 
            this.button6.AllowDrop = true;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(101, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 5;
            this.button6.Tag = "5";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button6.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button5
            // 
            this.button5.AllowDrop = true;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(17, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 4;
            this.button5.Tag = "4";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button5.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(191, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 3;
            this.button3.Tag = "2";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(101, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 2;
            this.button2.Tag = "1";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(17, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 1;
            this.button1.Tag = "0";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(276, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 0;
            this.button4.Tag = "3";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button4.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.Blue;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(238, 412);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 26);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Solución";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShuffle.BackColor = System.Drawing.Color.Blue;
            this.buttonShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShuffle.ForeColor = System.Drawing.Color.White;
            this.buttonShuffle.Location = new System.Drawing.Point(156, 412);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(76, 26);
            this.buttonShuffle.TabIndex = 2;
            this.buttonShuffle.Text = "Shuffle";
            this.buttonShuffle.UseVisualStyleBackColor = false;
            this.buttonShuffle.Visible = false;
            this.buttonShuffle.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 443);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(360, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.Name = "progressBar";
            this.progressBar.Padding = new System.Windows.Forms.Padding(1, 1, 2, 1);
            this.progressBar.Size = new System.Drawing.Size(70, 16);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.heuristicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shuffleToolStripMenuItem,
            this.solveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "&Archivo";
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shuffleToolStripMenuItem.Text = "Shuffle";
            this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.ShuffleMenu_Click);
            // 
            // solveToolStripMenuItem
            // 
            this.solveToolStripMenuItem.Name = "solveToolStripMenuItem";
            this.solveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.solveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.solveToolStripMenuItem.Text = "Solución";
            this.solveToolStripMenuItem.Click += new System.EventHandler(this.SolveMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // heuristicToolStripMenuItem
            // 
            this.heuristicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manhattanDistanceMenu,
            this.misplacedTilesMenu});
            this.heuristicToolStripMenuItem.Name = "heuristicToolStripMenuItem";
            this.heuristicToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.heuristicToolStripMenuItem.Text = "&Soluciones";
            // 
            // manhattanDistanceMenu
            // 
            this.manhattanDistanceMenu.Name = "manhattanDistanceMenu";
            this.manhattanDistanceMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.manhattanDistanceMenu.Size = new System.Drawing.Size(223, 22);
            this.manhattanDistanceMenu.Text = "Manhattan Distance";
            this.manhattanDistanceMenu.Click += new System.EventHandler(this.ManhattanDistanceMenu_Click);
            // 
            // misplacedTilesMenu
            // 
            this.misplacedTilesMenu.Name = "misplacedTilesMenu";
            this.misplacedTilesMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.misplacedTilesMenu.Size = new System.Drawing.Size(223, 22);
            this.misplacedTilesMenu.Text = "Misplaced Tiles";
            this.misplacedTilesMenu.Click += new System.EventHandler(this.MisplacedTilesMenu_Click);
            // 
            // button9
            // 
            this.button9.AllowDrop = true;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(17, 191);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 9;
            this.button9.Tag = "7";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button9.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button10
            // 
            this.button10.AllowDrop = true;
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button10.Location = new System.Drawing.Point(101, 191);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 70);
            this.button10.TabIndex = 10;
            this.button10.Tag = "7";
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button10.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button11
            // 
            this.button11.AllowDrop = true;
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button11.Location = new System.Drawing.Point(191, 191);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 70);
            this.button11.TabIndex = 11;
            this.button11.Tag = "7";
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button11.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button12
            // 
            this.button12.AllowDrop = true;
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button12.Location = new System.Drawing.Point(276, 191);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 70);
            this.button12.TabIndex = 12;
            this.button12.Tag = "7";
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button12.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button13
            // 
            this.button13.AllowDrop = true;
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button13.Location = new System.Drawing.Point(17, 285);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(70, 70);
            this.button13.TabIndex = 13;
            this.button13.Tag = "7";
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button13.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button14
            // 
            this.button14.AllowDrop = true;
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button14.Location = new System.Drawing.Point(101, 285);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(70, 70);
            this.button14.TabIndex = 14;
            this.button14.Tag = "7";
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button14.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button15
            // 
            this.button15.AllowDrop = true;
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button15.Location = new System.Drawing.Point(191, 285);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(70, 70);
            this.button15.TabIndex = 15;
            this.button15.Tag = "7";
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button15.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(360, 465);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonShuffle);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.gamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Puzzle Numerico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gamePanel.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heuristicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manhattanDistanceMenu;
        private System.Windows.Forms.ToolStripMenuItem misplacedTilesMenu;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
    }
}

