namespace Simias.Encryption
{
	public class Blowfish
	{
		private static byte[] keyByte;

		private const int N = 16;

		private const int KEYBYTES = 8;

		private static uint[] _P;

		private static uint[,] _S;

		private uint[] P;

		private uint[,] S;

		public static byte[] Key => null;

		private static byte[] GetBytes(string str)
		{
			return null;
		}

		public Blowfish(byte[] key)
		{
		}

		private uint F(uint x)
		{
			return 0u;
		}

		public void Encipher(byte[] data, int length)
		{
		}

		private void Encipher(ref uint xl, ref uint xr)
		{
		}

		public void Decipher(byte[] data, int length)
		{
		}

		private void Decipher(ref uint xl, ref uint xr)
		{
		}
	}
}
