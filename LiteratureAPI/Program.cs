var builder = WebApplication.CreateBuilder(args);

/*
 Registers everything needed for Web API Development, see 
https://stackoverflow.com/questions/75641248/what-exactly-does-builder-services-addcontrollers-do
https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-9.0
 */
builder.Services.AddControllers();

var app = builder.Build();

/*
 Setup route matching
 https://stackoverflow.com/questions/76949213/how-does-the-userouting-method-work-in-asp-net-core
 https://www.tektutorialshub.com/asp-net-core/asp-net-core-middleware-request-pipeline/

"UseRouting adds route matching to the middleware pipeline. 
This middleware looks at the set of endpoints defined in the app, 
and selects the best match based on the request."
 */
app.UseRouting();

/*
 Setup an EndpointMiddleware, mapping our controllers to it...?
 "UseEndpoints adds endpoint execution to the middleware pipeline. 
It runs the delegate associated with the selected endpoint."
 */
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers();
});

app.Run();
