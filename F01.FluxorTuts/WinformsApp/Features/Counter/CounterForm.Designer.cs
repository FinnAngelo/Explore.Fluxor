namespace Explore.Fluxor.FluxorTuts.WinformsApp.Features.Counter
{
    partial class CounterForm
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
            label1 = new Label();
            lblCurrentCount = new Label();
            btnIncrementCount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Current count:";
            // 
            // lblCurrentCount
            // 
            lblCurrentCount.AutoSize = true;
            lblCurrentCount.Location = new Point(90, 0);
            lblCurrentCount.Name = "lblCurrentCount";
            lblCurrentCount.Size = new Size(0, 15);
            lblCurrentCount.TabIndex = 1;
            // 
            // btnIncrementCount
            // 
            btnIncrementCount.Location = new Point(9, 18);
            btnIncrementCount.Name = "btnIncrementCount";
            btnIncrementCount.Size = new Size(75, 23);
            btnIncrementCount.TabIndex = 2;
            btnIncrementCount.Text = "Click me";
            btnIncrementCount.UseVisualStyleBackColor = true;
            btnIncrementCount.Click += btnIncrementCount_Click;
            // 
            // Counter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(188, 49);
            Controls.Add(btnIncrementCount);
            Controls.Add(lblCurrentCount);
            Controls.Add(label1);
            Name = "Counter";
            Text = "Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCurrentCount;
        private Button btnIncrementCount;
    }
}