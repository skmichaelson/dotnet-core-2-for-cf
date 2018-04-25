# A Sample App Using the .NET Core 2.0 Runtime

This solution contains a sample [ASP.NET](https://www.asp.net) core application that can run on [Cloud Foundry](https://www.cloudfoundry.org/) installations.

## Deployment

##### 
1. Install the [latest .NET SDK](https://www.microsoft.com/net/download). The .NET cli is bundled with the SDK.

1. Install [npm](https://www.npmjs.com/get-npm). This is used to manage Bootstrap and its dependencies.

##### Set up Cloud Foundry
If you don't have access to a Cloud Foundry instance, install [PCF Dev](https://pivotal.io/pcf-dev) to deploy the application locally.

1. Install the [cf CLI](https://docs.cloudfoundry.org/cf-cli/install-go-cli.html).

1. Log into Cloud Foundry:

	`cf login [-a API_URL]`

##### Publish the project
1. Clone this repository:

	`git clone https://github.com/skmichaelson/dotnet-core-2-for-cf.git`

1. Open the subdirectory for SampleWebApp in the Git repository:

	`cd dotnet-core-2-for-cf/SampleWebApp`

1. Run `npm install` to populate the node modules.

1. Publish the app to a known directory: 

	`dotnet publish -c Release -o ./publish -r linux-x64`

##### Final steps
1. Open the directory with your published files:

	`cd publish`

1. Push to Cloud Foundry:

	`cf push`

## Contributing

1. Fork the repository
1. Submit a pull request

## Coming Soon
1. Instructions on how to create new pages
1. Include a section about different versions of .NET core

###### This page was last updated on April 25, 2018