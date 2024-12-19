namespace CharityHub.Domain.IIntegrations;

public interface IAuthProvider
{
    string GetVerifiedPhoneNumber(string requestIdToken);
}