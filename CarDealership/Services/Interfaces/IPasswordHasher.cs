namespace CarDealership.Services.Interfaces;

public interface IPasswordHasher
{
    string GetHash(string password);
    bool VerifyHash(string password, string hash);
}