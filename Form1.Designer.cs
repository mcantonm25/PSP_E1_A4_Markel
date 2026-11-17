namespace PSP_E1_A4_Markel
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
            buttonNotepad = new Button();
            buttonItxiNotepad = new Button();
            buttonSistemarenProzesuak = new Button();
            comboBoxProzesuak = new ComboBox();
            labelID = new Label();
            SuspendLayout();
            // 
            // buttonNotepad
            // 
            buttonNotepad.Location = new Point(40, 47);
            buttonNotepad.Name = "buttonNotepad";
            buttonNotepad.Size = new Size(140, 86);
            buttonNotepad.TabIndex = 0;
            buttonNotepad.Text = "Notepad";
            buttonNotepad.UseVisualStyleBackColor = true;
            buttonNotepad.Click += buttonNotepad_Click;
            // 
            // buttonItxiNotepad
            // 
            buttonItxiNotepad.Location = new Point(236, 47);
            buttonItxiNotepad.Name = "buttonItxiNotepad";
            buttonItxiNotepad.Size = new Size(140, 86);
            buttonItxiNotepad.TabIndex = 1;
            buttonItxiNotepad.Text = "Itxi Notepad";
            buttonItxiNotepad.UseVisualStyleBackColor = true;
            buttonItxiNotepad.Click += button2_Click;
            // 
            // buttonSistemarenProzesuak
            // 
            buttonSistemarenProzesuak.Location = new Point(40, 158);
            buttonSistemarenProzesuak.Name = "buttonSistemarenProzesuak";
            buttonSistemarenProzesuak.Size = new Size(140, 86);
            buttonSistemarenProzesuak.TabIndex = 2;
            buttonSistemarenProzesuak.Text = "Sistemaren prozesuak";
            buttonSistemarenProzesuak.UseVisualStyleBackColor = true;
            buttonSistemarenProzesuak.Click += buttonSistemarenProzesuak_Click;
            // 
            // comboBoxProzesuak
            // 
            comboBoxProzesuak.FormattingEnabled = true;
            comboBoxProzesuak.Location = new Point(236, 191);
            comboBoxProzesuak.Name = "comboBoxProzesuak";
            comboBoxProzesuak.Size = new Size(173, 23);
            comboBoxProzesuak.TabIndex = 4;
            comboBoxProzesuak.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(425, 83);
            labelID.Name = "labelID";
            labelID.Size = new Size(0, 15);
            labelID.TabIndex = 5;
            labelID.Click += labelID_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 293);
            Controls.Add(labelID);
            Controls.Add(comboBoxProzesuak);
            Controls.Add(buttonSistemarenProzesuak);
            Controls.Add(buttonItxiNotepad);
            Controls.Add(buttonNotepad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNotepad;
        private Button buttonItxiNotepad;
        private Button buttonSistemarenProzesuak;
        private ComboBox comboBoxProzesuak;
        private Label labelID;
    }
}
