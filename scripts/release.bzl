"""
This file contains rules to create and deploy a csharp library
as a nuget package.
"""
load(
    "@io_bazel_rules_dotnet//dotnet/private:providers.bzl",
    "DotnetLibraryInfo",
)

###################################
####    Deploy NuGet Package   ####
###################################

def _nuget_deploy(ctx):
    # required files to deploy a package:
    run_files = []

    out_dir = ctx.attr.id

    # get version from --define
    version = ctx.var.get('version', '0.0.0')

    # create spec files
    csproj_file = ctx.actions.declare_file(out_dir + "/%s.csproj" % ctx.attr.id)

    _create_csproj_file(csproj_file, version, ctx)
    run_files.append(csproj_file)
    
    package_args = []
    if len(ctx.files.sources) > 0:
        package_args.append('--include-source')
        package_args.append('--include-symbols')
        package_args.append('-p:IncludeSymbols=true')
        package_args.append('-p:SymbolPackageFormat=snupkg')
        for s in ctx.files.sources:
            f = ctx.actions.declare_file(out_dir + "/" + s.basename)
            ctx.actions.run_shell(
                outputs = [f],
                inputs = [s],
                arguments = [s.path, f.path],
                command = "cp $1 $2",
            )
            run_files.append(f)

    # create nuget config file if required
    result = ctx.actions.declare_file('publish.sh')
    ctx.actions.write(
        output = result,
        content = '''
            set -e
            cd "{project_folder}"
            dotnet restore
            dotnet pack --configuration Release {package_args}
            dotnet nuget push "bin/Release/{id}.{version}.nupkg" --skip-duplicate --source "github"
        '''.format(
            project_folder = csproj_file.short_path.split(csproj_file.basename)[0],
            package_args = ' '.join(package_args),
            id = ctx.attr.id,
            version = version,
        ),
        is_executable = True,
    )
    run_files.append(result)
    return DefaultInfo(
        files = depset([result]),
        executable = result, 
        runfiles = ctx.runfiles(files = run_files)
    )


nuget_deploy = rule(
    attrs = {
        'id': attr.string(
            mandatory = True,
        ),
        'description': attr.string(
            mandatory = True,
        ),
        'sources': attr.label_list(
            allow_files = True,
        ),
        'target_framework': attr.string(
            default = 'netstandard2.1',
        ),
        'internal_deps': attr.label_list(
            doc = """
                This is used to simplify nuspec file creation.
                Internal dependencies need to override the package
                version. We could infer them by checking the workspace name
                or adding some aspect but this is much simpler and has 0 cost.
            """,
        ),
        'deps': attr.label_list(
            doc = """
                This is used to simplify nuspec file creation.
                We need to treat internal and external dependencies 
                differently.
            """,
        ),
        '_nuget_config_tmpl': attr.label(
            allow_single_file = True,
            default = ':NuGet.Config.tmpl',
        ),
        '_csproj_template': attr.label(
            allow_single_file = True,
            default = ":package.csproj.tmpl"
        ),
    },
    executable = True,
    implementation = _nuget_deploy,
)



def _create_csproj_file(csproj_file, internal_version, ctx):
    id = ctx.attr.id
    dependencies = []
    # create dependencies
    # internal
    for dep in ctx.attr.internal_deps:
        dep_version = internal_version
        dep_id = dep[DotnetLibraryInfo].name.split('.dll')[0]
        dependency = '<PackageReference Include="{depId}" Version="{depVersion}" />'.format(
            depId = dep_id,
            depVersion = dep_version,
        )
        dependencies.append(dependency)
    # third party
    for dep in ctx.attr.deps:
        dep_version = _version_tuple_to_string(dep[DotnetLibraryInfo].version)
        dep_id = dep.label.workspace_name
        dependency = '<PackageReference Include="{depId}" Version="{depVersion}" />'.format(
            depId = dep_id,
            depVersion = dep_version,
        )
        dependencies.append(dependency)

    ctx.actions.expand_template(
        template = ctx.file._csproj_template,
        output = csproj_file,
        substitutions = {
            '{id}': id,
            '{description}': ctx.attr.description,
            '{target_framework}': ctx.attr.target_framework,
            '{version}': internal_version,
            '{dependencies}': "\n        ".join(dependencies),
        }
    )

def _version_tuple_to_string(version):
    """Takes a tuple containing version numbers and converts it to string.

    Args:
        version: is a tuple with this form (num1, num2, num3, num4, suffix). 
    Returns:
        a string that represents the input version. It will always add at least
        3 numbers (major.minor.patch), even when their value is zero.
        For example:
            - (1, 1, 0, 0, "") => 1.1.0
            - (2, 3, 4, 5, "") => 2.3.4.5
            - (1, 0, 1, 0, "open") => 1.0.1-open
            - (1, 0, 1, 12, "beta") => 1.0.1-beta.12
    """

    str_ver = "%s" % version[0]
    for v in version[1:3]:
        str_ver += ".%s" % v
    
    if version[4] != "":
        str_ver += "-%s" % version[4]

    if version[3] != 0:
        str_ver += ".%s" % version[3]

    return str_ver
