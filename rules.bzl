"""
This file contains a macro named `load_rules` used to build all the libraries (automatic
and manually generated) in this project. That macro adds rules to build and release each
of the libraries.
"""

load("@rules_dotnet//dotnet:defs.bzl", "csharp_library")
load("//scripts:release.bzl", "nuget_deploy")

def load_rules(lib_name, internal_dependencies, extra_info):
    """A macro that loads common rules for all the packages
    
    Args:
        lib_name: the name of the package
        internal_dependencies: the internal dependencies of the package
        extra_info: additional information required by the following rules (android package, maven group name)
    """

    lib_deps = []
    for dep in internal_dependencies:
        package_name = dep.split('/')[-1] # get everything from last /
        lib_deps.append('{}:{}'.format(dep, package_name))
    

    third_party_deps = [
        "@paket.main//grpc.net.client",
        "@paket.main//grpc.core.api",
        "@paket.main//google.protobuf",
        "@paket.main//google.api.commonprotos",
    ]
    
    if  'extra_deps' in extra_info:
        third_party_deps += extra_info['extra_deps']
    
    target_framework = "netstandard2.0"

    csharp_library(
        name = lib_name,
        srcs = native.glob(['*.cs']),
        deps = third_party_deps + lib_deps,
        target_frameworks = [target_framework],
        targeting_packs = [
            "@paket.main//netstandard.library",
        ],
    )

    project_description = "Contains the SDK related to '%s'. Check out https://developer.saltosystems.com/nebula/ for more information" % lib_name
    if 'nuget_description' in extra_info:
        project_description = extra_info['nuget_description']
    # package will use version from 'csharp_library' by default 
    # but can be overriden by using --define version=1.0.0 
    nuget_deploy(
        name = 'deploy',
        id = lib_name,
        description = project_description,
        target_framework = target_framework,
        sources = native.glob(['*.cs']),
        deps = third_party_deps,
        internal_deps = lib_deps,
    )
