namespace Personal_Video_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lCount6 = new System.Windows.Forms.Label();
            this.lCount5 = new System.Windows.Forms.Label();
            this.lCount4 = new System.Windows.Forms.Label();
            this.lCount3 = new System.Windows.Forms.Label();
            this.lCount2 = new System.Windows.Forms.Label();
            this.lCount1 = new System.Windows.Forms.Label();
            this.lCount0 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PlayerPage = new System.Windows.Forms.TabPage();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.SearchPage = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button10 = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.TextBox();
            this.UploadPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Categori = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tags = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.TrackBar();
            this.Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.DelPage = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AboutPage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.PlayerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SearchPage.SuspendLayout();
            this.UploadPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rating)).BeginInit();
            this.DelPage.SuspendLayout();
            this.AboutPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.MainPage);
            this.tabControl1.Controls.Add(this.PlayerPage);
            this.tabControl1.Controls.Add(this.SearchPage);
            this.tabControl1.Controls.Add(this.UploadPage);
            this.tabControl1.Controls.Add(this.DelPage);
            this.tabControl1.Controls.Add(this.AboutPage);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.SystemColors.Control;
            this.MainPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPage.BackgroundImage")));
            this.MainPage.Controls.Add(this.button13);
            this.MainPage.Controls.Add(this.button12);
            this.MainPage.Controls.Add(this.button11);
            this.MainPage.Controls.Add(this.label11);
            this.MainPage.Controls.Add(this.lCount6);
            this.MainPage.Controls.Add(this.lCount5);
            this.MainPage.Controls.Add(this.lCount4);
            this.MainPage.Controls.Add(this.lCount3);
            this.MainPage.Controls.Add(this.lCount2);
            this.MainPage.Controls.Add(this.lCount1);
            this.MainPage.Controls.Add(this.lCount0);
            this.MainPage.Controls.Add(this.button9);
            this.MainPage.Controls.Add(this.button8);
            this.MainPage.Controls.Add(this.button7);
            this.MainPage.Controls.Add(this.button6);
            this.MainPage.Controls.Add(this.button5);
            this.MainPage.Controls.Add(this.button4);
            this.MainPage.Controls.Add(this.button3);
            this.MainPage.Controls.Add(this.label5);
            this.MainPage.Location = new System.Drawing.Point(4, 27);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(710, 396);
            this.MainPage.TabIndex = 1;
            this.MainPage.Text = "Home";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(383, 308);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(263, 44);
            this.button13.TabIndex = 18;
            this.button13.Text = "Most Watched List";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(383, 217);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(263, 44);
            this.button12.TabIndex = 17;
            this.button12.Text = "History";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(383, 127);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(263, 44);
            this.button11.TabIndex = 16;
            this.button11.Text = "Recently Watched";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(472, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Quick List";
            // 
            // lCount6
            // 
            this.lCount6.AutoSize = true;
            this.lCount6.BackColor = System.Drawing.Color.Transparent;
            this.lCount6.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount6.ForeColor = System.Drawing.Color.Red;
            this.lCount6.Location = new System.Drawing.Point(275, 358);
            this.lCount6.Name = "lCount6";
            this.lCount6.Size = new System.Drawing.Size(0, 13);
            this.lCount6.TabIndex = 14;
            // 
            // lCount5
            // 
            this.lCount5.AutoSize = true;
            this.lCount5.BackColor = System.Drawing.Color.Transparent;
            this.lCount5.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount5.ForeColor = System.Drawing.Color.Red;
            this.lCount5.Location = new System.Drawing.Point(275, 308);
            this.lCount5.Name = "lCount5";
            this.lCount5.Size = new System.Drawing.Size(0, 13);
            this.lCount5.TabIndex = 13;
            // 
            // lCount4
            // 
            this.lCount4.AutoSize = true;
            this.lCount4.BackColor = System.Drawing.Color.Transparent;
            this.lCount4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount4.ForeColor = System.Drawing.Color.Red;
            this.lCount4.Location = new System.Drawing.Point(275, 258);
            this.lCount4.Name = "lCount4";
            this.lCount4.Size = new System.Drawing.Size(0, 13);
            this.lCount4.TabIndex = 12;
            // 
            // lCount3
            // 
            this.lCount3.AutoSize = true;
            this.lCount3.BackColor = System.Drawing.Color.Transparent;
            this.lCount3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount3.ForeColor = System.Drawing.Color.Red;
            this.lCount3.Location = new System.Drawing.Point(275, 208);
            this.lCount3.Name = "lCount3";
            this.lCount3.Size = new System.Drawing.Size(0, 13);
            this.lCount3.TabIndex = 11;
            // 
            // lCount2
            // 
            this.lCount2.AutoSize = true;
            this.lCount2.BackColor = System.Drawing.Color.Transparent;
            this.lCount2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount2.ForeColor = System.Drawing.Color.Red;
            this.lCount2.Location = new System.Drawing.Point(275, 158);
            this.lCount2.Name = "lCount2";
            this.lCount2.Size = new System.Drawing.Size(0, 13);
            this.lCount2.TabIndex = 10;
            // 
            // lCount1
            // 
            this.lCount1.AutoSize = true;
            this.lCount1.BackColor = System.Drawing.Color.Transparent;
            this.lCount1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount1.ForeColor = System.Drawing.Color.Red;
            this.lCount1.Location = new System.Drawing.Point(275, 108);
            this.lCount1.Name = "lCount1";
            this.lCount1.Size = new System.Drawing.Size(0, 13);
            this.lCount1.TabIndex = 9;
            // 
            // lCount0
            // 
            this.lCount0.AutoSize = true;
            this.lCount0.BackColor = System.Drawing.Color.Transparent;
            this.lCount0.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount0.ForeColor = System.Drawing.Color.Red;
            this.lCount0.Location = new System.Drawing.Point(275, 58);
            this.lCount0.Name = "lCount0";
            this.lCount0.Size = new System.Drawing.Size(0, 13);
            this.lCount0.TabIndex = 8;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(6, 343);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(263, 44);
            this.button9.TabIndex = 7;
            this.button9.Text = "Misc.";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(6, 293);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(263, 44);
            this.button8.TabIndex = 6;
            this.button8.Text = "Sports";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(6, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(263, 44);
            this.button7.TabIndex = 5;
            this.button7.Text = "Music";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(6, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(263, 44);
            this.button6.TabIndex = 4;
            this.button6.Text = "Documentary";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(6, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 44);
            this.button5.TabIndex = 3;
            this.button5.Text = "Horror";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(6, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(263, 44);
            this.button4.TabIndex = 2;
            this.button4.Text = "Comedy";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(6, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "Animation";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Categories";
            // 
            // PlayerPage
            // 
            this.PlayerPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayerPage.BackgroundImage")));
            this.PlayerPage.Controls.Add(this.Player);
            this.PlayerPage.Location = new System.Drawing.Point(4, 27);
            this.PlayerPage.Name = "PlayerPage";
            this.PlayerPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerPage.Size = new System.Drawing.Size(710, 396);
            this.PlayerPage.TabIndex = 3;
            this.PlayerPage.Text = "Player";
            this.PlayerPage.UseVisualStyleBackColor = true;
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(6, 6);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(695, 389);
            this.Player.TabIndex = 0;
            // 
            // SearchPage
            // 
            this.SearchPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchPage.BackgroundImage")));
            this.SearchPage.Controls.Add(this.listView1);
            this.SearchPage.Controls.Add(this.button10);
            this.SearchPage.Controls.Add(this.bSearch);
            this.SearchPage.Location = new System.Drawing.Point(4, 27);
            this.SearchPage.Name = "SearchPage";
            this.SearchPage.Size = new System.Drawing.Size(710, 396);
            this.SearchPage.TabIndex = 2;
            this.SearchPage.Text = "Search";
            this.SearchPage.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnDesc,
            this.columnRating,
            this.columnDuration,
            this.columnPath,
            this.columnID});
            this.listView1.Location = new System.Drawing.Point(0, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(709, 361);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 210;
            // 
            // columnDesc
            // 
            this.columnDesc.Text = "Description";
            this.columnDesc.Width = 134;
            // 
            // columnRating
            // 
            this.columnRating.Text = "Rating";
            // 
            // columnDuration
            // 
            this.columnDuration.Text = "Duration";
            this.columnDuration.Width = 67;
            // 
            // columnPath
            // 
            this.columnPath.Text = "Path";
            this.columnPath.Width = 228;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Location = new System.Drawing.Point(200, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(86, 31);
            this.button10.TabIndex = 1;
            this.button10.Text = "Search";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // bSearch
            // 
            this.bSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bSearch.Location = new System.Drawing.Point(7, 8);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(187, 23);
            this.bSearch.TabIndex = 0;
            this.bSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bSearch_KeyDown);
            // 
            // UploadPage
            // 
            this.UploadPage.BackColor = System.Drawing.SystemColors.Control;
            this.UploadPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UploadPage.BackgroundImage")));
            this.UploadPage.Controls.Add(this.label6);
            this.UploadPage.Controls.Add(this.button2);
            this.UploadPage.Controls.Add(this.Categori);
            this.UploadPage.Controls.Add(this.label4);
            this.UploadPage.Controls.Add(this.Tags);
            this.UploadPage.Controls.Add(this.label3);
            this.UploadPage.Controls.Add(this.label2);
            this.UploadPage.Controls.Add(this.Rating);
            this.UploadPage.Controls.Add(this.Description);
            this.UploadPage.Controls.Add(this.label1);
            this.UploadPage.Controls.Add(this.button1);
            this.UploadPage.Controls.Add(this.path);
            this.UploadPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UploadPage.Location = new System.Drawing.Point(4, 27);
            this.UploadPage.Name = "UploadPage";
            this.UploadPage.Padding = new System.Windows.Forms.Padding(3);
            this.UploadPage.Size = new System.Drawing.Size(710, 396);
            this.UploadPage.TabIndex = 0;
            this.UploadPage.Text = "Upload";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(25, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Categories: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Categori
            // 
            this.Categori.FormattingEnabled = true;
            this.Categori.Location = new System.Drawing.Point(117, 261);
            this.Categori.Name = "Categori";
            this.Categori.Size = new System.Drawing.Size(180, 58);
            this.Categori.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Separate all entries by ;";
            // 
            // Tags
            // 
            this.Tags.Location = new System.Drawing.Point(117, 208);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(180, 23);
            this.Tags.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(65, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tags: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(56, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rating: \r\n(0-10)";
            // 
            // Rating
            // 
            this.Rating.BackColor = System.Drawing.SystemColors.Control;
            this.Rating.Location = new System.Drawing.Point(117, 151);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(180, 45);
            this.Rating.TabIndex = 4;
            this.Rating.Value = 5;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(117, 55);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(180, 72);
            this.Description.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.BackColor = System.Drawing.Color.Transparent;
            this.path.Location = new System.Drawing.Point(26, 23);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(82, 15);
            this.path.TabIndex = 0;
            this.path.Text = "Select file ...";
            // 
            // DelPage
            // 
            this.DelPage.Controls.Add(this.listView2);
            this.DelPage.Location = new System.Drawing.Point(4, 27);
            this.DelPage.Name = "DelPage";
            this.DelPage.Padding = new System.Windows.Forms.Padding(3);
            this.DelPage.Size = new System.Drawing.Size(710, 396);
            this.DelPage.TabIndex = 5;
            this.DelPage.Text = "Delete";
            this.DelPage.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView2.BackgroundImage")));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Location = new System.Drawing.Point(1, 18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(709, 361);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rating";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Duration";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Path";
            this.columnHeader5.Width = 228;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // AboutPage
            // 
            this.AboutPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AboutPage.BackgroundImage")));
            this.AboutPage.Controls.Add(this.label10);
            this.AboutPage.Controls.Add(this.label9);
            this.AboutPage.Controls.Add(this.label8);
            this.AboutPage.Controls.Add(this.label7);
            this.AboutPage.Location = new System.Drawing.Point(4, 27);
            this.AboutPage.Name = "AboutPage";
            this.AboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.AboutPage.Size = new System.Drawing.Size(710, 396);
            this.AboutPage.TabIndex = 4;
            this.AboutPage.Text = "About the Developers";
            this.AboutPage.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(183, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 30);
            this.label10.TabIndex = 3;
            this.label10.Text = "\".NET Framework is the Gods\'\r\n gift to mankind.\"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(427, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "\"Java rocks.\r\n  C# sucks.\"";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(385, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 263);
            this.label8.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(183, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 263);
            this.label7.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(723, 437);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Personal Video Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.PlayerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.SearchPage.ResumeLayout(false);
            this.SearchPage.PerformLayout();
            this.UploadPage.ResumeLayout(false);
            this.UploadPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rating)).EndInit();
            this.DelPage.ResumeLayout(false);
            this.AboutPage.ResumeLayout(false);
            this.AboutPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UploadPage;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Rating;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Categori;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage SearchPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox bSearch;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TabPage PlayerPage;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private System.Windows.Forms.ColumnHeader columnRating;
        private System.Windows.Forms.ColumnHeader columnDuration;
        private System.Windows.Forms.ColumnHeader columnPath;
        private System.Windows.Forms.TabPage AboutPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.Label lCount6;
        private System.Windows.Forms.Label lCount5;
        private System.Windows.Forms.Label lCount4;
        private System.Windows.Forms.Label lCount3;
        private System.Windows.Forms.Label lCount2;
        private System.Windows.Forms.Label lCount1;
        private System.Windows.Forms.Label lCount0;
        private System.Windows.Forms.TabPage DelPage;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button13;
    }
}

