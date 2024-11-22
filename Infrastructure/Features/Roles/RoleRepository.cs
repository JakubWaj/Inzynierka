﻿using Application.Features.Roles;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Features.Roles;

public class RoleRepository : IRoleRepository
{
    
    private readonly MoviesDbContext _context;

    public RoleRepository(MoviesDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Role>> GetAllAsync()
    {
        return await _context.Roles.ToListAsync();
    }

    public async Task UpdateAsync(Role role)
    {
        _context.Roles.Update(role);
        await _context.SaveChangesAsync();
    }

    public async Task AddAsync(Role role)
    {
        await _context.Roles.AddAsync(role);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid Id)
    {
        var role = await _context.Roles.SingleOrDefaultAsync(x=>x.Id==Id );
        _context.Roles.Remove(role);
        await _context.SaveChangesAsync();
    }

    public async Task<Role> GetAsync(Guid Id)
    {
        return await _context.Roles.SingleOrDefaultAsync(x=>x.Id==Id);
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.Roles.AnyAsync(x=>x.Id==Id);
    }
}
