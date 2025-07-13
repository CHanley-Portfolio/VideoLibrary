using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using VideoLibrary.Data;

namespace VideoLibrary.Service.Services
{
    public abstract class BaseService(ILogger logger, VideoLibraryContext context)
    {
        protected readonly ILogger Logger = logger;
        protected readonly VideoLibraryContext Context = context;

        protected async Task<T> ProcessMethodAsync<T>(Func<Task<T>> method, [CallerMemberName] string memberName = "")
        {
            var timer = new Stopwatch();
            timer.Start();

            Logger.LogInformation("{MethodName} Started", memberName);

            try
            {
                return await method();
            }
            catch (OperationCanceledException)
            {
                // This exception occurs when an async Task has activated it's Cancellation Token. These shouldn't be logged
                // but forwarded in case they are required further up the call stack
                throw;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "{MethodName} Failed - {Error}", memberName, ex.Message);
                throw;
            }
            finally
            {
                timer.Stop();
                Logger.LogInformation("{MethodName} Completed - {ElapsedTime}", memberName, timer.Elapsed);
            }
        }
    }
}
