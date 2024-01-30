

using ConsoleApp.Entities;
using ConsoleApp.Repositories;

namespace ConsoleApp.Services;

internal class AddressService
{
    private readonly AddressRepository _addressRepository;


    public AddressService(AddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }


    public AddressEntity CreateAddress(string streetName, string postalCode, string city)
    {
        var addressEntity = _addressRepository.Get(x => x.StreetName == streetName && x.PostalCode == postalCode && x.City == city);
        addressEntity ??= _addressRepository.Create(new AddressEntity { StreetName = streetName, PostalCode = postalCode, City = city });

        return addressEntity;
    }

    public AddressEntity GetAddress(string streetName, string postalCode, string city)
    {
        var addressEntity = _addressRepository.Get(x => x.StreetName == streetName && x.PostalCode == postalCode && x.City == city);
        return addressEntity;
    }

    public AddressEntity GetAdressById(int id)
    {
        var addressEntity = _addressRepository.Get(x => x.Id == id);
        return addressEntity;
    }

    public IEnumerable<AddressEntity> GetAdresses()
    {
        var addresses = _addressRepository.GetAll();
        return addresses;
    }

    public AddressEntity UpdateAdress(AddressEntity addressEntity)
    {
        var updatedAddressEntity = _addressRepository.Update(x => x.Id == addressEntity.Id, addressEntity);
        return updatedAddressEntity;
    }


    public void DeleteAdress(int id)
    {
        _addressRepository.Delete(x => x.Id == id);
    }

}
