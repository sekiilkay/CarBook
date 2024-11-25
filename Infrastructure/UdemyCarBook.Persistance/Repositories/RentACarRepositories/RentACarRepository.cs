using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UdemyCarBook.Application.Interfaces.RentACarInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories.RentACarRepositories
{
    public class RentACarRepository(CarBookContext context) : IRentACarRepository
    {
        public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            return await context.RentACars
                .Where(filter)
                .Include(x => x.Car)
                    .ThenInclude(x => x.Brand)
                .ToListAsync();
        }
    }
}
