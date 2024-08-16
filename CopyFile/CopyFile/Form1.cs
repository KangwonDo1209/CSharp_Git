using CopyFile;
using System.Diagnostics;

namespace CopyFile
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Lsoad(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Thread t = new Thread(CopyFile);
			t.Start();
		}
		private void CopyFile()
		{
			FileManager fm = new FileManager();
			fm.InProgress += Fm_InProgress;
			fm.InProgress += Fm_InProgress2;
			fm.Copy("src.mp4", "dest.mp4");
		}

		private void Fm_InProgress2(object? sender, double e)
		{
			Debug.WriteLine("Progress {0}", e);
		}

		private void Fm_InProgress(object? sender, double e)
		{
			if (InvokeRequired) // UI 스레드인 경우
			{
				Invoke(new EventHandler<double>(Fm_InProgress), sender, e);
			}
			else
			{
				this.progressBar1.Value = (int)e;
				this.lblPct.Text = string.Format("{0} %", (int)e);
			}

		}

		private void progressBar1_Click(object sender, EventArgs e)
		{

		}
	}
}