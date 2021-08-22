namespace Dtat.Security
{
	public static class Hashing
	{
		static Hashing()
		{
		}

		public static string ComputeMD5(string rawData)
		{
			using System.Security.Cryptography.MD5
				hash = System.Security.Cryptography.MD5.Create();

			byte[] bytes =
				hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));

			var builder =
				new System.Text.StringBuilder();

			for (int index = 0; index < bytes.Length; index++)
			{
				builder.Append(bytes[index].ToString("x2"));
			}

			string result =
				builder.ToString();

			return result;
		}

		public static string ComputeSha1(string rawData)
		{
			using System.Security.Cryptography.SHA1
				hash = System.Security.Cryptography.SHA1.Create();

			byte[] bytes =
				hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));

			var builder =
				new System.Text.StringBuilder();

			for (int index = 0; index < bytes.Length; index++)
			{
				builder.Append(bytes[index].ToString("x2"));
			}

			string result =
				builder.ToString();

			return result;
		}

		public static string ComputeSha256(string rawData)
		{
			using System.Security.Cryptography.SHA256
				hash = System.Security.Cryptography.SHA256.Create();

			byte[] bytes =
				hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));

			var builder =
				new System.Text.StringBuilder();

			for (int index = 0; index < bytes.Length; index++)
			{
				builder.Append(bytes[index].ToString("x2"));
			}

			string result =
				builder.ToString();

			return result;
		}

		public static string ComputeSha384(string rawData)
		{
			using System.Security.Cryptography.SHA384
				hash = System.Security.Cryptography.SHA384.Create();

			byte[] bytes =
				hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));

			var builder =
				new System.Text.StringBuilder();

			for (int index = 0; index < bytes.Length; index++)
			{
				builder.Append(bytes[index].ToString("x2"));
			}

			string result =
				builder.ToString();

			return result;
		}

		public static string ComputeSha512(string rawData)
		{
			using System.Security.Cryptography.SHA512
				hash = System.Security.Cryptography.SHA512.Create();

			byte[] bytes =
				hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));

			var builder =
				new System.Text.StringBuilder();

			for (int index = 0; index < bytes.Length; index++)
			{
				builder.Append(bytes[index].ToString("x2"));
			}

			string result =
				builder.ToString();

			return result;
		}
	}
}
