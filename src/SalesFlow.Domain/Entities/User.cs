using SalesFlow.Domain.Common;
using SalesFlow.Domain.Exceptions;

namespace SalesFlow.Domain.Entities;

public class User:Entity
{
    public string Name { get; private set; }
    public string Email { get; private set; }


    public User(string name, string email)
    {
        ValidateEntity(name, email);
        Name = name;
        Email = email;
    }

    private void ValidateEntity(string name, string email)
    {
        if(string.IsNullOrWhiteSpace(name)) throw new DomainException("Nome é obrigatorio");
        if(string.IsNullOrWhiteSpace(email)) throw new DomainException("E-mail é obrigatorio");
    }
    
}