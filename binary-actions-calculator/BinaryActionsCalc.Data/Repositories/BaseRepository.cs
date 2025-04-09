using BinaryActionsCalc.Data.Context;
using BinaryActionsCalc.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Data.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        public readonly BinaryActionsContext _dbContext;

        public BaseRepository(BinaryActionsContext dbContext): base()
        {
            _dbContext = dbContext;
        }


        public void Create<TEntity>(TEntity entity) where TEntity : class
        {
            _dbContext.Add(entity);
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            _dbContext.Update(entity);
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            _dbContext.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
