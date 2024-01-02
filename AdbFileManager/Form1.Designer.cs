using randz.CustomControls;

namespace AdbFileManager
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
            dataGridView1 = new DataGridView();
            explorerBrowser1 = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser();
            android2pc = new Button();
            pc2android = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            cur_path = new TextBox();
            panel1 = new Panel();
            btnDeleteMsg = new Button();
            explorer_path = new TextBox();
            panel2 = new Panel();
            checkBox_preview = new CheckBox();
            button1 = new Button();
            checkBox_android6fix = new CheckBox();
            version = new LinkLabel();
            filedate_check = new CheckBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(27, 53);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(628, 613);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            dataGridView1.ColumnHeaderMouseDoubleClick += dataGridView1_ColumnHeaderMouseDoubleClick;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // explorerBrowser1
            // 
            explorerBrowser1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            explorerBrowser1.AutoSize = true;
            explorerBrowser1.Location = new Point(704, 53);
            explorerBrowser1.Margin = new Padding(3, 4, 3, 4);
            explorerBrowser1.Name = "explorerBrowser1";
            explorerBrowser1.PropertyBagName = "Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser";
            explorerBrowser1.Size = new Size(631, 613);
            explorerBrowser1.TabIndex = 7;
            explorerBrowser1.NavigationComplete += explorerBrowser1_NavigationComplete;
            explorerBrowser1.Load += explorerBrowser1_Load;
            // 
            // android2pc
            // 
            android2pc.Anchor = AnchorStyles.None;
            android2pc.FlatAppearance.BorderSize = 3;
            android2pc.FlatStyle = FlatStyle.Popup;
            android2pc.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            android2pc.Location = new Point(662, 235);
            android2pc.Margin = new Padding(3, 4, 3, 4);
            android2pc.Name = "android2pc";
            android2pc.Size = new Size(37, 53);
            android2pc.TabIndex = 8;
            android2pc.Text = ">";
            android2pc.UseVisualStyleBackColor = true;
            android2pc.Click += android2pc_Click;
            // 
            // pc2android
            // 
            pc2android.Anchor = AnchorStyles.None;
            pc2android.FlatAppearance.BorderSize = 3;
            pc2android.FlatStyle = FlatStyle.Popup;
            pc2android.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            pc2android.ForeColor = SystemColors.ControlText;
            pc2android.Location = new Point(662, 296);
            pc2android.Margin = new Padding(3, 4, 3, 4);
            pc2android.Name = "pc2android";
            pc2android.Size = new Size(37, 53);
            pc2android.TabIndex = 9;
            pc2android.Text = "<";
            pc2android.UseVisualStyleBackColor = true;
            pc2android.Click += pc2android_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // cur_path
            // 
            cur_path.Dock = DockStyle.Left;
            cur_path.Location = new Point(0, 0);
            cur_path.Margin = new Padding(3, 4, 3, 4);
            cur_path.Name = "cur_path";
            cur_path.Size = new Size(655, 27);
            cur_path.TabIndex = 12;
            cur_path.TextChanged += cur_path_TextChanged;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(cur_path);
            panel1.Controls.Add(btnDeleteMsg);
            panel1.Controls.Add(explorer_path);
            panel1.Controls.Add(android2pc);
            panel1.Controls.Add(pc2android);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 11);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1355, 729);
            panel1.TabIndex = 13;
            // 
            // btnDeleteMsg
            // 
            btnDeleteMsg.Anchor = AnchorStyles.None;
            btnDeleteMsg.BackColor = SystemColors.Control;
            btnDeleteMsg.FlatAppearance.BorderColor = Color.Black;
            btnDeleteMsg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteMsg.Location = new Point(662, 356);
            btnDeleteMsg.Name = "btnDeleteMsg";
            btnDeleteMsg.Size = new Size(37, 55);
            btnDeleteMsg.TabIndex = 18;
            btnDeleteMsg.Text = "X";
            toolTip1.SetToolTip(btnDeleteMsg, "Deletes the currently selected files");
            btnDeleteMsg.UseVisualStyleBackColor = false;
            btnDeleteMsg.Click += btnDeleteMsg_Click;
            // 
            // explorer_path
            // 
            explorer_path.Dock = DockStyle.Right;
            explorer_path.Location = new Point(707, 0);
            explorer_path.Margin = new Padding(3, 4, 3, 4);
            explorer_path.Name = "explorer_path";
            explorer_path.Size = new Size(648, 27);
            explorer_path.TabIndex = 14;
            explorer_path.KeyPress += explorer_path_KeyPress;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(checkBox_preview);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(checkBox_android6fix);
            panel2.Controls.Add(version);
            panel2.Controls.Add(filedate_check);
            panel2.Location = new Point(0, 663);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1352, 62);
            panel2.TabIndex = 17;
            // 
            // checkBox_preview
            // 
            checkBox_preview.AutoSize = true;
            checkBox_preview.Location = new Point(356, 4);
            checkBox_preview.Margin = new Padding(3, 4, 3, 4);
            checkBox_preview.Name = "checkBox_preview";
            checkBox_preview.Size = new Size(218, 24);
            checkBox_preview.TabIndex = 17;
            checkBox_preview.Text = "Preview files on double click";
            toolTip1.SetToolTip(checkBox_preview, "When file is double clicked, it will copy it to temp folder and display it. On program close the files will be deleted");
            checkBox_preview.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(1189, 18);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(13, 11);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox_android6fix
            // 
            checkBox_android6fix.AutoSize = true;
            checkBox_android6fix.Location = new Point(209, 4);
            checkBox_android6fix.Margin = new Padding(3, 4, 3, 4);
            checkBox_android6fix.Name = "checkBox_android6fix";
            checkBox_android6fix.Size = new Size(141, 24);
            checkBox_android6fix.TabIndex = 14;
            checkBox_android6fix.Text = "Compatibility fix";
            toolTip1.SetToolTip(checkBox_android6fix, "Enabling this fixes some compatibility issues with Android 6 and older devices");
            checkBox_android6fix.UseVisualStyleBackColor = true;
            // 
            // version
            // 
            version.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            version.AutoSize = true;
            version.Location = new Point(1204, 8);
            version.Name = "version";
            version.Size = new Size(89, 20);
            version.TabIndex = 15;
            version.TabStop = true;
            version.Text = "version here";
            version.LinkClicked += version_LinkClicked;
            // 
            // filedate_check
            // 
            filedate_check.AutoSize = true;
            filedate_check.Location = new Point(14, 4);
            filedate_check.Margin = new Padding(3, 4, 3, 4);
            filedate_check.Name = "filedate_check";
            filedate_check.Size = new Size(189, 24);
            filedate_check.TabIndex = 14;
            filedate_check.Text = "Keep file modified date";
            filedate_check.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 708);
            Controls.Add(explorerBrowser1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1357, 47);
            Name = "Form1";
            Text = " AdbFileManager";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResizeEnd += OnForm1ResizeEnd;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        public TextBox textBox3;
        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser explorerBrowser1;
        private Button android2pc;
        private Button pc2android;
        public DataGridView dataGridView1;
        //private randz.CustomControls.VerticalLabel verticalLabel1;
        //private randz.CustomControls.VerticalLabel verticalLabel2;
        private System.Windows.Forms.Timer timer1;
        private TextBox cur_path;
        private Panel panel1;
        private CheckBox filedate_check;
        private TextBox explorer_path;
        private LinkLabel version;
        private Button button1;
        private Panel panel2;
        private ToolTip toolTip1;
        public CheckBox checkBox_android6fix;
        private CheckBox checkBox_preview;
        private Button btnDeleteMsg;
    }
}