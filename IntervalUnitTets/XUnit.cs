using System;
using Xunit;
using FluentAssertions;
using Moq;
public sealed class Test : FactAttribute 
{
    public static void Assert(bool value) 
    {
        if (!value)
            throw new InvalidOperationException("disegn by contract error.");
    }
}

public sealed class Before : FactAttribute { }

public sealed class Tests : TheoryAttribute { }

public class BeforeEach : FactAttribute { }
