using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public interface IStreamGenerator
#if PORTABLE
        : IDisposable
#endif
	{
		void Close();
	}
}
