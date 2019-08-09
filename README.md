# emojiOnGit

## The app
This app is for the user to be able to see all the emoji images that github has.
A way for me to practice C# and learn a new ide dev tool environment of Visual Studio Code for Mac.

## Putting it together
### This project was built in Visual Studio Code for Mac for a ASP.Net Core and Razor pages app. 
The Emoji.cs class was created to encapsulate the different properties of the emojis. This is where  key value pair properties are made for the service class.
Next I made the Service class, where I call the github api to get the emojis, then passed in a custom 'UserAgent' that's needed for the api. Then the getemojisFrom function converts the json dictionary into a list of emoji objects.
Then I made an interface out of the service class to pass it as an interface and not an instance of a class. Then I can register the class with ASP.Net Core. I do this by going to the Startup.cs file and adding is as a singleton, this is like dependency injection.
Then I went into the page Model the index.cshtml.cs file where I made a constructor to pass the service into, so when the model is created it will automatically be passed to the ASP.
Next a function was created to get the list of emojis and store them as a property. So then all that was left was the html to be able to see the results.

