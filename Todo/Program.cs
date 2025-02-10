var builder = WebApplication.CreateBuilder(args);

var AllowCors = "_AllowCors";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowCors, builder => {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors(AllowCors);

// list for tasks with names and booleans
List<Task> tasks = new List<Task>();

//get alle tasks
app.MapGet("/tasks/", ()=> tasks);

// GET efter id
app.MapGet("/tasks/{id}", (int id) => tasks[id]);

// POST data i raw med JSON
app.MapPost("/tasks/", (Task task) =>
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
public record Task(long Id, string Text, bool Done);
