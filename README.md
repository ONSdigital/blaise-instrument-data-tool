
# Blaise Instrument Data Tool

A tool to make it easier to load data into a Blaise questionnaire instrument deployed into our Cloud based environment.

## Setup

Blaise only provides a .NET Framework 4.7.2 API, so Visual Studio on Windows is highly recommended.

The Blaise API is not on the global NuGet gallery, we host it in our private Azure DevOps project.

You'll need to add our Azure DevOps NuGet feed to Visual Studio and put your PAT details into your NuGet configuration file.

To add the feed in Visual Studio:

* Menu navigation - Tools > Options > NuGet Package Manager > Package Sources
* Press the plus button to add a new source
* Enter a name and put in the source feed URL - `https://pkgs.dev.azure.com/<org>/<proj>/_packaging/<feed>/nuget/v3/index.json`

To put your PAT details into your NuGet configuration file:

Open your NuGet configuration file by running:

```
%appdata%\NuGet\NuGet.Config
```

Add the following to the file:

```
<packageSourceCredentials>
   <<source_name>>
      <add key="Username" value="<username>" />
      <add key="ClearTextPassword" value="<password>" />
   </<source_name>>
</packageSourceCredentials>
```

## Usage

