﻿using AntiGolpista.Domain.Entities.PhonesNumbers;

namespace AntiGolpista.Domain.Repositories.PhoneNumbers;
public interface IUntrustedPhoneNumberRepository
{
    Task<UntrustedPhoneNumber> GetByIdAsync(int id);
    Task<List<UntrustedPhoneNumber>> GetAllAsync();
    Task AddAsync(UntrustedPhoneNumber untrustedPhoneNumber);
    Task DeleteAsync(int id);
}