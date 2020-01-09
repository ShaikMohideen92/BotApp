nuget restore
msbuild QnABot.sln -p:DeployOnBuild=true -p:PublishProfile=cvnew-bot-Web-Deploy.pubxml -p:Password=TBluMjokLaJJyXpteJJp4YKPaPayPmlXczFqnQMy3KrrbJcRKaeSwfQRSqAv

