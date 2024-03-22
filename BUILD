load("//:csharp_metadata.bzl", "csharp_projects", "GRPC_CSHARP_VERSION", "PROTOBUF_VERSION")

all_projects = csharp_projects + [ "//src/Saltoapis.Auth" ]

filegroup(
    name = 'build_autogenerated',
    srcs = ["{}:{}".format(project, project.split('/')[-1]) for project in all_projects]
)

deploy_commands = ['''echo "bazel run %s:deploy" --define version=$(version)>> $@''' % project for project in all_projects]
genrule(
    name = 'publish_all',
    outs = ['publish_all.sh'],
    cmd = 'echo "set -e" >> $@\n' + '\n'.join(deploy_commands),
    executable = True,
)

# This is the dependencies files used by bazel during the build and release
# Our dependencies depend on the generated code, so we are going to generate this file.
paket_deps_file = '''
source https://api.nuget.org/v3/index.json

storage: none

// Main NuGet packages
nuget Grpc.Net.Client ~> {GRPC_CSHARP_VERSION}
nuget Grpc.Core.Api ~> {GRPC_CSHARP_VERSION}
nuget Google.Protobuf ~> 3.{PROTOBUF_VERSION}
nuget Google.Api.CommonProtos ~> 2.2.0
nuget System.Text.Json ~> 8.0.3

// Test NuGet packages
group Test
    source https://api.nuget.org/v3/index.json
    
    // used to setup a gRPC server for testing
    nuget Grpc.Core ~> 2.46.6
    nuget Microsoft.NETCore.App.Ref 8.0.3
'''.format(
    GRPC_CSHARP_VERSION = GRPC_CSHARP_VERSION,
    PROTOBUF_VERSION = PROTOBUF_VERSION,
)
genrule(
    name = 'paket_dependencies',
    outs = ['paket.dependencies'],
    cmd = "echo '%s' >> $@" % paket_deps_file,
)
