﻿

using ConsoleApp.Entities;
using ConsoleApp.Repositories;

namespace ConsoleApp.Services;

internal class RoleService
{
    private readonly RoleRepository _roleRepository;

    public RoleService(RoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public RoleEntity CreateRole(string roleName)
    {
        var roleEntity = _roleRepository.Get(x => x.RoleName == roleName);
        roleEntity ??= _roleRepository.Create(new RoleEntity { RoleName = roleName });

        return roleEntity;
    }

    public RoleEntity GetRole(string roleName)
    {
        var roleEntity = _roleRepository.Get(x => x.RoleName == roleName);
        return roleEntity;
    }

    public RoleEntity GetRoleById(int id)
    {
        var roleEntity = _roleRepository.Get(x => x.Id == id);
        return roleEntity;
    }

    public IEnumerable<RoleEntity> GetRoles()
    {
        var roles = _roleRepository.GetAll();
        return roles;
    }

    public RoleEntity UpdateRole(RoleEntity RoleEntity)
    {
        var updatedRoleEntity = _roleRepository.Update(x => x.Id == RoleEntity.Id, RoleEntity);
        return updatedRoleEntity;
    }


    public void DeleteRole(int id)
    {
        _roleRepository.Delete(x => x.Id == id);
    }


}
