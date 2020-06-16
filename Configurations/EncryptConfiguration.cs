using System;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace ProjetoEscolar.Configurations
{
    public class EncryptConfiguration
    {
        public static string EncryptPassword(string password){ 
            string salt = "21293";

            var valueBytes = KeyDerivation.Pbkdf2(  
                                password: password,  
                                salt: Encoding.UTF8.GetBytes(salt),  
                                prf: KeyDerivationPrf.HMACSHA512,  
                                iterationCount: 10000,  
                                numBytesRequested: 256 / 8);  

            return Convert.ToBase64String(valueBytes);  
        }
    }
}