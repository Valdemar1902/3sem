var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var app = builder.Build();

// list for tasks with names and booleans
List<Task> tasks = new List<Task>();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

// GETs
app.MapGet("/", ()=> tasks);

//get alle tasks
app.MapGet("/tasks", ()=> tasks);

// GET efter id
app.MapGet("/tasks/{id}", (int id) => tasks[id]);

// POST data i raw med JSON
app.MapPost("/tasks/add", (Task task) =>
{
    tasks.Add(task);
    return tasks;
});

// PUT for at ændre eksisterende data
app.MapPut("/tasks/{id}", (int id, Task task) =>
{
    tasks[id] = task;
    return tasks;
});

// Delete for at fjerne task
app.MapDelete("/tasks/{id}", (int id) =>
{
    tasks.RemoveAt(id);
    return tasks;
});

app.Run();
public record Task(string Name, bool IsComplete);
