load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

# A newer version should be fine
RULES_DOTNET_COMMIT = "66a708c64da9126c640b7ca62f03357740d06ea4"
http_archive(
    name = "io_bazel_rules_dotnet",
    strip_prefix = "rules_dotnet-%s" % RULES_DOTNET_COMMIT,
    sha256 = "ad381a06bdcb9c3c349d9005603bfcc8cf56a19d0c500e486bc43e30e78168eb",
    url = "https://github.com/bazelbuild/rules_dotnet/archive/%s.zip" % RULES_DOTNET_COMMIT,
)
load("@io_bazel_rules_dotnet//dotnet:deps.bzl", "dotnet_repositories")
dotnet_repositories()

load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "dotnet_register_toolchains", "dotnet_repositories_nugets")
dotnet_register_toolchains()
dotnet_repositories_nugets()

load("//scripts:nuget_deps.bzl", "saltoapis_nuget_dependencies")
saltoapis_nuget_dependencies()
