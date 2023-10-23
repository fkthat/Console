namespace FkThat.Console;

using Console = System.Console;

/// <summary>
/// Represents the system console.
/// </summary>
public sealed class SystemConsole : IConsoleText
{
    /// <inheritdoc/>
    public TextReader In => Console.In;

    /// <inheritdoc/>
    public TextWriter Out => Console.Out;

    /// <inheritdoc/>
    public TextWriter Error => Console.Error;
}
