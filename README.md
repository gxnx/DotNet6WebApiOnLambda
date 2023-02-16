
# .NET 6  Web API Template for AWS Lambda

This project is created for those who want to deploy their .NET 6 Core Web API to AWS Lambda easily. 


## Installation

* AWS CLI: https://docs.aws.amazon.com/cli/latest/userguide/getting-started-install.html
* AWS .NET Core CLI: https://docs.aws.amazon.com/lambda/latest/dg/csharp-package-cli.html
* .NET Tools: https://learn.microsoft.com/en-us/dotnet/core/tools/global-tools
* .NET 6.0 SDK: https://dotnet.microsoft.com/en-us/download/visual-studio-sdks

## Run Locally

Clone the project

```bash
  git clone https://github.com/gxnx/TestNetWebApiOnLambda/
```

Go to the project directory

```bash
  cd my-project
```

Install dependencies

```bash
  dotnet restore
```

Start the project

```bash
  dotnet run
```


## Deployment

To deploy this project to AWS Lambda:

```bash
dotnet deploy
```

Enter Runtime: (The runtime environment for the Lambda function)
```bash
dotnet6
```

Select IAM Role that to provide AWS credentials to your code:

Enter number with **Create new IAM Role** or existing role with **AWSLambdaBasicExecutionRole**

Enter Memory Size: (The amount of memory, in MB, your Lambda function is given)
```bash
512
```

Enter Timeout: (The function execution timeout in seconds)
```bash
30
```

Enter Handler: (Handler for the function <assembly>::<type>::<method>)

**Enter the namespace here!**
```bash
TestNetWebApiOnLambda
```




## Environment Variables

You need to put this to your AWS Lambda's Environment vairables to enable Swagger UI:

Key | Value
------------- | -------------
ASPNETCORE_ENVIRONMENT  | DEPLOYMENT



## Authors

- [@gxnx](https://github.com/gxnx)


## FAQ

#### When did I create this?

I created this on my free time.

#### Why did I create this?

To make my life easier.

