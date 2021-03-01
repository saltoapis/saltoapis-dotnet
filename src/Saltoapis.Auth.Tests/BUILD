load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "core_nunit3_test")

package(default_visibility = ['//:__subpackages__'])

core_nunit3_test(
    name = 'interceptor_test.dll',
    srcs = [
        'InterceptorTest.cs',
    ],
    deps = [
        '//src/Saltoapis.Auth:Saltoapis.Auth.dll',

        "@nunit//:core",
    ],
)