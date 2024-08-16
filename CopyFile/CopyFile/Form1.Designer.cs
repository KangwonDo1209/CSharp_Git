namespace CopyFile
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
			btnCopy = new Button();
			progressBar1 = new ProgressBar();
			lblPct = new Label();
			SuspendLayout();
			// 
			// btnCopy
			// 
			btnCopy.Location = new Point(225, 50);
			btnCopy.Name = "btnCopy";
			btnCopy.Size = new Size(150, 80);
			btnCopy.TabIndex = 0;
			btnCopy.Text = "파일 복사 시작";
			btnCopy.UseVisualStyleBackColor = true;
			btnCopy.Click += button1_Click;
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(100, 180);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(400, 25);
			progressBar1.TabIndex = 1;
			progressBar1.Click += progressBar1_Click;
			// 
			// lblPct
			// 
			lblPct.AutoSize = true;
			lblPct.Location = new Point(280, 250);
			lblPct.Name = "lblPct";
			lblPct.Size = new Size(28, 15);
			lblPct.TabIndex = 2;
			lblPct.Text = "0 %";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 361);
			Controls.Add(lblPct);
			Controls.Add(progressBar1);
			Controls.Add(btnCopy);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		internal ProgressBar progressBar1;
		internal Button btnCopy;
		internal Label lblPct;
	}
}
