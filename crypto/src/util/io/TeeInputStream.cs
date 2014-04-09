using System;
using System.Diagnostics;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	public class TeeInputStream
		: BaseInputStream
	{
		private readonly Stream input, tee;

		public TeeInputStream(Stream input, Stream tee)
		{
			Debug.Assert(input.CanRead);
			Debug.Assert(tee.CanWrite);

			this.input = input;
			this.tee = tee;
		}

#if PORTABLE

        private bool isDisposed;
        protected override void Dispose(bool disposing)
        {
            if (disposing && !isDisposed)
            {
                input.Dispose();
                tee.Dispose();
                isDisposed = true;
            }
            base.Dispose(disposing);
        }

#else

        public override void Close()
		{
			input.Close();
			tee.Close();
		}

#endif

		public override int Read(byte[] buf, int off, int len)
		{
			int i = input.Read(buf, off, len);

			if (i > 0)
			{
				tee.Write(buf, off, i);
			}

			return i;
		}

		public override int ReadByte()
		{
			int i = input.ReadByte();

			if (i >= 0)
			{
				tee.WriteByte((byte)i);
			}

			return i;
		}
	}
}
