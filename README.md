
# Blaise Questionnaire Data Tool

A Windows Forms UI based tool to make it easier to load data into a Blaise questionnaire questionnaire deployed into our cloud based environment.

## Setup

Blaise only provides a .NET Framework 4.7.2 API, so Visual Studio on Windows is highly recommended.

The Blaise API is not on the global NuGet gallery, we host it in our private Azure DevOps project.

You'll need to add our Azure DevOps NuGet feed to Visual Studio and put your PAT details into your NuGet configuration file.

To add the feed in Visual Studio:

* Menu navigation - Tools > Options > NuGet Package Manager > Package Sources
* Press the plus button to add a new source
* Enter a name and put in the source feed URL - `https://pkgs.dev.azure.com/<ORG>/<PROJ>/_packaging/<FEED>/nuget/v3/index.json`

To put your PAT details into your NuGet configuration file:

Open your NuGet configuration file by running:

```
%appdata%\NuGet\NuGet.Config
```

Add the following to the file:

```
<packageSourceCredentials>
   <<SOURCE_NAME>>
      <add key="Username" value="<USERNAME>" />
      <add key="ClearTextPassword" value="<PAT>" />
   </<SOURCE_NAME>>
</packageSourceCredentials>
```

## Usage

* Start the application in Visual Studio to launch the Windows Forms UI.
* Enter the Blaise connection details in the fields provided.
* Click the Refresh button and the available server parks and questionnaires should be populated.
* Select the desired server park and questionnaire.
* Set the start primary key and how many cases you would like created.
* Click the Create button to start creating cases.

Certain fields such as `QDataBag.TelNo` will always be populated. You can populate any fields you like by providing a case sample is JSON format. An example is provided in the repo, see the `DummySampleData.json` file.
