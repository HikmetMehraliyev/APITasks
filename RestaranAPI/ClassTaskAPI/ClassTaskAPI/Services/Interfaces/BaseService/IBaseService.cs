using ClassTaskAPI.Utilities.ResponseMessages;

namespace ClassTaskAPI.Services.Interfaces.BaseService;

public interface IBaseService<T>
{
	public void Create(T entity);
	public T Update(T entity);
	public void Delete(T entity);
	public T GetById(int id);
	public Task<ResponseMessage> GetALL();
}
