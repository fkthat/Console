namespace FkThat.Console;

using System.Diagnostics.CodeAnalysis;

using Console = System.Console;

/// <summary>
/// Represents the system console.
/// </summary>
public sealed class SystemConsole : IConsoleText, IConsoleStdio
{
    /// <inheritdoc/>
    public TextReader In => Console.In;

    /// <inheritdoc/>
    public TextWriter Out => Console.Out;

    /// <inheritdoc/>
    public TextWriter Error => Console.Error;

    /// <inheritdoc/>
    [ExcludeFromCodeCoverage]
    public Stream OpenStandardInput() => Console.OpenStandardInput();

    /// <inheritdoc/>
    [ExcludeFromCodeCoverage]
    public Stream OpenStandardOutput() => Console.OpenStandardOutput();

    /// <inheritdoc/>
    [ExcludeFromCodeCoverage]
    public Stream OpenStandardError() => Console.OpenStandardError();
}
