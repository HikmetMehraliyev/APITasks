using ClassTaskAPI.DAL;
using ClassTaskAPI.Models.Common;
using ClassTaskAPI.Services.Interfaces.BaseService;
using ClassTaskAPI.Utilities.Exceptions;
using ClassTaskAPI.Utilities.ResponseMessages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace ClassTaskAPI.Services.Implementations.Base;

public class BaseService<T> : IBaseService<T> where T : BaseEntity, new()
{
	private readonly AppDbContext _context;
	private DbSet<T> _dbSet;
	public BaseService(AppDbContext context)
	{
		_context = context;
		_dbSet = _context.Set<T>();
	}


	public void Create(T entity)
	{
        _dbSet.Add(entity);

	}

	public void Delete(T entity)
	{
		_dbSet.Remove(entity);
	}

	public async Task<ResponseMessage> GetALL()
	{
		return new ResponseMessage()
		{
			Data = await _dbSet.ToListAsync(),
			Message = "entities Found",
            StatusCode = System.Net.HttpStatusCode.OK 
        };
	}

	public T GetById(int id)
	{
		T entity = _dbSet.Find(id);
		if (entity == null)
		{
			throw new NotFoundDataException("Don't Send All Info");
        }
		return entity;
	}

	public T Update(T entity)
	{
		 _dbSet.Update(entity);
		return entity;
	}
}
