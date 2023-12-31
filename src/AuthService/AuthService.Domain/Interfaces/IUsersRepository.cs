﻿#region

using AuthService.Domain.Entities;

#endregion

namespace AuthService.Domain.Interfaces;

public interface IUsersRepository : IDisposable
{
    Task<string> AddAsyncWithDefaultRole(ApplicationUser user, CancellationToken cancellationToken = default);

    Task<ApplicationUser?> GetByIdAsync(string id, CancellationToken cancellationToken = default);

    Task<List<ApplicationUser>> GetAllAsync(CancellationToken cancellationToken = default);

    Task SaveAsync(CancellationToken cancellationToken = default);
    Task<bool> CanConnectAsync(CancellationToken cancellationToken = default);
    bool IsEmailInUse(string email);
    Task<ApplicationUser?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

    Task ConfirmEmailAsync(string currentUserId, CancellationToken cancellationToken = default);
    Task ConfirmPhoneNumberAsync(string currentUserId, CancellationToken cancellationToken = default);
}