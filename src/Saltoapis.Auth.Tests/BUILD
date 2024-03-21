load("@rules_dotnet//dotnet:defs.bzl", "csharp_nunit_test")

package(default_visibility = ['//:__subpackages__'])

csharp_nunit_test(
    name = 'interceptor_test',
    srcs = [
        'InterceptorTest.cs',
    ],
    deps = [
        '//src/Saltoapis.Auth:Saltoapis.Auth',
        '@paket.test//grpc.core',
    ],
    target_frameworks = ['net8.0'],
    targeting_packs = [
        # required to create the testing server
        "@paket.test//microsoft.netcore.app.ref",
    ],
)
