# A Sample App Using the .NET Core 2.0 Runtime

This solution contains a sample [https://www.asp.net/](ASP.NET) core application that can run on [https://www.cloudfoundry.org/](Cloud Foundry) installations

## Deployment

1. Install the [https://docs.cloudfoundry.org/cf-cli/install-go-cli.html](cf CLI)
1. Log in to some flavor of Cloud Foundry using `cf login`. If you don't have access to a Cloud Foundry instance, install [https://pivotal.io/pcf-dev](PCF Dev) to deploy the application locally
1. `cd` into the directory for the sample web application
1. Publish the app to a known directory: `dotnet publish -c Release -o ./publish -r linux-x64`
1. `cd` into the newly created publish directory
1. Push to Cloud Foundry with `cf push`

## Contributing
1. Fork the repository
1. Submit a pull request

###### This page was last updated on April 13, 2018