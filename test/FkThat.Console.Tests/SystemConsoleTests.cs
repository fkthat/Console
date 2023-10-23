namespace FkThat.Console.Tests;

using Console = System.Console;

public sealed class SystemConsoleTests
{
    [Fact]
    public void In_should_return_console_in()
    {
        SystemConsole sut = new();
        sut.In.Should().Be(Console.In);
    }

    [Fact]
    public void Out_should_return_console_out()
    {
        SystemConsole sut = new();
        sut.Out.Should().Be(Console.Out);
    }

    [Fact]
    public void Error_should_return_console_error()
    {
        SystemConsole sut = new();
        sut.Error.Should().Be(Console.Error);
    }
}
