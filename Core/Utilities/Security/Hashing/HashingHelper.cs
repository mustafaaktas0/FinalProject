using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //password hash - salt olusturacak
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;//Her kullanıcı için farklı key olusturur
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//bir string byte karsiliğini almak için Encoding.utf8.getBytes() kullandık
            }
        }
        // hash doğrulama işlemi için -- sisiteme sonradan girmeye çalişalar için
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//bir string byte karsiliğini almak için Encoding.utf8.getBytes() kullandık
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
