using Xunit;
using FluentAssertions;
using Moq;
public sealed class Test : FactAttribute { }

public sealed class Before : FactAttribute { }

public sealed class Tests : TheoryAttribute { }

public class BeforeEach : FactAttribute { }