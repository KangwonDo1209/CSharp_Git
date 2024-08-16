using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFile
{
	internal class FileManager
	{
		public event EventHandler<double> InProgress;
		public void Copy(string srcfile, string destfile)
		{
			byte[] buffer = new byte[1024];
			int pos = 0;

			var fi = new FileInfo(srcfile);
			var fileSize = fi.Length;

			using (BinaryReader rd = new BinaryReader(File.Open(srcfile, FileMode.Open)))
			using (BinaryWriter wr = new BinaryWriter(File.Open(destfile, FileMode.Create)))
			{
				while (pos < fileSize)
				{
					int count = rd.Read(buffer, 0, buffer.Length);
					wr.Write(buffer, 0, count);
					pos += count;

					double pct = ((double)pos / fileSize) * 100;

					if (InProgress != null)
					{
						InProgress(this, pct);
					}
				}
			}
		}
	}
}
