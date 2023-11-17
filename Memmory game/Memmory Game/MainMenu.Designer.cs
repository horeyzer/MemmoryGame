namespace Memmory_Game
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Memmory = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DifficLabel = new System.Windows.Forms.Label();
            this.DificultyBox = new System.Windows.Forms.ComboBox();
            this.NumLabel = new System.Windows.Forms.Label();
            this.LivLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ShowTimeBox = new System.Windows.Forms.TextBox();
            this.NumbersBox = new System.Windows.Forms.TextBox();
            this.LiveBox = new System.Windows.Forms.TextBox();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Memmory
            // 
            this.Memmory.AutoSize = true;
            this.Memmory.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Memmory.Location = new System.Drawing.Point(169, 34);
            this.Memmory.Name = "Memmory";
            this.Memmory.Size = new System.Drawing.Size(349, 52);
            this.Memmory.TabIndex = 0;
            this.Memmory.Text = "Memmory Game";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(56, 131);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(113, 40);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(277, 127);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(326, 44);
            this.NameBox.TabIndex = 2;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // DifficLabel
            // 
            this.DifficLabel.AutoSize = true;
            this.DifficLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficLabel.Location = new System.Drawing.Point(41, 212);
            this.DifficLabel.Name = "DifficLabel";
            this.DifficLabel.Size = new System.Drawing.Size(153, 40);
            this.DifficLabel.TabIndex = 3;
            this.DifficLabel.Text = "Difficulty";
            // 
            // DificultyBox
            // 
            this.DificultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DificultyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DificultyBox.FormattingEnabled = true;
            this.DificultyBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Custom..."});
            this.DificultyBox.Location = new System.Drawing.Point(276, 207);
            this.DificultyBox.Name = "DificultyBox";
            this.DificultyBox.Size = new System.Drawing.Size(326, 45);
            this.DificultyBox.TabIndex = 4;
            this.DificultyBox.SelectedIndexChanged += new System.EventHandler(this.DificultyBox_SelectedIndexChanged);
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumLabel.Location = new System.Drawing.Point(91, 389);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(136, 32);
            this.NumLabel.TabIndex = 5;
            this.NumLabel.Text = "Numbers:";
            // 
            // LivLabel
            // 
            this.LivLabel.AutoSize = true;
            this.LivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LivLabel.Location = new System.Drawing.Point(393, 389);
            this.LivLabel.Name = "LivLabel";
            this.LivLabel.Size = new System.Drawing.Size(89, 32);
            this.LivLabel.TabIndex = 6;
            this.LivLabel.Text = "Lives:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel.Location = new System.Drawing.Point(404, 308);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(78, 32);
            this.SizeLabel.TabIndex = 8;
            this.SizeLabel.Text = "Size:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(25, 308);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(202, 32);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Showing Time:";
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartButton.Location = new System.Drawing.Point(48, 454);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(592, 71);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start Game";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ShowTimeBox
            // 
            this.ShowTimeBox.Enabled = false;
            this.ShowTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowTimeBox.Location = new System.Drawing.Point(276, 308);
            this.ShowTimeBox.Name = "ShowTimeBox";
            this.ShowTimeBox.Size = new System.Drawing.Size(86, 35);
            this.ShowTimeBox.TabIndex = 10;
            this.ShowTimeBox.TextChanged += new System.EventHandler(this.ShowTimeBox_TextChanged);
            // 
            // NumbersBox
            // 
            this.NumbersBox.Enabled = false;
            this.NumbersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumbersBox.Location = new System.Drawing.Point(276, 386);
            this.NumbersBox.Name = "NumbersBox";
            this.NumbersBox.Size = new System.Drawing.Size(86, 35);
            this.NumbersBox.TabIndex = 11;
            this.NumbersBox.TextChanged += new System.EventHandler(this.NumbersBox_TextChanged);
            // 
            // LiveBox
            // 
            this.LiveBox.Enabled = false;
            this.LiveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LiveBox.Location = new System.Drawing.Point(517, 389);
            this.LiveBox.Name = "LiveBox";
            this.LiveBox.Size = new System.Drawing.Size(86, 35);
            this.LiveBox.TabIndex = 13;
            this.LiveBox.TextChanged += new System.EventHandler(this.LiveBox_TextChanged);
            // 
            // SizeBox
            // 
            this.SizeBox.Enabled = false;
            this.SizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeBox.Location = new System.Drawing.Point(517, 311);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(86, 35);
            this.SizeBox.TabIndex = 12;
            this.SizeBox.TextChanged += new System.EventHandler(this.SizeBox_TextChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(48, 531);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(592, 71);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(688, 632);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LiveBox);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.NumbersBox);
            this.Controls.Add(this.ShowTimeBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.LivLabel);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.DificultyBox);
            this.Controls.Add(this.DifficLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Memmory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Memmory;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label DifficLabel;
        private System.Windows.Forms.ComboBox DificultyBox;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.Label LivLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox ShowTimeBox;
        private System.Windows.Forms.TextBox NumbersBox;
        private System.Windows.Forms.TextBox LiveBox;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

