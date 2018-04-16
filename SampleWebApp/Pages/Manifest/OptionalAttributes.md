Note: this is **not** an exhaustive list of all attributes available in the Cloud Foundry manifest. For a more complete listing, check out the [official documentation](https://docs.cloudfoundry.org/devguide/deploy-apps/manifest.html).

### buildpack

Determines which set of frameworks and runtimes are available to your app. Your Cloud Foundry installation may have a limited number of buildpacks available. To see a list of available buildpacks, run `cf buildpacks`.

### memory

Sets a memory limit for all instances of the application. Defaults to 1GB.

### stack

Specify which stack to use for your application. When using .NET core buildpacks, you must use cflinuxfs2. The buildpack for .NET core does not offer support for windows servers.