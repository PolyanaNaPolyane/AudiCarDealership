using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class PasswordHasher : IPasswordHasher
{
    private const int MaxFactor = 13;
    
    public string GetHash(string password) => BCrypt.Net.BCrypt.EnhancedHashPassword(password, MaxFactor);
    public bool VerifyHash(string password, string hash) => BCrypt.Net.BCrypt.EnhancedVerify(password, hash);
}