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
            lblCurrentCountText = new Label();
            lblCurrentCount = new Label();
            btnIncrementCount = new Button();
            SuspendLayout();
            // 
            // lblCurrentCountText
            // 
            lblCurrentCountText.AutoSize = true;
            lblCurrentCountText.Location = new Point(0, 0);
            lblCurrentCountText.Name = "lblCurrentCountText";
            lblCurrentCountText.Size = new Size(101, 20);
            lblCurrentCountText.TabIndex = 0;
            lblCurrentCountText.Text = "Current count:";
            // 
            // lblCurrentCount
            // 
            lblCurrentCount.AutoSize = true;
            lblCurrentCount.Location = new Point(103, 0);
            lblCurrentCount.Name = "lblCurrentCount";
            lblCurrentCount.Size = new Size(0, 20);
            lblCurrentCount.TabIndex = 1;
            // 
            // btnIncrementCount
            // 
            btnIncrementCount.Location = new Point(10, 24);
            btnIncrementCount.Margin = new Padding(3, 4, 3, 4);
            btnIncrementCount.Name = "btnIncrementCount";
            btnIncrementCount.Size = new Size(86, 31);
            btnIncrementCount.TabIndex = 2;
            btnIncrementCount.Text = "Click me";
            btnIncrementCount.UseVisualStyleBackColor = true;
            btnIncrementCount.Click += btnIncrementCount_Click;
            // 
            // CounterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 65);
            Controls.Add(btnIncrementCount);
            Controls.Add(lblCurrentCount);
            Controls.Add(lblCurrentCountText);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CounterForm";
            Text = "Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentCountText;
        private Label lblCurrentCount;
        private Button btnIncrementCount;
    }
}