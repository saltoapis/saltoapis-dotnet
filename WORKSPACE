load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

# A newer version should be fine
RULES_DOTNET_COMMIT = "b837c72f050103168f7ef2507896408e6c2484cc"
http_archive(
    name = "io_bazel_rules_dotnet",
    strip_prefix = "rules_dotnet-%s" % RULES_DOTNET_COMMIT,
    sha256 = "c957d346ebc122b28c138157e6db5772eab0753302fb0df9fa0ff618f9fc5ed9",
    url = "https://github.com/bazelbuild/rules_dotnet/archive/%s.zip" % RULES_DOTNET_COMMIT,
)
load("@io_bazel_rules_dotnet//dotnet:deps.bzl", "dotnet_repositories")

dotnet_repositories()

load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "core_register_sdk",
    "dotnet_register_toolchains", "dotnet_repositories_nugets")

dotnet_register_toolchains()
dotnet_repositories_nugets()
# For .NET Core: 
core_register_sdk(core_version = "v3.1.100", name = "core_sdk_v3.1.100")
# default sdk
core_register_sdk()


load("//scripts:nuget_deps.bzl", "saltoapis_nuget_dependencies")
saltoapis_nuget_dependencies()
