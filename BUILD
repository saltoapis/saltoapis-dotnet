load("//:workspace_info.bzl", "all_projects")

filegroup(
    name = 'build_all',
    srcs = ["{}:{}.dll".format(project, project.split('/')[-1]) for project in all_projects]
)

deploy_commands = ['''echo "bazel run %s:deploy" --define version=$(version)>> $@''' % project for project in all_projects]
genrule(
    name = 'publish_all',
    outs = ['publish_all.sh'],
    cmd = 'echo "set -e" >> $@\n' + '\n'.join(deploy_commands),
    executable = True,
)
