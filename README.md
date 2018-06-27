# .NET Full-Stack Coding Challenge

Create a web site that provides users the ability to review and vote on various dog images.

# Requirements

* A user can browse available dog pictures
* A user can vote on a picture
* A user can vote only once per picture
* A user can see how many votes have been made for a picture
* A user can see the breed of the dog in the presented picture

# Setup

You will receive two invitations to Gitlab.com. The first is to the [dotnet_code_challenge](https://gitlab.com/disney-studio/dotnet_code_challenge). The second is to your own private repository. 

Please follow these steps:

1. Clone [dotnet_code_challenge](https://gitlab.com/disney-studio/dotnet_code_challenge) to your local workstation. 
2. Follow the instructions on the home page of your private repository to initialize it on your local workstation.
3. Copy the code from the local copy of [dotnet_code_challenge](https://gitlab.com/disney-studio/dotnet_code_challenge) to initialize your private repository.
4. Push the copied code to the remote of your private repository.
5. Push your edits to your private repository as you go.

Please consider that the code you submit as your final push should represent what you would put into Production. Include whatever components, frameworks, or patterns you would rely on in Production, even if they are small or only symbolic.

## Dependencies

This project uses Visual Studio 2017. You need .Net Framework 4.6.2 installed.

We provide you with an initial starting point based on the out-of-the-box Visual Studio SPA application template. Feel free to use it or replace it with a better template. If you prefer to load alternative or additional packages or frameworks from NuGet, please do.

There are dog picture URLs included as project resources, and a hook to load that data on app startup has been provided.

Please use the following in your solution:

* .Net Framework 4.6.2
* Entity Framework
* MVC
* RESTful endpoints
* AJAX (or similar) calls to respond to user actions

Entity objects can be directly added to your data context. Your solution should not depend on any db technology being deployed locally.

NUnit is included to facilitate both unit and integration tests. If another testing library is preferred, feel free to use it.

# Duration

It is suggested you complete this assessment within 4-5 hours. However, you have up to 24 hours to complete it. We encourage you to spend any leftover time to polish/document/test your app.

# Additional Considerations

While this falls outside of the challenge, please consider the following as you get ready to discuss your solution with the team:

* How would you package this for deployment?
* How and where would you deploy this app?
* How can you tell that the app is up and running?
* How would you configure the app as it goes from dev, to qa and finally to production?
* How would you insulate the app from a downstream API if it had one.
