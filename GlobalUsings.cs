﻿global using System;
global using Azure.Identity;
global using Azure.Security.KeyVault.Secrets;
global using Microsoft.Azure.Functions.Worker;
global using Microsoft.Azure.Functions.Worker.Builder;
global using Microsoft.Azure.Functions.Worker.Middleware;
global using Microsoft.Extensions.Azure;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using TimerFunction;
global using TimerFunction.Config;
global using TimerFunction.Middleware;
global using TimerFunction.Model;
global using TimerFunction.ObserverablePattern;
