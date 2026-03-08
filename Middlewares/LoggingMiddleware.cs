namespace UserManagementApi.Middlewares {
    public class LoggingMiddleware {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next) => _next = next;

        public async Task InvokeAsync(HttpContext context) {
            Console.WriteLine($"[LOG] {DateTime.Now:T} - {context.Request.Method} {context.Request.Path}");
            await _next(context);
        }
    }
}