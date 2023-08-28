namespace CenterWindow
{
    partial class WC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WC));
            this.comboBoxPosition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bttStart = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelControll = new System.Windows.Forms.Panel();
            this.bttClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MainPanel.SuspendLayout();
            this.PanelControll.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.comboBoxPosition.BorderThickness = 0;
            this.comboBoxPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxPosition.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPosition.ItemHeight = 30;
            this.comboBoxPosition.Location = new System.Drawing.Point(3, 35);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(315, 36);
            this.comboBoxPosition.TabIndex = 0;
            // 
            // bttStart
            // 
            this.bttStart.Animated = true;
            this.bttStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.bttStart.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.bttStart.ForeColor = System.Drawing.Color.White;
            this.bttStart.Location = new System.Drawing.Point(3, 77);
            this.bttStart.Name = "bttStart";
            this.bttStart.Size = new System.Drawing.Size(315, 40);
            this.bttStart.TabIndex = 1;
            this.bttStart.Text = "ЗАПУСТИТЬ";
            this.bttStart.Click += new System.EventHandler(this.bttStart_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MainPanel.Controls.Add(this.PanelControll);
            this.MainPanel.Controls.Add(this.bttStart);
            this.MainPanel.Controls.Add(this.comboBoxPosition);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(322, 125);
            this.MainPanel.TabIndex = 2;
            // 
            // PanelControll
            // 
            this.PanelControll.BackColor = System.Drawing.Color.SlateBlue;
            this.PanelControll.Controls.Add(this.bttClose);
            this.PanelControll.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControll.Location = new System.Drawing.Point(0, 0);
            this.PanelControll.Name = "PanelControll";
            this.PanelControll.Size = new System.Drawing.Size(322, 29);
            this.PanelControll.TabIndex = 2;
            // 
            // bttClose
            // 
            this.bttClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttClose.FillColor = System.Drawing.Color.SlateBlue;
            this.bttClose.IconColor = System.Drawing.Color.White;
            this.bttClose.Location = new System.Drawing.Point(277, 0);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(45, 29);
            this.bttClose.TabIndex = 0;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.PanelControll;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 8;
            this.Elipse.TargetControl = this;
            // 
            // WC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 125);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WC";
            this.Text = "WC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WC_FormClosing);
            this.MainPanel.ResumeLayout(false);
            this.PanelControll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboBoxPosition;
        private Guna.UI2.WinForms.Guna2Button bttStart;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelControll;
        private Guna.UI2.WinForms.Guna2ControlBox bttClose;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
    }
}

