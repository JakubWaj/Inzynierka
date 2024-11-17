using System.Reflection;

namespace Application;

/// <summary>
/// Hook for the application assembly stuff.
/// </summary>
public class ApplicationReference
{
    /// <summary>
    /// Hook for the application assembly stuff.
    /// </summary>
    public static Assembly Assembly { get; } = typeof(ApplicationReference).Assembly;
}