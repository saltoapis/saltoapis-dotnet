load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

# A newer version should be fine
load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")
RULES_DOTNET_COMMIT = "98cc58708e0ea150a8737e7f83a74f0f41ececf8"
http_archive(
    name = "io_bazel_rules_dotnet",
    strip_prefix = "rules_dotnet-%s" % RULES_DOTNET_COMMIT,
    sha256 = "e5111d87a0a1a483a4a992fac860ea930b294ff8331b58a083b6fbaf4f6d31ec",
    url = "https://github.com/bazelbuild/rules_dotnet/archive/%s.zip" % RULES_DOTNET_COMMIT,
)
load("@io_bazel_rules_dotnet//dotnet:deps.bzl", "dotnet_repositories")

dotnet_repositories()

load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "core_register_sdk", "net_register_sdk", "mono_register_sdk",
    "dotnet_register_toolchains", "dotnet_repositories_nugets")

dotnet_register_toolchains()
dotnet_repositories_nugets()
# For .NET Core:
core_register_sdk()
# For .NET Framework:
#net_register_sdk()
# For Mono:
#mono_register_sdk()

load("//scripts:nuget_deps.bzl", "saltoapis_nuget_dependencies")
saltoapis_nuget_dependencies()

# import rules to load environment variables into BUILD files
RULES_BUILD_SECRETS_COMMIT = "103b222eba64355b93649b06ecfe3844466b5a65"
http_archive(
    name = "rules_build_secrets",
    strip_prefix = "rules_build_secrets-%s" % RULES_BUILD_SECRETS_COMMIT,
    sha256 = "e53e46eab662c313f0e011f1c7872602be1d90d988152f89525ce732190e32e7",
    url = "https://github.com/solarhess/rules_build_secrets/archive/%s.zip" % RULES_BUILD_SECRETS_COMMIT,
)

load("@rules_build_secrets//lib:secrets.bzl", "environment_secrets")

environment_secrets(
    name="env_publish", 
    entries = {
        "GITHUB_ACTOR": "",
        "GITHUB_TOKEN": "",
        "GITHUB_SHA": "",
    },
)
