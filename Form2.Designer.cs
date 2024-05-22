namespace Project
{
    partial class Form2
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
            addTitleTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            addDoTextBox = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // addTitleTextBox
            // 
            addTitleTextBox.AnimateReadOnly = false;
            addTitleTextBox.BackgroundImageLayout = ImageLayout.None;
            addTitleTextBox.CharacterCasing = CharacterCasing.Normal;
            addTitleTextBox.Depth = 0;
            addTitleTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            addTitleTextBox.HideSelection = true;
            addTitleTextBox.LeadingIcon = null;
            addTitleTextBox.Location = new Point(195, 98);
            addTitleTextBox.MaxLength = 32767;
            addTitleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            addTitleTextBox.Name = "addTitleTextBox";
            addTitleTextBox.PasswordChar = '\0';
            addTitleTextBox.PrefixSuffixText = null;
            addTitleTextBox.ReadOnly = false;
            addTitleTextBox.RightToLeft = RightToLeft.No;
            addTitleTextBox.SelectedText = "";
            addTitleTextBox.SelectionLength = 0;
            addTitleTextBox.SelectionStart = 0;
            addTitleTextBox.ShortcutsEnabled = true;
            addTitleTextBox.Size = new Size(250, 48);
            addTitleTextBox.TabIndex = 0;
            addTitleTextBox.TabStop = false;
            addTitleTextBox.TextAlign = HorizontalAlignment.Left;
            addTitleTextBox.TrailingIcon = null;
            addTitleTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(302, 76);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(32, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Title";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(302, 156);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(37, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Body";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(287, 237);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "Add";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += btnBackToFirstForm_Click;
            // 
            // addDoTextBox
            // 
            addDoTextBox.AnimateReadOnly = false;
            addDoTextBox.BorderStyle = BorderStyle.None;
            addDoTextBox.Depth = 0;
            addDoTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            addDoTextBox.LeadingIcon = null;
            addDoTextBox.Location = new Point(6, 178);
            addDoTextBox.MaxLength = 50;
            addDoTextBox.MouseState = MaterialSkin.MouseState.OUT;
            addDoTextBox.Multiline = false;
            addDoTextBox.Name = "addDoTextBox";
            addDoTextBox.Size = new Size(640, 50);
            addDoTextBox.TabIndex = 5;
            addDoTextBox.Text = "";
            addDoTextBox.TrailingIcon = null;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 283);
            Controls.Add(addDoTextBox);
            Controls.Add(materialButton1);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(addTitleTextBox);
            MaximizeBox = false;
            MinimumSize = new Size(652, 283);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 addTitleTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox addDoTextBox;
    }
}