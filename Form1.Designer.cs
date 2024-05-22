namespace Project
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
            titleComboBox = new MaterialSkin.Controls.MaterialComboBox();
            bodyTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            deleteButton = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleComboBox
            // 
            titleComboBox.AutoResize = false;
            titleComboBox.BackColor = Color.FromArgb(255, 255, 255);
            titleComboBox.Depth = 0;
            titleComboBox.Dock = DockStyle.Left;
            titleComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            titleComboBox.DropDownHeight = 174;
            titleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            titleComboBox.DropDownWidth = 121;
            titleComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            titleComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            titleComboBox.FormattingEnabled = true;
            titleComboBox.IntegralHeight = false;
            titleComboBox.ItemHeight = 43;
            titleComboBox.Location = new Point(3, 64);
            titleComboBox.MaxDropDownItems = 4;
            titleComboBox.MouseState = MaterialSkin.MouseState.OUT;
            titleComboBox.Name = "titleComboBox";
            titleComboBox.Size = new Size(229, 49);
            titleComboBox.StartIndex = 0;
            titleComboBox.TabIndex = 0;
            titleComboBox.SelectedIndexChanged += titleComboBox_SelectedIndexChanged;
            // 
            // bodyTextBox
            // 
            bodyTextBox.AnimateReadOnly = false;
            bodyTextBox.BackgroundImageLayout = ImageLayout.None;
            bodyTextBox.CharacterCasing = CharacterCasing.Normal;
            bodyTextBox.Depth = 0;
            bodyTextBox.Dock = DockStyle.Right;
            bodyTextBox.HideSelection = true;
            bodyTextBox.Location = new Point(239, 64);
            bodyTextBox.MaxLength = 32767;
            bodyTextBox.MouseState = MaterialSkin.MouseState.OUT;
            bodyTextBox.Name = "bodyTextBox";
            bodyTextBox.PasswordChar = '\0';
            bodyTextBox.ReadOnly = true;
            bodyTextBox.ScrollBars = ScrollBars.Vertical;
            bodyTextBox.SelectedText = "";
            bodyTextBox.SelectionLength = 0;
            bodyTextBox.SelectionStart = 0;
            bodyTextBox.ShortcutsEnabled = true;
            bodyTextBox.Size = new Size(410, 387);
            bodyTextBox.TabIndex = 1;
            bodyTextBox.TabStop = false;
            bodyTextBox.TextAlign = HorizontalAlignment.Left;
            bodyTextBox.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = Properties.Resources.Add;
            materialButton1.Location = new Point(6, 415);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(120, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "Add Note";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += btnOpenSecondForm_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteButton.Depth = 0;
            deleteButton.HighEmphasis = true;
            deleteButton.Icon = Properties.Resources.Trash_Bin;
            deleteButton.Location = new Point(131, 415);
            deleteButton.Margin = new Padding(4, 6, 4, 6);
            deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            deleteButton.Name = "deleteButton";
            deleteButton.NoAccentTextColor = Color.Empty;
            deleteButton.Size = new Size(101, 36);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "DELETE";
            deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteButton.UseAccentColor = false;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_png;
            pictureBox1.Location = new Point(3, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 454);
            Controls.Add(pictureBox1);
            Controls.Add(deleteButton);
            Controls.Add(materialButton1);
            Controls.Add(bodyTextBox);
            Controls.Add(titleComboBox);
            MaximizeBox = false;
            MinimumSize = new Size(652, 454);
            Name = "Form1";
            Sizable = false;
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox titleComboBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 bodyTextBox;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private PictureBox pictureBox1;
    }
}
