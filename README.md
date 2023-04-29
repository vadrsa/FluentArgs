[![Build and Test](https://github.com/vadrsa/FluentArgs/actions/workflows/build-and-test.yml/badge.svg?branch=master)](https://github.com/vadrsa/FluentArgs/actions/workflows/build-and-test.yml) [![NuGet Version](https://buildstats.info/nuget/Utilities.FluentArgs?includePreReleases=true)](https://www.nuget.org/packages/Utilities.FluentArgs/)

# FluentArgs
Argument validation utilities with a fluent API

# Description
When writing business logic classes, it is almost always necessary to check the values of the constructor arguments for correctness and to generate exceptions if the parameters are incorrect. It is necessary to write informative messages. It is tiring. The library is designed to facilitate this routine work.

# Example
## Straightforward way of argument validation
```c#
public Product(string brand, string category, int price, DateTime dateOfProduction)
{
    if (brand == null)
    {
        throw new ArgumentNullException(nameof(brand));
    }

    if (category == null)
    {
        throw new ArgumentNullException(nameof(category));
    }

    if (price <= 0)
    {
        throw new ArgumentException($"Argument '{nameof(price)}' must be greater than 0");
    }

    if (dateOfProduction == DateTime.MinValue)
    {
        throw new ArgumentException($"Argument '{nameof(dateOfProduction)}' must not be MinValue");
    }

    if (dateOfProduction.Kind != DateTimeKind.Utc)
    {
        throw new ArgumentException($"Argument '{nameof(dateOfProduction)}' must be UTC");
    }
    //...
}
```

## Argument Validation with FluentArgs
```c#
public Product(string brand, string category, int price, DateTime dateOfProduction)
{
    brand.Arg(nameof(brand))
        .IsNotNull();
    category.Arg(nameof(category))
        .IsNotNull();
    price.Arg(nameof(price))
        .IsGreaterThan(0);
    dateOfProduction.Arg(nameof(dateOfProduction))
        .IsNotDefault()
        .Is(d => d.Kind == DateTimeKind.Utc);
}
```
