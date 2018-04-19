Note: this is **not** an exhaustive list of all command line options for dotnet.
For a more complete listing, check out the [official documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish?tabs=netcore2x).

##### Configuration (-c)

There are two valid options for configuration: `Debug` and `Release`. To avoid taking a performance hit, use the `Release` option for production code.

##### Output (-o)

Specifies the path to where your application will be published. The default value is `./bin/[configuration]/[framework]/[runtime]`.

##### Runtime (-r)

Publishes your application for a specific platform. When using this flag, you'll notice that the publish outputis much larger. This is because the .NET Core runtime is included for the targeted OS.

The Cloud Foundry buildpack for .NET core works on Linux; it does not offer support for Windows servers. 

This application is published using `linux-x64` as its RID. This is the most generic RID for Linux operating systems. For a complete list of available runtime identifiers, visit [RID catalog](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog).

Note: By providing a runtime parameter, the `self-contained` flag is automatically set to true.