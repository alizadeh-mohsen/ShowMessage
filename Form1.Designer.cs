namespace ShowMessage
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
            btnDispaly = new Button();
            btnWorld = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnDispaly
            // 
            btnDispaly.Location = new Point(65, 35);
            btnDispaly.Name = "btnDispaly";
            btnDispaly.Size = new Size(253, 29);
            btnDispaly.TabIndex = 0;
            btnDispaly.Text = "Dispaly Hello";
            btnDispaly.UseVisualStyleBackColor = true;
            btnDispaly.Click += btnDispaly_Click;
            // 
            // btnWorld
            // 
            btnWorld.Location = new Point(65, 88);
            btnWorld.Name = "btnWorld";
            btnWorld.Size = new Size(253, 29);
            btnWorld.TabIndex = 1;
            btnWorld.Text = "Dispaly World";
            btnWorld.UseVisualStyleBackColor = true;
            btnWorld.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(147, 154);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Develop";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnWorld);
            Controls.Add(btnDispaly);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDispaly;
        private Button btnWorld;
        private Button button1;
    }
}