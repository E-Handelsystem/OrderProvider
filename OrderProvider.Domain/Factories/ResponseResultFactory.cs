using OrderProvider.Domain.Models;

namespace OrderProvider.Domain.Factories;

public class ResponseResultFactory
{

    public static ResponseResult Success(int status = 200, string message = null!)
    {
        return new ResponseResult
        {
            Success = true,
            Status = status,
            Messege = message

        };
    }

    public static ResponseResult<T> Success<T>(T Data, int status = 200, string message = null!)
    {
        return new ResponseResult<T>
        {
            Success = true,
            Status = status,
            Messege = message,
            Data= Data

        };
    }

    public static ResponseResult failed(int status = 400, string message = null!)
    {
        return new ResponseResult
        {
            Success = false,
            Status = status,
            Messege = message

        };
    }

    public static ResponseResult<T> failed<T>(T Data, int status = 400, string message = null!)
    {
        return new ResponseResult<T>
        {
            Success = false,
            Status = status,
            Messege = message,
            Data = Data

        };
    }


    public static ResponseResult Exists(int status = 409, string message = null!)
    {
        return new ResponseResult
        {
            Success = false,
            Status = status,
            Messege = message

        };
    }

    public static ResponseResult<T> Exists<T>(T Data, int status = 409, string message = null!)
    {
        return new ResponseResult<T>
        {
            Success = false,
            Status = status,
            Messege = message,
            Data = Data

        };
    }

    public static ResponseResult NotFound(int status = 404, string message = null!)
    {
        return new ResponseResult
        {
            Success = false,
            Status = status,
            Messege = message

        };
    }

    public static ResponseResult<T> NotFound<T>(T data, int status = 404, string message = null!)
    {
        return new ResponseResult<T>
        {
            Success = false,
            Status = status,
            Messege = message,
            Data = data

        };
    }

}
