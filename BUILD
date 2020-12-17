load("//:workspace_info.bzl", "all_projects")

filegroup(
    name = 'build_all',
    srcs = ["{}:{}.dll".format(project, project.split('/')[-1]) for project in all_projects]
)
