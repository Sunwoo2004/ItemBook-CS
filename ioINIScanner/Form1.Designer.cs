namespace ioINIScanner
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.EtcItemBox = new System.Windows.Forms.ListBox();
            this.ItemBox = new System.Windows.Forms.ListBox();
            this.CostumeBox = new System.Windows.Forms.ListBox();
            this.MedalBox = new System.Windows.Forms.ListBox();
            this.PetBox = new System.Windows.Forms.ListBox();
            this.DetailText = new System.Windows.Forms.TextBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.SearchLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 33);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(222, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 22);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.SearchBox.Location = new System.Drawing.Point(46, 5);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(170, 23);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(10, 10);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(33, 12);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "검색:";
            // 
            // EtcItemBox
            // 
            this.EtcItemBox.FormattingEnabled = true;
            this.EtcItemBox.ItemHeight = 12;
            this.EtcItemBox.Location = new System.Drawing.Point(0, 33);
            this.EtcItemBox.Name = "EtcItemBox";
            this.EtcItemBox.Size = new System.Drawing.Size(180, 436);
            this.EtcItemBox.TabIndex = 1;
            this.EtcItemBox.SelectedIndexChanged += new System.EventHandler(this.EtcItemBox_SelectedIndexChanged);
            // 
            // ItemBox
            // 
            this.ItemBox.FormattingEnabled = true;
            this.ItemBox.ItemHeight = 12;
            this.ItemBox.Location = new System.Drawing.Point(180, 33);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(180, 436);
            this.ItemBox.TabIndex = 2;
            this.ItemBox.SelectedIndexChanged += new System.EventHandler(this.ItemBox_SelectedIndexChanged);
            // 
            // CostumeBox
            // 
            this.CostumeBox.FormattingEnabled = true;
            this.CostumeBox.ItemHeight = 12;
            this.CostumeBox.Location = new System.Drawing.Point(360, 33);
            this.CostumeBox.Name = "CostumeBox";
            this.CostumeBox.Size = new System.Drawing.Size(180, 436);
            this.CostumeBox.TabIndex = 3;
            this.CostumeBox.SelectedIndexChanged += new System.EventHandler(this.CostumeBox_SelectedIndexChanged);
            // 
            // MedalBox
            // 
            this.MedalBox.FormattingEnabled = true;
            this.MedalBox.ItemHeight = 12;
            this.MedalBox.Location = new System.Drawing.Point(540, 33);
            this.MedalBox.Name = "MedalBox";
            this.MedalBox.Size = new System.Drawing.Size(180, 436);
            this.MedalBox.TabIndex = 4;
            this.MedalBox.SelectedIndexChanged += new System.EventHandler(this.MedalBox_SelectedIndexChanged);
            // 
            // PetBox
            // 
            this.PetBox.FormattingEnabled = true;
            this.PetBox.ItemHeight = 12;
            this.PetBox.Location = new System.Drawing.Point(720, 33);
            this.PetBox.Name = "PetBox";
            this.PetBox.Size = new System.Drawing.Size(180, 436);
            this.PetBox.TabIndex = 5;
            this.PetBox.SelectedIndexChanged += new System.EventHandler(this.PetBox_SelectedIndexChanged);
            // 
            // DetailText
            // 
            this.DetailText.Location = new System.Drawing.Point(0, 475);
            this.DetailText.Multiline = true;
            this.DetailText.Name = "DetailText";
            this.DetailText.Size = new System.Drawing.Size(900, 102);
            this.DetailText.TabIndex = 6;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.DetailText);
            this.Controls.Add(this.PetBox);
            this.Controls.Add(this.MedalBox);
            this.Controls.Add(this.CostumeBox);
            this.Controls.Add(this.ItemBox);
            this.Controls.Add(this.EtcItemBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ioINIScanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ListBox EtcItemBox;
        private System.Windows.Forms.ListBox ItemBox;
        private System.Windows.Forms.ListBox CostumeBox;
        private System.Windows.Forms.ListBox MedalBox;
        private System.Windows.Forms.ListBox PetBox;
        private System.Windows.Forms.TextBox DetailText;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
    }
}

