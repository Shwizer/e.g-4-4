namespace e.g_4_4
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
            lblMenuTitle = new Label();
            lstMenu = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblSelectedTitle = new Label();
            lblTotal = new Label();
            lstSelected = new ListBox();
            SuspendLayout();
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Location = new Point(21, 64);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(71, 20);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "Thực đơn";
            // 
            // lstMenu
            // 
            lstMenu.Font = new Font("Segoe UI", 11F);
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(21, 108);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(255, 129);
            lstMenu.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(301, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = ">";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(301, 193);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 44);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblSelectedTitle
            // 
            lblSelectedTitle.AutoSize = true;
            lblSelectedTitle.Location = new Point(451, 64);
            lblSelectedTitle.Name = "lblSelectedTitle";
            lblSelectedTitle.Size = new Size(96, 20);
            lblSelectedTitle.TabIndex = 4;
            lblSelectedTitle.Text = "Món đã chọn";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(21, 279);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(176, 28);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Tổng tiền: 0 VNĐ";
            // 
            // lstSelected
            // 
            lstSelected.Font = new Font("Segoe UI", 11F);
            lstSelected.FormattingEnabled = true;
            lstSelected.Location = new Point(451, 108);
            lstSelected.Name = "lstSelected";
            lstSelected.Size = new Size(255, 129);
            lstSelected.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 364);
            Controls.Add(lstSelected);
            Controls.Add(lblTotal);
            Controls.Add(lblSelectedTitle);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstMenu);
            Controls.Add(lblMenuTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenuTitle;
        private ListBox lstMenu;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblSelectedTitle;
        private Label lblTotal;
        private ListBox lstSelected;
    }
}
