using Application.Features.Users;
using Domain.Common.Enums;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Features.Users;

public class UserRepository : IUserRepository
{
    
    private readonly MoviesDbContext _context;

    public UserRepository(MoviesDbContext context)
    {
        _context = context;
    }

    
    public async Task AddAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid Id)
    {
        var user = await _context.Users.FindAsync(Id);
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<User>> GetAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> GetAsync(Guid Id)
    {
        return await _context.Users.Include(x=>x.WatchedMovies).Include(x=>x.FavoriteMovies).FirstOrDefaultAsync(x=>x.Id==Id);
    }

    public async Task<User> GetByEmail(string Email)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Email == Email);
    }

    public async Task<User> GetByLogin(string Login)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Login == Login);
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.Users.AnyAsync(x => x.Id == Id);
    }

    public async Task<bool> ExistsByEmail(string Email)
    {
        return await _context.Users.AnyAsync(x => x.Email == Email);
    }

    public async Task<bool> ExistsByLogin(string Login)
    {
        return await _context.Users.AnyAsync(x => x.Login == Login);
    }

    public async Task SendFriendRequestAsync(UserFriends userFriends)
    {
        await _context.UserFriends.AddAsync(userFriends);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<UserFriends>> GetFriendsRequestsAsync(Guid UserId)
    {
        return await _context.UserFriends.Where(x => x.FriendId == UserId && x.Status==Status.Pending).ToListAsync();
    }

    public async Task<IEnumerable<User>> GetFriendsRequestsUsersAsync(Guid UserId)
    {
        var friendsIds= await _context.UserFriends.Where(x => x.FriendId == UserId   && x.Status==Status.Pending).ToListAsync();
        var friends = await _context.Users.Where(x => friendsIds.Select(x => x.UserId).Contains(x.Id)).ToListAsync();
        return friends;
    }

    public async Task RespondToFriendRequestAsync(Guid Id, Status status)
    {
        var userFriend = await _context.UserFriends.FindAsync(Id);
        userFriend.Status = status;
        _context.UserFriends.Update(userFriend);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<User>> GetFriendsAsync(Guid UserId)
    {
        var friendsIds = await _context.UserFriends.Where(x => (x.FriendId == UserId|| x.UserId==UserId) && x.Status==Status.Accepted).ToListAsync();
        var friends = await _context.Users.Where(x => (friendsIds.Select(x => x.FriendId).Contains(x.Id)||friendsIds.Select(x => x.UserId).Contains(x.Id))).ToListAsync();
        return friends;
    }

    public async Task<UserFriends> GetRequestAsync(Guid UserId, Guid FriendId)
    {
        return await _context.UserFriends.FirstOrDefaultAsync(x => x.UserId == UserId && x.FriendId == FriendId);
    }
}