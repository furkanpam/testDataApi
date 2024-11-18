
namespace Asis.Framework.Integration.Abstraction.Extensions
{
    public static class ErrorCodeExtensions
    {
        //public static BusinessException Throw<T>(this int responseCode, params object[] args)
        //    where T : class, IStatusCode
        //{
        //    return responseCode.ThrowWithName(module.Name, args);
        //}

        //public static BusinessException ThrowWithName<T>(this int responseCode, string name, params object[] args)
        //   where T : IStatusCode
        //{

        //}

        public static Exception GetInnerException(this Exception exception)
        {
            if (exception.InnerException != null)
            {
                return exception.GetInnerException();
            }
            else
            {
                return exception;
            }
        }
    }
}
