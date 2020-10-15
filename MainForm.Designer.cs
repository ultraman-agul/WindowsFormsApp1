namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icon_xy = new FontAwesome.Sharp.IconButton();
            this.icon_time = new FontAwesome.Sharp.IconButton();
            this.icon_welcome = new FontAwesome.Sharp.IconButton();
            this.icon_Buy = new FontAwesome.Sharp.IconButton();
            this.icon_updatepwd = new FontAwesome.Sharp.IconButton();
            this.icon_role = new FontAwesome.Sharp.IconButton();
            this.icon_user = new FontAwesome.Sharp.IconButton();
            this.icon_goods = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.icon_out = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 144);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.icon_Buy);
            this.splitContainer1.Panel1.Controls.Add(this.uiSymbolButton1);
            this.splitContainer1.Panel1.Controls.Add(this.icon_updatepwd);
            this.splitContainer1.Panel1.Controls.Add(this.icon_role);
            this.splitContainer1.Panel1.Controls.Add(this.icon_user);
            this.splitContainer1.Panel1.Controls.Add(this.icon_goods);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseMove);
            this.splitContainer1.Size = new System.Drawing.Size(1298, 575);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(24, 33);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(188, 45);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.StyleCustomMode = true;
            this.uiSymbolButton1.Symbol = 61726;
            this.uiSymbolButton1.TabIndex = 5;
            this.uiSymbolButton1.Text = "商品管理";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.icon_xy);
            this.panel2.Controls.Add(this.icon_time);
            this.panel2.Controls.Add(this.icon_welcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 715);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 100);
            this.panel2.TabIndex = 4;
            // 
            // icon_xy
            // 
            this.icon_xy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.icon_xy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icon_xy.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icon_xy.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.icon_xy.IconColor = System.Drawing.Color.Black;
            this.icon_xy.IconSize = 40;
            this.icon_xy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icon_xy.Location = new System.Drawing.Point(869, 16);
            this.icon_xy.Margin = new System.Windows.Forms.Padding(10);
            this.icon_xy.Name = "icon_xy";
            this.icon_xy.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.icon_xy.Rotation = 0D;
            this.icon_xy.Size = new System.Drawing.Size(400, 63);
            this.icon_xy.TabIndex = 2;
            this.icon_xy.Text = "iconButton3";
            this.icon_xy.UseVisualStyleBackColor = false;
            // 
            // icon_time
            // 
            this.icon_time.AutoSize = true;
            this.icon_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.icon_time.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icon_time.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icon_time.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.icon_time.IconColor = System.Drawing.Color.Black;
            this.icon_time.IconSize = 40;
            this.icon_time.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icon_time.Location = new System.Drawing.Point(449, 16);
            this.icon_time.Margin = new System.Windows.Forms.Padding(10);
            this.icon_time.Name = "icon_time";
            this.icon_time.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.icon_time.Rotation = 0D;
            this.icon_time.Size = new System.Drawing.Size(400, 63);
            this.icon_time.TabIndex = 1;
            this.icon_time.Text = "iconButton3";
            this.icon_time.UseVisualStyleBackColor = false;
            // 
            // icon_welcome
            // 
            this.icon_welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.icon_welcome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icon_welcome.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icon_welcome.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.icon_welcome.IconColor = System.Drawing.Color.Black;
            this.icon_welcome.IconSize = 40;
            this.icon_welcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icon_welcome.Location = new System.Drawing.Point(29, 16);
            this.icon_welcome.Margin = new System.Windows.Forms.Padding(10);
            this.icon_welcome.Name = "icon_welcome";
            this.icon_welcome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.icon_welcome.Rotation = 0D;
            this.icon_welcome.Size = new System.Drawing.Size(400, 63);
            this.icon_welcome.TabIndex = 0;
            this.icon_welcome.Text = "iconButton3";
            this.icon_welcome.UseVisualStyleBackColor = false;
            // 
            // icon_Buy
            // 
            this.icon_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.icon_Buy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icon_Buy.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icon_Buy.ForeColor = System.Drawing.Color.White;
            this.icon_Buy.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.icon_Buy.IconColor = System.Drawing.Color.Black;
            this.icon_Buy.IconSize = 40;
            this.icon_Buy.Location = new System.Drawing.Point(2, 394);
            this.icon_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.icon_Buy.Name = "icon_Buy";
            this.icon_Buy.Rotation = 0D;
            this.icon_Buy.Size = new System.Drawing.Size(213, 52);
            this.icon_Buy.TabIndex = 6;
            this.icon_Buy.Text = "采 购 管 理";
            this.icon_Buy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icon_Buy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icon_Buy.UseVisualStyleBackColor = false;
            this.icon_Buy.Click += new System.EventHandler(this.icon_Buy_Click);
            // 
            // icon_updatepwd
            // 
            this.icon_updatepwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.icon_updatepwd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icon_updatepwd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icon_updatepwd.ForeColor = System.Drawing.Color.White;
            this.icon_updatepwd.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.icon_updatepwd.IconColor = System.Drawing.Color.Black;
            this.icon_updatepwd.IconSize = 40;
            this.icon_updatepwd.Location = new System.Drawing.Point(0, 312);
            this.icon_updatepwd.Margin = new System.Windows.Forms.Padding(2);
            this.icon_updatepwd.Name = "icon_updatepwd";
            this.icon_updatepwd.Rotation = 0D;
            this.icon_updatepwd.Size = new System.Drawing.Size(213, 52);
            this.icon_updatepwd.TabIndex = 4;
            this.icon_updatepwd.Text = "修 改 密 码";
            this.icon_updatepwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icon_updatepwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icon_updatepwd.UseVisualStyleBackColor = false;
            this.icon_updatepwd.Click += new System.EventHandler(this.icon_updatepwd_Click);
            // 
            // icon_role
            // 
            this.icon_role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.icon_role.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icon_role.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icon_role.ForeColor = System.Drawing.Color.White;
            this.icon_role.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.icon_role.IconColor = System.Drawing.Color.Black;
            this.icon_role.IconSize = 40;
            this.icon_role.Location = new System.Drawing.Point(0, 256);
            this.icon_role.Margin = new System.Windows.Forms.Padding(2);
            this.icon_role.Name = "icon_role";
            this.icon_role.Rotation = 0D;
            this.icon_role.Size = new System.Drawing.Size(213, 52);
            this.icon_role.TabIndex = 3;
            this.icon_role.Text = "角 色 管 理";
            this.icon_role.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icon_role.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icon_role.UseVisualStyleBackColor = false;
            this.icon_role.Click += new System.EventHandler(this.icon_role_Click);
            this.icon_role.MouseLeave += new System.EventHandler(this.icon_goods_MouseLeave);
            this.icon_role.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icon_goods_MouseMove);
            // 
            // icon_user
            // 
            this.icon_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.icon_user.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icon_user.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icon_user.ForeColor = System.Drawing.Color.White;
            this.icon_user.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.icon_user.IconColor = System.Drawing.Color.Black;
            this.icon_user.IconSize = 40;
            this.icon_user.Location = new System.Drawing.Point(0, 200);
            this.icon_user.Margin = new System.Windows.Forms.Padding(2);
            this.icon_user.Name = "icon_user";
            this.icon_user.Rotation = 0D;
            this.icon_user.Size = new System.Drawing.Size(213, 52);
            this.icon_user.TabIndex = 2;
            this.icon_user.Text = " 用 户 管 理";
            this.icon_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icon_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icon_user.UseVisualStyleBackColor = false;
            this.icon_user.Click += new System.EventHandler(this.icon_user_Click);
            this.icon_user.MouseLeave += new System.EventHandler(this.icon_goods_MouseLeave);
            this.icon_user.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icon_goods_MouseMove);
            // 
            // icon_goods
            // 
            this.icon_goods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.icon_goods.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icon_goods.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icon_goods.ForeColor = System.Drawing.Color.White;
            this.icon_goods.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.icon_goods.IconColor = System.Drawing.Color.Black;
            this.icon_goods.IconSize = 40;
            this.icon_goods.Location = new System.Drawing.Point(1, 126);
            this.icon_goods.Margin = new System.Windows.Forms.Padding(2);
            this.icon_goods.Name = "icon_goods";
            this.icon_goods.Rotation = 0D;
            this.icon_goods.Size = new System.Drawing.Size(213, 52);
            this.icon_goods.TabIndex = 1;
            this.icon_goods.Text = " 商 品 管 理";
            this.icon_goods.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icon_goods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icon_goods.UseVisualStyleBackColor = false;
            this.icon_goods.Click += new System.EventHandler(this.iconButton1_Click);
            this.icon_goods.MouseLeave += new System.EventHandler(this.icon_goods_MouseLeave);
            this.icon_goods.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icon_goods_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._自媒体资源___自媒体人的素材库_mishu_pro__银河系_繁星点点的天空_夜晚的天空__720_x_405__2020_10_15_21_30_42_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.icon_out);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 120);
            this.panel1.TabIndex = 2;
            // 
            // icon_out
            // 
            this.icon_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon_out.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icon_out.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icon_out.ForeColor = System.Drawing.Color.White;
            this.icon_out.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.icon_out.IconColor = System.Drawing.Color.White;
            this.icon_out.IconSize = 22;
            this.icon_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icon_out.Location = new System.Drawing.Point(1202, 3);
            this.icon_out.Name = "icon_out";
            this.icon_out.Rotation = 0D;
            this.icon_out.Size = new System.Drawing.Size(98, 36);
            this.icon_out.TabIndex = 1;
            this.icon_out.Text = "退出系统";
            this.icon_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icon_out.UseVisualStyleBackColor = true;
            this.icon_out.Click += new System.EventHandler(this.icon_out_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(430, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "企 业 级 进 销 存 管 理 系 统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 815);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "企业级进销存管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton icon_goods;
        private FontAwesome.Sharp.IconButton icon_user;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton icon_welcome;
        private FontAwesome.Sharp.IconButton icon_xy;
        private FontAwesome.Sharp.IconButton icon_time;
        private FontAwesome.Sharp.IconButton icon_role;
        private FontAwesome.Sharp.IconButton icon_out;
        private FontAwesome.Sharp.IconButton icon_updatepwd;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private FontAwesome.Sharp.IconButton icon_Buy;
    }
}