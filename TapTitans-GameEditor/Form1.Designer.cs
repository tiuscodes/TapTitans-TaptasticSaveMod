namespace TapTitans_GameEditor
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGameSave = new System.Windows.Forms.RichTextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentLen = new System.Windows.Forms.Label();
            this.lblInitialLen = new System.Windows.Forms.Label();
            this.lblDifference = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSaveModifications = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(73, 214);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(343, 20);
            this.txtInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hash:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(512, 242);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(129, 41);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(73, 253);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(343, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 300);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(396, 63);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "GameSave:";
            // 
            // txtGameSave
            // 
            this.txtGameSave.Location = new System.Drawing.Point(32, 65);
            this.txtGameSave.Name = "txtGameSave";
            this.txtGameSave.Size = new System.Drawing.Size(609, 134);
            this.txtGameSave.TabIndex = 7;
            this.txtGameSave.Text = "";
            this.txtGameSave.TextChanged += new System.EventHandler(this.txtGameSave_TextChanged);
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(521, 212);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(120, 23);
            this.btnHash.TabIndex = 1;
            this.btnHash.Text = "Generate Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDifference);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblInitialLen);
            this.groupBox1.Controls.Add(this.lblCurrentLen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(662, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 129);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Helpers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Length:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Initial Length:";
            // 
            // lblCurrentLen
            // 
            this.lblCurrentLen.AutoSize = true;
            this.lblCurrentLen.Location = new System.Drawing.Point(114, 30);
            this.lblCurrentLen.Name = "lblCurrentLen";
            this.lblCurrentLen.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentLen.TabIndex = 2;
            this.lblCurrentLen.Text = "0";
            // 
            // lblInitialLen
            // 
            this.lblInitialLen.AutoSize = true;
            this.lblInitialLen.Location = new System.Drawing.Point(114, 58);
            this.lblInitialLen.Name = "lblInitialLen";
            this.lblInitialLen.Size = new System.Drawing.Size(13, 13);
            this.lblInitialLen.TabIndex = 3;
            this.lblInitialLen.Text = "0";
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Location = new System.Drawing.Point(114, 88);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(13, 13);
            this.lblDifference.TabIndex = 7;
            this.lblDifference.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Difference:";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(526, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(115, 27);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open Gamesave...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSaveModifications
            // 
            this.btnSaveModifications.Location = new System.Drawing.Point(464, 289);
            this.btnSaveModifications.Name = "btnSaveModifications";
            this.btnSaveModifications.Size = new System.Drawing.Size(177, 63);
            this.btnSaveModifications.TabIndex = 3;
            this.btnSaveModifications.Text = "Save Modifications";
            this.btnSaveModifications.UseVisualStyleBackColor = true;
            this.btnSaveModifications.Click += new System.EventHandler(this.btnSaveModifications_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 396);
            this.Controls.Add(this.btnSaveModifications);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.txtGameSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Tap Titans - SaveFile Mod";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtGameSave;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInitialLen;
        private System.Windows.Forms.Label lblCurrentLen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSaveModifications;
    }
}

