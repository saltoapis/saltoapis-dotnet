load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "csharp_nunit3_test")

package(default_visibility = ['//:__subpackages__'])

csharp_nunit3_test(
    name = 'interceptor_test.dll',
    srcs = [
        'InterceptorTest.cs',
    ],
    deps = [
        '//src/Saltoapis.Auth:Saltoapis.Auth.dll',
        "@nunit//:lib",
        # required to create the testing server
        '@grpc.core//:lib',
    ],
)
