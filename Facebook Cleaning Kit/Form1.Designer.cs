namespace Facebook_Cleaning_Kit
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
            this.btnInactiveUnfriend = new System.Windows.Forms.Button();
            this.btnAllUnfriend = new System.Windows.Forms.Button();
            this.btnDeleteAllChats = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstvActiveList = new System.Windows.Forms.ListView();
            this.btnRemoveUnfriendList = new System.Windows.Forms.Button();
            this.btnViewInactiveFriend = new System.Windows.Forms.Button();
            this.lstvInactiveList = new System.Windows.Forms.ListView();
            this.btnViewActiveFriend = new System.Windows.Forms.Button();
            this.btnRemoveActiveFriend = new System.Windows.Forms.Button();
            this.btnStartUnfriend = new System.Windows.Forms.Button();
            this.lblInactiveStatus = new System.Windows.Forms.Label();
            this.lblActiveStatus = new System.Windows.Forms.Label();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInactiveUnfriend
            // 
            this.btnInactiveUnfriend.Location = new System.Drawing.Point(2, 1);
            this.btnInactiveUnfriend.Name = "btnInactiveUnfriend";
            this.btnInactiveUnfriend.Size = new System.Drawing.Size(99, 43);
            this.btnInactiveUnfriend.TabIndex = 0;
            this.btnInactiveUnfriend.Text = "Inactive Unfriend";
            this.btnInactiveUnfriend.UseVisualStyleBackColor = true;
            this.btnInactiveUnfriend.Click += new System.EventHandler(this.btnInactiveUnfriend_Click);
            // 
            // btnAllUnfriend
            // 
            this.btnAllUnfriend.Location = new System.Drawing.Point(107, 1);
            this.btnAllUnfriend.Name = "btnAllUnfriend";
            this.btnAllUnfriend.Size = new System.Drawing.Size(99, 43);
            this.btnAllUnfriend.TabIndex = 1;
            this.btnAllUnfriend.Text = "All Unfriend";
            this.btnAllUnfriend.UseVisualStyleBackColor = true;
            this.btnAllUnfriend.Click += new System.EventHandler(this.btnAllUnfriend_Click);
            // 
            // btnDeleteAllChats
            // 
            this.btnDeleteAllChats.Location = new System.Drawing.Point(212, 1);
            this.btnDeleteAllChats.Name = "btnDeleteAllChats";
            this.btnDeleteAllChats.Size = new System.Drawing.Size(99, 43);
            this.btnDeleteAllChats.TabIndex = 2;
            this.btnDeleteAllChats.Text = "Delete All Chats";
            this.btnDeleteAllChats.UseVisualStyleBackColor = true;
            this.btnDeleteAllChats.Click += new System.EventHandler(this.btnDeleteAllChats_Click);
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(805, 12);
            this.numberBox.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numberBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(120, 20);
            this.numberBox.TabIndex = 3;
            this.numberBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(2, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(923, 51);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstvActiveList
            // 
            this.lstvActiveList.HideSelection = false;
            this.lstvActiveList.Location = new System.Drawing.Point(473, 130);
            this.lstvActiveList.MultiSelect = false;
            this.lstvActiveList.Name = "lstvActiveList";
            this.lstvActiveList.Size = new System.Drawing.Size(461, 402);
            this.lstvActiveList.TabIndex = 5;
            this.lstvActiveList.UseCompatibleStateImageBehavior = false;
            // 
            // btnRemoveUnfriendList
            // 
            this.btnRemoveUnfriendList.Location = new System.Drawing.Point(2, 539);
            this.btnRemoveUnfriendList.Name = "btnRemoveUnfriendList";
            this.btnRemoveUnfriendList.Size = new System.Drawing.Size(147, 22);
            this.btnRemoveUnfriendList.TabIndex = 6;
            this.btnRemoveUnfriendList.Text = "Remove from Unfriend List";
            this.btnRemoveUnfriendList.UseVisualStyleBackColor = true;
            this.btnRemoveUnfriendList.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnViewInactiveFriend
            // 
            this.btnViewInactiveFriend.Location = new System.Drawing.Point(155, 538);
            this.btnViewInactiveFriend.Name = "btnViewInactiveFriend";
            this.btnViewInactiveFriend.Size = new System.Drawing.Size(75, 23);
            this.btnViewInactiveFriend.TabIndex = 7;
            this.btnViewInactiveFriend.Text = "View Friend";
            this.btnViewInactiveFriend.UseVisualStyleBackColor = true;
            this.btnViewInactiveFriend.Click += new System.EventHandler(this.btnViewInactiveFriend_Click);
            // 
            // lstvInactiveList
            // 
            this.lstvInactiveList.HideSelection = false;
            this.lstvInactiveList.Location = new System.Drawing.Point(5, 129);
            this.lstvInactiveList.MultiSelect = false;
            this.lstvInactiveList.Name = "lstvInactiveList";
            this.lstvInactiveList.Size = new System.Drawing.Size(462, 402);
            this.lstvInactiveList.TabIndex = 8;
            this.lstvInactiveList.UseCompatibleStateImageBehavior = false;
            this.lstvInactiveList.SelectedIndexChanged += new System.EventHandler(this.lstvInactiveList_SelectedIndexChanged);
            // 
            // btnViewActiveFriend
            // 
            this.btnViewActiveFriend.Location = new System.Drawing.Point(711, 538);
            this.btnViewActiveFriend.Name = "btnViewActiveFriend";
            this.btnViewActiveFriend.Size = new System.Drawing.Size(75, 23);
            this.btnViewActiveFriend.TabIndex = 9;
            this.btnViewActiveFriend.Text = "View Friend";
            this.btnViewActiveFriend.UseVisualStyleBackColor = true;
            this.btnViewActiveFriend.Click += new System.EventHandler(this.btnViewActiveFriend_Click);
            // 
            // btnRemoveActiveFriend
            // 
            this.btnRemoveActiveFriend.Location = new System.Drawing.Point(792, 537);
            this.btnRemoveActiveFriend.Name = "btnRemoveActiveFriend";
            this.btnRemoveActiveFriend.Size = new System.Drawing.Size(142, 23);
            this.btnRemoveActiveFriend.TabIndex = 10;
            this.btnRemoveActiveFriend.Text = "Remove From Active List";
            this.btnRemoveActiveFriend.UseVisualStyleBackColor = true;
            this.btnRemoveActiveFriend.Click += new System.EventHandler(this.btnRemoveActiveFriend_Click);
            // 
            // btnStartUnfriend
            // 
            this.btnStartUnfriend.Location = new System.Drawing.Point(409, 531);
            this.btnStartUnfriend.Name = "btnStartUnfriend";
            this.btnStartUnfriend.Size = new System.Drawing.Size(92, 32);
            this.btnStartUnfriend.TabIndex = 11;
            this.btnStartUnfriend.Text = "Start Unfriend";
            this.btnStartUnfriend.UseVisualStyleBackColor = true;
            this.btnStartUnfriend.Click += new System.EventHandler(this.button8_Click);
            // 
            // lblInactiveStatus
            // 
            this.lblInactiveStatus.Location = new System.Drawing.Point(2, 110);
            this.lblInactiveStatus.Name = "lblInactiveStatus";
            this.lblInactiveStatus.Size = new System.Drawing.Size(448, 16);
            this.lblInactiveStatus.TabIndex = 12;
            this.lblInactiveStatus.Text = "Inactive Friends";
            this.lblInactiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActiveStatus
            // 
            this.lblActiveStatus.Location = new System.Drawing.Point(473, 110);
            this.lblActiveStatus.Name = "lblActiveStatus";
            this.lblActiveStatus.Size = new System.Drawing.Size(452, 16);
            this.lblActiveStatus.TabIndex = 13;
            this.lblActiveStatus.Text = "Active Friends";
            this.lblActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(2, 130);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(932, 402);
            this.browser.TabIndex = 14;
            this.browser.Url = new System.Uri("https://mbasic.facebook.com/login.php", System.UriKind.Absolute);
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number of recent post for scan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(937, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.lblActiveStatus);
            this.Controls.Add(this.lblInactiveStatus);
            this.Controls.Add(this.btnStartUnfriend);
            this.Controls.Add(this.btnRemoveActiveFriend);
            this.Controls.Add(this.btnViewActiveFriend);
            this.Controls.Add(this.lstvInactiveList);
            this.Controls.Add(this.btnViewInactiveFriend);
            this.Controls.Add(this.btnRemoveUnfriendList);
            this.Controls.Add(this.lstvActiveList);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.btnDeleteAllChats);
            this.Controls.Add(this.btnAllUnfriend);
            this.Controls.Add(this.btnInactiveUnfriend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Facebook Cleaning Kit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInactiveUnfriend;
        private System.Windows.Forms.Button btnAllUnfriend;
        private System.Windows.Forms.Button btnDeleteAllChats;
        private System.Windows.Forms.NumericUpDown numberBox;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListView lstvActiveList;
        private System.Windows.Forms.Button btnRemoveUnfriendList;
        private System.Windows.Forms.Button btnViewInactiveFriend;
        private System.Windows.Forms.ListView lstvInactiveList;
        private System.Windows.Forms.Button btnViewActiveFriend;
        private System.Windows.Forms.Button btnRemoveActiveFriend;
        private System.Windows.Forms.Button btnStartUnfriend;
        private System.Windows.Forms.Label lblInactiveStatus;
        private System.Windows.Forms.Label lblActiveStatus;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Label label1;
    }
}

