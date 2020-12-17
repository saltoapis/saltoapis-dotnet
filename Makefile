
SHELL = /bin/bash

REPORTS_DIR ?= .reports

# Overridable by CI
COMMIT_SHORT     ?= $(shell git rev-parse --verify --short HEAD)
VERSION_NOPREFIX ?= "0.0.0-sha.$(COMMIT_SHORT)"
VERSION          ?= "v$(VERSION_NOPREFIX)"

.PHONY: prepare
prepare:
	# set auth
	dotnet nuget add source https://github.com/saltoapis/saltoapis-dotnet -n github  -u $$GITHUB_ACTOR -p $$GITHUB_TOKEN  --store-password-in-clear-text
	# Encryption is not supported on non-Windows platforms.


.PHONY: sanity-check
sanity-check:

.PHONY: build
build:
	bazel build :build_all

.PHONY: test
test:

.PHONY: release
release:
	# get all deploy rules and execute them
	bazel query 'kind(nuget_deploy, ...:*)' | xargs -L1 sh -c 'bazel run $$0 || exit 255'

.PHONY: clean
clean:
	bazel clean
