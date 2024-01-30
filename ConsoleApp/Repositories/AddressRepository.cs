

using ConsoleApp.Contexts;
using ConsoleApp.Entities;
using Microsoft.Identity.Client;

namespace ConsoleApp.Repositories;

internal class AddressRepository : Repo<AddressEntity>
{
    public AddressRepository(DataContext context) : base(context)
    {
    }
}
