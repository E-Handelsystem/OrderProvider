

using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace OrderProvider.Domain.Models;

public abstract class BaseResponseResult 
{
    public bool Success { get; set; }
    public string? Messege { get; set; }
    public int Status { get; set; }
}


public class ResponseResult<T>: BaseResponseResult
{
    public T? Data { get; set; } 
}
public class ResponseResult:BaseResponseResult
{

}
