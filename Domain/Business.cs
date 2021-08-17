using System;

namespace Domainn
{
    public static class Business
    {

        #region Encriptaciones

            public static string Encrypt(string _stringToEncrypt)
            {
                if (!string.IsNullOrEmpty(_stringToEncrypt))
                {
                    string result;

                    byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_stringToEncrypt);

                    result = Convert.ToBase64String(encryted);

                    return result;
                }

                return _stringToEncrypt;
            }

            public static string Decrypt(string _stringToDecrypt)
            {
                if (!string.IsNullOrEmpty(_stringToDecrypt))
                {
                    try
                    {
                        string result;

                        byte[] decryted = Convert.FromBase64String(_stringToDecrypt);

                        result = System.Text.Encoding.Unicode.GetString(decryted);

                        return result;
                    }
                    catch
                    {
                        //return Resource.CorruptedData + _stringToDecrypt;
                    }
                }

                return _stringToDecrypt;
            }

            public static string StringToUpperCase(string word)
            {
                string newWord = string.Empty;

                foreach (char lyrics in word)
                    newWord += char.ToUpper(lyrics);

                return newWord;
            }

        #endregion
    }
}
