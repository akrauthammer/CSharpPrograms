using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Kraut.MathLib
{
    public enum HashType
    {
        MD5,
        SHA1,
        SHA512
    }
    public static class Hasher
    {
        public static string HashFile(string filePath, HashType algo)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open);
            string output = "";
            switch (algo)
            {
                case HashType.MD5:
                    output = MakeHashString(MD5.Create().ComputeHash(stream));
                    break;
                case HashType.SHA1:
                    output = MakeHashString(SHA1.Create().ComputeHash(stream));
                    break;
                case HashType.SHA512:
                    output = MakeHashString(SHA512.Create().ComputeHash(stream));
                    break;
                default:
                    output = "";
                    break;
            }
            stream.Close();
            return output;
        }

        private static string MakeHashString(byte[] hash)
        {
            StringBuilder s = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash)
                s.Append(b.ToString("X2").ToLower());

            return s.ToString();
        }
    }
}
