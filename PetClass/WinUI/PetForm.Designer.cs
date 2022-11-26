
namespace WinUI
{
    partial class PetForm
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
            this.petNameLabel = new System.Windows.Forms.Label();
            this.petTypeLabel = new System.Windows.Forms.Label();
            this.petAgeLabel = new System.Windows.Forms.Label();
            this.Enterbtn = new System.Windows.Forms.Button();
            this.Displaybtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.petNameBox = new System.Windows.Forms.TextBox();
            this.petAgeBox = new System.Windows.Forms.TextBox();
            this.petTypeBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Location = new System.Drawing.Point(40, 32);
            this.petNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(64, 13);
            this.petNameLabel.TabIndex = 0;
            this.petNameLabel.Text = "Pet\'s Name:";
            // 
            // petTypeLabel
            // 
            this.petTypeLabel.AutoSize = true;
            this.petTypeLabel.Location = new System.Drawing.Point(44, 100);
            this.petTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.petTypeLabel.Name = "petTypeLabel";
            this.petTypeLabel.Size = new System.Drawing.Size(60, 13);
            this.petTypeLabel.TabIndex = 1;
            this.petTypeLabel.Text = "Pet\'s Type:";
            // 
            // petAgeLabel
            // 
            this.petAgeLabel.AutoSize = true;
            this.petAgeLabel.Location = new System.Drawing.Point(49, 169);
            this.petAgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.petAgeLabel.Name = "petAgeLabel";
            this.petAgeLabel.Size = new System.Drawing.Size(55, 13);
            this.petAgeLabel.TabIndex = 2;
            this.petAgeLabel.Text = "Pet\'s Age:";
            // 
            // Enterbtn
            // 
            this.Enterbtn.Location = new System.Drawing.Point(46, 234);
            this.Enterbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Enterbtn.Name = "Enterbtn";
            this.Enterbtn.Size = new System.Drawing.Size(62, 41);
            this.Enterbtn.TabIndex = 3;
            this.Enterbtn.Text = "Enter Data";
            this.Enterbtn.UseVisualStyleBackColor = true;
            this.Enterbtn.Click += new System.EventHandler(this.Enterbtn_Click);
            // 
            // Displaybtn
            // 
            this.Displaybtn.Location = new System.Drawing.Point(122, 234);
            this.Displaybtn.Margin = new System.Windows.Forms.Padding(2);
            this.Displaybtn.Name = "Displaybtn";
            this.Displaybtn.Size = new System.Drawing.Size(61, 41);
            this.Displaybtn.TabIndex = 4;
            this.Displaybtn.Text = "Display Data";
            this.Displaybtn.UseVisualStyleBackColor = true;
            this.Displaybtn.Click += new System.EventHandler(this.Displaybtn_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(339, 32);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(189, 212);
            this.listBox.TabIndex = 5;
            // 
            // petNameBox
            // 
            this.petNameBox.Location = new System.Drawing.Point(186, 32);
            this.petNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.petNameBox.Name = "petNameBox";
            this.petNameBox.Size = new System.Drawing.Size(93, 20);
            this.petNameBox.TabIndex = 6;
            // 
            // petAgeBox
            // 
            this.petAgeBox.Location = new System.Drawing.Point(186, 177);
            this.petAgeBox.Margin = new System.Windows.Forms.Padding(2);
            this.petAgeBox.Name = "petAgeBox";
            this.petAgeBox.Size = new System.Drawing.Size(93, 20);
            this.petAgeBox.TabIndex = 7;
            // 
            // petTypeBox
            // 
            this.petTypeBox.Location = new System.Drawing.Point(186, 100);
            this.petTypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.petTypeBox.Name = "petTypeBox";
            this.petTypeBox.Size = new System.Drawing.Size(93, 20);
            this.petTypeBox.TabIndex = 8;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(200, 234);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(61, 41);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close Program";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.petTypeBox);
            this.Controls.Add(this.petAgeBox);
            this.Controls.Add(this.petNameBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Displaybtn);
            this.Controls.Add(this.Enterbtn);
            this.Controls.Add(this.petAgeLabel);
            this.Controls.Add(this.petTypeLabel);
            this.Controls.Add(this.petNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PetForm";
            this.Text = "Pet Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.Label petTypeLabel;
        private System.Windows.Forms.Label petAgeLabel;
        private System.Windows.Forms.Button Enterbtn;
        private System.Windows.Forms.Button Displaybtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox petNameBox;
        private System.Windows.Forms.TextBox petAgeBox;
        private System.Windows.Forms.TextBox petTypeBox;
        private System.Windows.Forms.Button CloseButton;
    }
}

