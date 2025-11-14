using Microsoft.AspNetCore.Mvc;
using Random_Forest.Models;
using Random_Forest.Services.Interfaces;

namespace Random_Forest.Routes
{
    public static class HolderRoute
    {
        public static void HolderRoutes(WebApplication app)
        {
            var group = app.MapGroup("/holders");
            
            group.MapPost("/", async (
                [FromServices] IHolderService service, 
                [FromBody] Holder newHolder) =>
            {
                try
                {
                    await service.CreateHolderAsync(newHolder);

                    return Results.Created($"/holders/{newHolder.IdHolder}", newHolder);
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { message = ex.Message });
                }
            });
            
            group.MapGet("/{id}", async (IHolderService service, int id) =>
            {
                var holder = await service.GetHolderByIdAsync(id);
                
                return holder != null ? Results.Ok(holder) : Results.NotFound();
            });
            
            group.MapGet("/", async (IHolderService service) =>
            {
                var holders = await service.GetAllHoldersAsync();
                return Results.Ok(holders);
            });
        }
    }
}