public static class Environment
{
    public static string GithubUserNameVariable { get; private set; }
    public static string GithubPasswordVariable { get; private set; }
    public static string MyGetApiKeyVariable { get; private set; }
    public static string MyGetSourceUrlVariable { get; private set; }
    public static string NuGetApiKeyVariable { get; private set; }
    public static string NuGetSourceUrlVariable { get; private set; }
    public static string ChocolateyApiKeyVariable { get; private set; }
    public static string ChocolateySourceUrlVariable { get; private set; }
    public static string GitterTokenVariable { get; private set; }
    public static string GitterRoomIdVariable { get; private set; }
    public static string SlackTokenVariable { get; private set; }
    public static string SlackChannelVariable { get; private set; }
    public static string TwitterConsumerKeyVariable { get; private set; }
    public static string TwitterConsumerSecretVariable { get; private set; }
    public static string TwitterAccessTokenVariable { get; private set; }
    public static string TwitterAccessTokenSecretVariable { get; private set; }
    public static string AppVeyorApiTokenVariable { get; private set; }
    public static string CoverallsRepoTokenVariable { get; private set; }
    public static string MicrosoftTeamsWebHookUrl { get; private set; }

    public static void SetVariableNames(
        string githubUserNameVariable = null,
        string githubPasswordVariable = null,
        string myGetApiKeyVariable = null,
        string myGetSourceUrlVariable = null, 
        string nuGetApiKeyVariable = null,
        string nuGetSourceUrlVariable = null, 
        string chocolateyApiKeyVariable = null,
        string chocolateySourceUrlVariable = null,
        string gitterTokenVariable = null,
        string gitterRoomIdVariable = null,
        string slackTokenVariable = null,
        string slackChannelVariable = null,
        string twitterConsumerKeyVariable = null,
        string twitterConsumerSecretVariable = null,
        string twitterAccessTokenVariable = null,
        string twitterAccessTokenSecretVariable = null,
        string appVeyorApiTokenVariable = null,
        string coverallsRepoTokenVariable = null,
        string microsoftTeamsWebHookUrl = null)
    {
        GithubUserNameVariable = githubUserNameVariable ?? "GITHUB_USERNAME";
        GithubPasswordVariable = githubPasswordVariable ?? "GITHUB_PASSWORD";
        MyGetApiKeyVariable = myGetApiKeyVariable ?? "MYGET_API_KEY";
        MyGetSourceUrlVariable = myGetSourceUrlVariable ?? "MYGET_SOURCE";
        NuGetApiKeyVariable = nuGetApiKeyVariable ?? "NUGET_API_KEY";
        NuGetSourceUrlVariable = nuGetSourceUrlVariable ?? "NUGET_SOURCE";
        ChocolateyApiKeyVariable = chocolateyApiKeyVariable ?? "CHOCOLATEY_API_KEY";
        ChocolateySourceUrlVariable = chocolateySourceUrlVariable ?? "CHOCOLATEY_SOURCE";
        GitterTokenVariable = gitterTokenVariable ?? "GITTER_TOKEN";
        GitterRoomIdVariable = gitterRoomIdVariable ?? "GITTER_ROOM_ID";
        SlackTokenVariable = slackTokenVariable ?? "SLACK_TOKEN";
        SlackChannelVariable = slackChannelVariable ?? "SLACK_CHANNEL";
        TwitterConsumerKeyVariable = twitterConsumerKeyVariable ?? "TWITTER_CONSUMER_KEY";
        TwitterConsumerSecretVariable = twitterConsumerSecretVariable ?? "TWITTER_CONSUMER_SECRET";
        TwitterAccessTokenVariable = twitterAccessTokenVariable ?? "TWITTER_ACCESS_TOKEN";
        TwitterAccessTokenSecretVariable = twitterAccessTokenSecretVariable ?? "TWITTER_ACCESS_TOKEN_SECRET";
        AppVeyorApiTokenVariable = appVeyorApiTokenVariable ?? "APPVEYOR_API_TOKEN";
        CoverallsRepoTokenVariable = coverallsRepoTokenVariable ?? "COVERALLS_REPO_TOKEN";
        MicrosoftTeamsWebHookUrl = microsoftTeamsWebHookUrl ?? "MICROSOFTTEAMS_WEBHOOKURL";
    }
}