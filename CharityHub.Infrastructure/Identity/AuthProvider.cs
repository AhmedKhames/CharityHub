using CharityHub.Domain.IIntegrations;

namespace CharityHub.Infrastructure.Integrations;

public class AuthProvider: IAuthProvider
{
    public string GetVerifiedPhoneNumber(string requestIdToken)
    {
        throw new NotImplementedException();
    }
}