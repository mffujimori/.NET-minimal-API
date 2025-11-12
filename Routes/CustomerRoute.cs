namespace Random_Forest.Routes;

public static class CustomerRoute
{
    public static void CustomerRoutes(WebApplication app)
    {
        app.MapGet("/customers", () => new
            {
                
            }
        );
    }
}