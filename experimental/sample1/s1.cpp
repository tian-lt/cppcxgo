
ref class Foo
{};

// some comments here
Foo^ create_foo()
{
    return ref new Foo();
}